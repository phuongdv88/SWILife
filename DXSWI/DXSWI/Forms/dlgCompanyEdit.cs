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
using SWIBLL;
using SWIBLL.Models;
using System.IO;
using System.Security.Principal;

namespace DXSWI.Forms
{
    public partial class dlgCompanyEdit : DevExpress.XtraEditors.XtraForm
    {
        Company mCompany = null;
        bool isNew = true;
        public delegate void onUpdateData();
        public event onUpdateData UpdateDataEvent;
        string FileName;
        string FileLink;
        string deleteFileLink;
        public dlgCompanyEdit(long comId)
        {
            InitializeComponent();
            init(comId);
        }

        public void init(long comId)
        {
            if (comId == -1)
            {
                isNew = true;
            }
            else
            {
                isNew = false;
                mCompany = CompanyManager.getCompany(comId);
                FillObjectToUi();
                if (mCompany != null)
                {
                    loadAttachment(mCompany.ScanLink);
                }
            }
        }

        private void loadAttachment(string link)
        {
            // load attachment from disk
            if (link == null || link.Length == 0)
            {
                this.sliAttachment.Text = "No file chosen";
                this.sbDeleteAttachment.Enabled = false;
                this.sbDownloadAttachment.Enabled = false;

            }
            else
            {
                this.sliAttachment.Text = link.Split('\\').Last();
                this.sbDeleteAttachment.Enabled = true;
                this.sbDownloadAttachment.Enabled = true;
            }

        }

        public void getOjectFromUi()
        {
            if (mCompany == null)
                mCompany = new Company();
            mCompany.Name = this.NameTextEdit.Text;
            mCompany.PrimaryPhone = this.PrimaryPhoneTextEdit.Text;
            mCompany.SecondaryPhone = this.SecondaryPhoneTextEdit.Text;
            mCompany.FaxNumber = this.FaxNumberTextEdit.Text;
            mCompany.Address = this.AddressTextEdit.Text;
            mCompany.CountryOfOrigin = this.CountryOfOriginTextEdit.Text;
            mCompany.WebSite = this.WebSiteTextEdit.Text;
            mCompany.KeyTechnologies = this.KeyTechnologiesTextEdit.Text;
            mCompany.Industry = this.IndustryComboBoxEdit.Text;
            mCompany.ABC = this.ABCTextEdit.Text;
            mCompany.IsActive = this.IsActiveCheckEdit.Checked;
            mCompany.City = this.CityTextEdit.Text;
            mCompany.State = this.StateTextEdit.Text;
            mCompany.PostalCode = this.PostalCodeTextEdit.Text;
            mCompany.IsHot = this.IsHotCheckEdit.Checked;
            if (ContractSigingTimeDateEdit.Text.Length > 0)
            {
                mCompany.ContractSigingTime = DateTime.Parse(this.ContractSigingTimeDateEdit.DateTime.ToString("yyyy/MM/dd"));
            }
            mCompany.MiscNotes = this.MiscNotesTextEdit.Text;
            mCompany.ServiceContractTerms = this.ServiceContractTermsTextEdit.Text;
        }

        private void FillObjectToUi()
        {
            if (mCompany == null) return;
            this.NameTextEdit.Text = mCompany.Name;
            this.PrimaryPhoneTextEdit.Text = mCompany.PrimaryPhone;
            this.SecondaryPhoneTextEdit.Text = mCompany.SecondaryPhone;
            this.FaxNumberTextEdit.Text = mCompany.FaxNumber;
            this.AddressTextEdit.Text = mCompany.Address;
            this.CountryOfOriginTextEdit.Text = mCompany.CountryOfOrigin;
            this.WebSiteTextEdit.Text = mCompany.WebSite;
            this.KeyTechnologiesTextEdit.Text = mCompany.KeyTechnologies;
            this.IndustryComboBoxEdit.EditValue = mCompany.Industry;
            this.ABCTextEdit.Text = mCompany.ABC;
            this.IsActiveCheckEdit.Checked = mCompany.IsActive;
            this.CityTextEdit.Text = mCompany.City;
            this.StateTextEdit.Text = mCompany.State;
            this.PostalCodeTextEdit.Text = mCompany.PostalCode;
            this.IsHotCheckEdit.Checked = mCompany.IsHot;
            this.ContractSigingTimeDateEdit.Text = mCompany.ContractSigingTime.ToString("dd/MM/yyyy");
            this.MiscNotesTextEdit.Text = mCompany.MiscNotes;
            this.ServiceContractTermsTextEdit.Text = mCompany.ServiceContractTerms;
        }

