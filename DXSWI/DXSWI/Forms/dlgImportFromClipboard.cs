using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SWIBLL.Models;
using PagedList;

namespace DXSWI.Forms
{
    public partial class dlgImportFromClipboard : DevExpress.XtraEditors.XtraForm
    {
        public enum ImportType
        {
            CANDIDATE,
            COMPANY,
            CONTACT,
            UNKNOWN
        }

        public enum ParseCandidateInfoStep
        {
            INIT,
            EXPERIENCE,
            EDUCATION,
            SKILL,
            LANGUAGE,
            CONTACT,
            FINISH,

        }
        ImportType mType = ImportType.UNKNOWN;

        public delegate void FillUpObjectData(object ob);

        public event FillUpObjectData FillUpObjectDataEvent;
        public dlgImportFromClipboard(ImportType itype)
        {
            InitializeComponent();
            mType = itype;
            pasteFromClipboard();
        }
        public void pasteFromClipboard()
        {
            meInfo.Text = Clipboard.GetText(TextDataFormat.UnicodeText);
        }

        private void getCandidateFromClipboard(ref Candidate can)
        {
            // parse can from memoINfo.Text
            ParseCandidateInfoStep state = ParseCandidateInfoStep.INIT;
            string[] lines = Clipboard.GetText().Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (lines.Count() < 9) return;
            for (int i = 8; i < lines.Length; ++i)
            {
                string line = lines[i];
                if (line.Trim().Length == 0) // remove emty lines
                    continue;
                if (state == ParseCandidateInfoStep.INIT)
                {
                    // get name:
                    if (string.Equals(line.Trim(), "Messaging"))
                    {
                        line = line.Trim();
                        // get name
                        do
                        {
                            if (i == lines.Count() - 1)
                            {
                                break;
                            }
                            ++i;
                            line = lines[i].Trim();
                            if (!line.Contains("account") && !line.Contains("upgrade") && !line.Contains("Background Image"))
                                break;
                        } while (true);

                        string[] names = line.Split(' ');
                        can.FirstName = names.Last();
                        can.LastName = names.First();
                        can.MiddleName = line.Replace(can.FirstName, "").Replace(can.LastName, "").Trim();
                        // get position
                        i += 2;
                        line = lines[i].Trim();
                        can.CurrentPosition = line;
                        //string[] test = line.Split('\n');
                        // get current company and education
                        ++i;
                        line = lines[i].Trim();
                        can.CurrentEmployer = line;
                        // get location
                        ++i;
                        line = lines[i].Trim();
                        can.Country = line.Split(' ').First(); ;

                    }
                    else if (string.Equals(line.Trim(), "Experience"))
                    {
                        state = ParseCandidateInfoStep.EXPERIENCE;

                    }
                    continue;
                }
                else if (state == ParseCandidateInfoStep.EXPERIENCE)
                {
                    if (string.Equals(line.Trim(), "Education"))
                    {
                        state = ParseCandidateInfoStep.EDUCATION;
                    }
                    else
                    {
                        if (can.ProjectDone.Length + line.Length < 2000 - 2)
                        {
                            can.ProjectDone += line.TrimStart() + "\r\n";
                        }
                    }
                    continue;
                }
                else if (state == ParseCandidateInfoStep.EDUCATION)
                {
                    if (line.Contains("See connections"))
                    {
                        state = ParseCandidateInfoStep.CONTACT;
                    }
                    else if (string.Equals(line.Trim(), "Languages"))
                    {
                        state = ParseCandidateInfoStep.LANGUAGE;
                    }
                    else if (string.Equals(line.Trim(), "Featured Skills & Endorsements"))
                    {
                        state = ParseCandidateInfoStep.SKILL;
                    }
                    else
                    {
                        if (can.Education.Length + line.Length < 2000 - 2 && !can.Education.Contains(line.Trim()))
                        {
                            can.Education += line.TrimStart() + "\r\n";
                            if (can.CurrentEmployer.Contains(line.Trim()))
                            {
                                can.CurrentEmployer = can.CurrentEmployer.Replace(line.Trim(), "").Trim();
                            }
                        }
                    }
                    continue;
                }
                else if (state == ParseCandidateInfoStep.SKILL)
                {
                    line = line.Trim();
                    if (string.Equals(line, "Accomplishments"))
                    {
                        i += 2;
                        line = lines[i].Trim();

                        if (string.Equals(line, "Languages"))
                        {
                            state = ParseCandidateInfoStep.LANGUAGE;
                        }
                        else
                        {
                            state = ParseCandidateInfoStep.CONTACT;
                        }
                    }
                    else
                    {
                        if (can.KeySkills.Length + line.Length < 1000 - 2 && !can.KeySkills.Contains(line))
                        {
                            if (line.Contains("See"))
                            {
                                line = line.Split(new[] { "See" }, StringSplitOptions.None).First();
                                if (can.KeySkills.Length > 0)
                                {
                                    can.KeySkills += "; ";
                                }
                                can.KeySkills += line;
                            }
                        }
                    }
                    continue;
                }
                else if (state == ParseCandidateInfoStep.LANGUAGE)
                {
                    can.Language = line.Trim();
                    state = ParseCandidateInfoStep.CONTACT;
                    continue;
                }
                else if (state == ParseCandidateInfoStep.CONTACT)
                {
                    line = line.Trim();
                    if (string.Equals(line, "Certification"))
                    {
                        do
                        {
                            ++i;
                            line = lines[i].Trim();
                        } while (line.Length == 0);
                        can.Education += line.TrimStart() + "\r\n";
                    }
                    else if (string.Equals(line, "Contact and Personal Info"))
                    {
                        ++i;
                        do
                        {
                            ++i;
                            line = lines[i].Trim();
                        } while (line.Length == 0);
                        can.WebSite = line;
                    }
                    else if (string.Equals(line, "Phone"))
                    {
                        do
                        {
                            ++i;
                            line = lines[i].Trim();
                        } while (line.Length == 0);
                        can.WorkPhone = line.Split(new[] { " (" }, StringSplitOptions.RemoveEmptyEntries).First();
                    }
                    else if (string.Equals(line, "Email"))
                    {
                        do
                        {
                            ++i;
                            line = lines[i].Trim();
                        } while (line.Length == 0);
                        can.Email = line;
                    }
                    else if (string.Equals(line, "IM"))
                    {
                        do
                        {
                            ++i;
                            line = lines[i].Trim();
                        } while (line.Length == 0);
                        can.SkypeIM = line;
                    }
                    continue;
                }
            }
        }

        private void getCompanyFromClipboard(ref Company com)
        {


        }

        private void getContactFromClipboard(ref Contact con)
        {

        }

        private void dlgImportFromClipboard_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                default:
                    break;
            }
        }

        private void sbImport_Click(object sender, EventArgs e)
        {
            switch (mType)
            {
                case ImportType.CANDIDATE:
                    Candidate can = new Candidate();
                    getCandidateFromClipboard(ref can);
                    FillUpObjectDataEvent?.Invoke(can);
                    break;
                case ImportType.COMPANY:
                    Company com = new Company();
                    getCompanyFromClipboard(ref com);
                    FillUpObjectDataEvent?.Invoke(com);
                    break;
                case ImportType.CONTACT:
                    Contact con = new Contact();
                    getContactFromClipboard(ref con);
                    FillUpObjectDataEvent?.Invoke(con);
                    break;
                case ImportType.UNKNOWN:
                    break;
                default:
                    break;
            }

            Close();
        }
    }
}