        private void sbAttachFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            if (openFileDlg.ShowDialog() != DialogResult.OK)
                return;
            // check size of file
            if (new System.IO.FileInfo(openFileDlg.FileName).Length > 10e6) // 10MB
            {
                XtraMessageBox.Show("Attactment is too big (more than 10 MB)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // store link file , copy to server when click ok
            FileLink = openFileDlg.FileName;
            FileName = FileLink.Split('\\').Last();
            this.sliAttachment.Text = FileName;
        }

        private void sbDeleteAttachment_Click(object sender, EventArgs e)
        {
            if (mCompany == null) return;
            if (XtraMessageBox.Show("Are you sure to delete this file?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deleteFileLink = mCompany.ScanLink;
                mCompany.ScanLink = string.Empty;
            }
            loadAttachment(null);
        }

        private void sbDownloadAttachment_Click(object sender, EventArgs e)
        {
            // download to local or open this file
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Save file to";
            dlg.RestoreDirectory = true;
            dlg.Filter = "All files (*.*)|*.*";
            dlg.FileName = mCompany.ScanLink.Split('\\').Last();
            if (dlg.ShowDialog() != DialogResult.OK)
                return;
            string save_link = dlg.FileName;
            File.Copy(mCompany.ScanLink, save_link);
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            try
            {
                getOjectFromUi();
                // if link and fileaname len > 0 then copy file to server and set scanlink for mcompany
                if (FileLink?.Length > 0)
                {
                    string folderName = mCompany.Name + DateTime.Now.ToString(@"_yyyy-MM-dd") + Utils.getRandomAlphaNumeric(10);
                    string dir = string.Format(@"{0}company\attachment\{1}\{2}", Properties.Settings.Default.StorageLocation, folderName, FileName);
                    mCompany.ScanLink = dir;
                    AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                    Directory.CreateDirectory(mCompany.ScanLink.Replace(mCompany.ScanLink.Split('\\').Last(), ""));
                    File.Copy(FileLink, mCompany.ScanLink, true);
                }

                if (isNew)
                {
                    // use inserting function
                    mCompany.UserId = UserManager.ActivatedUser.Index;
                    CompanyManager.addNewCompany(mCompany);
                }
                else
                {
                    // use updating function
                    CompanyManager.UpdateCompany(mCompany);
                    // if deletelink is not empty -> delete scanfunction
                    if (deleteFileLink?.Length > 0)
                    {
                        try {
                            File.Delete(deleteFileLink);
                        }
                        catch { }
                    }
                }
                UpdateDataEvent?.Invoke();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dlgCompanyEdit_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        public void setReadOnlyMode(bool value)
        {
            this.NameTextEdit.ReadOnly = value;
            this.PrimaryPhoneTextEdit.ReadOnly = value;
            this.SecondaryPhoneTextEdit.ReadOnly = value;
            this.FaxNumberTextEdit.ReadOnly = value;
            this.AddressTextEdit.ReadOnly = value;
            this.CountryOfOriginTextEdit.ReadOnly = value;
            this.WebSiteTextEdit.ReadOnly = value;
            this.KeyTechnologiesTextEdit.ReadOnly = value;
            this.IndustryComboBoxEdit.ReadOnly = value;
            this.ABCTextEdit.ReadOnly = value;
            this.IsActiveCheckEdit.ReadOnly = value;
            this.CityTextEdit.ReadOnly = value;
            this.StateTextEdit.ReadOnly = value;
            this.PostalCodeTextEdit.ReadOnly = value;
            this.IsHotCheckEdit.ReadOnly = value;
            this.ContractSigingTimeDateEdit.ReadOnly = value;
            this.MiscNotesTextEdit.ReadOnly = value;
            this.ServiceContractTermsTextEdit.ReadOnly = value;
            this.sbAttachFile.Enabled = !value;
            this.sbDeleteAttachment.Enabled = !value;
            this.sbDownloadAttachment.Enabled = !value;
            this.sbOK.Enabled = !value;
        }
    }
}