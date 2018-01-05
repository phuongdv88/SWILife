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
    public partial class dlgContactEdit : DevExpress.XtraEditors.XtraForm
    {
        public delegate void onUpdateData();
        public event onUpdateData emitUpdateData;
        Contact mContact;
        string fileNameAvatar = string.Empty;
        string link = string.Empty;
        Dictionary<string, long> listCompanyNameAndId = new Dictionary<string, long>();

        bool isReadOnlyMod = false;

        public dlgContactEdit(long contactId, string toolTip)
        {
            InitializeComponent();
            try
            {
                init(contactId, toolTip);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void init(long contactId, string toolTip)
        {
            if (!string.IsNullOrEmpty(toolTip))
            {
                ImagePictureEdit.ToolTip = toolTip;
                ImagePictureEdit.Cursor = Cursors.Hand;
            }
            else ImagePictureEdit.Cursor = Cursors.Default;
            if (contactId == -1)
            {
                return;
            }
            mContact = ContactManager.getContactById(contactId);
            getlistCompany(ref listCompanyNameAndId);
            FillObjectToUi();
        }

        private void dlgContactEdit_KeyDown(object sender, KeyEventArgs e)
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

        private void ImagePictureEdit_DoubleClick(object sender, EventArgs e)
        {
            if (isReadOnlyMod)
            {
                return;
            }
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "Jpeps|*.jpg|Png|*.png|Bitmaps|*.bmp";
            try
            {
                if (openFileDlg.ShowDialog() == DialogResult.OK)
                {
                    ImagePictureEdit.Image = Bitmap.FromFile(openFileDlg.FileName);
                    fileNameAvatar = openFileDlg.FileName.Split('\\').Last();
                    link = openFileDlg.FileName;
                }
            }
            catch
            {
                ImagePictureEdit.Image = null;
            }
        }

        private void FillObjectToUi()
        {
            if (mContact != null)
            {
                FirstNameTextEdit.Text = mContact.FirstName;
                MiddleNameTextEdit.Text = mContact.MiddleName;
                LastNameTextEdit.Text = mContact.LastName;
                TitleTextEdit.Text = mContact.Title;
                DepartmentTextEdit.Text = mContact.Department;
                ReportToTextEdit.Text = mContact.ReportTo;
                isHotCheckEdit.Checked = mContact.isHot;
                EmailTextEdit.Text = mContact.Email;
                SecondaryEmailTextEdit.Text = mContact.SecondaryEmail;
                CellPhoneTextEdit.Text = mContact.CellPhone;
                WorkPhoneTextEdit.Text = mContact.WorkPhone;
                OtherPhoneTextEdit.Text = mContact.OtherPhone;
                AddressTextEdit.Text = mContact.Address;
                CityTextEdit.Text = mContact.City;
                StateTextEdit.Text = mContact.State;
                PostalCodeTextEdit.Text = mContact.PostalCode;
                ProfileLinkTextEdit.Text = mContact.ProfileLink;
                MiscNotesMemoEdit.Text = mContact.MiscNotes;
                CompanyNameComboboxEdit.Properties.Items.Clear();
                CompanyNameComboboxEdit.Properties.Items.AddRange(listCompanyNameAndId.Keys);
                CompanyNameComboboxEdit.EditValue = mContact.CompanyName; // companyId
                try
                {
                    ImagePictureEdit.Image = Bitmap.FromFile(mContact.ImageLink);
                }
                catch
                {
                    ImagePictureEdit.Image = null;
                };
            }
        }

        private void GetObjectFromUi()
        {
            if (mContact == null)
            {
                mContact = new Contact();
                mContact.UserId = UserManager.ActivatedUser.UserId;
                mContact.Created = DateTime.Now;
            }
            mContact.FirstName = FirstNameTextEdit.Text;
            mContact.MiddleName = MiddleNameTextEdit.Text;
            mContact.LastName = LastNameTextEdit.Text;
            mContact.Title = TitleTextEdit.Text;
            mContact.Department = DepartmentTextEdit.Text;
            mContact.ReportTo = ReportToTextEdit.Text;
            mContact.isHot = isHotCheckEdit.Checked;
            mContact.Email = EmailTextEdit.Text;
            mContact.SecondaryEmail = SecondaryEmailTextEdit.Text;
            mContact.CellPhone = CellPhoneTextEdit.Text;
            mContact.WorkPhone = WorkPhoneTextEdit.Text;
            mContact.OtherPhone = OtherPhoneTextEdit.Text;
            mContact.Address = AddressTextEdit.Text;
            mContact.City = CityTextEdit.Text;
            mContact.State = StateTextEdit.Text;
            mContact.PostalCode = PostalCodeTextEdit.Text;
            mContact.ProfileLink = ProfileLinkTextEdit.Text;
            mContact.MiscNotes = MiscNotesMemoEdit.Text;
            mContact.CompanyName = CompanyNameComboboxEdit.Text; // companyId
            mContact.CompanyId = -1;
            if (listCompanyNameAndId.ContainsKey(mContact.CompanyName))
            {
                mContact.CompanyId = listCompanyNameAndId[mContact.CompanyName];
            }
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbOk_Click(object sender, EventArgs e)
        {
            try
            {
                GetObjectFromUi();
                // update imagelink of contact
                if (fileNameAvatar.Length > 0)
                {
                    if (mContact.ImageLink == null || mContact.ImageLink.Length == 0)
                    {
                        // create new
                        string folderName = mContact.LastName + mContact.FirstName + mContact.Created.ToString("yyyy-MM-dd") + Utils.getRandomAlphaNumeric(10);
                        string dir = string.Format(@"{0}contacts\avatar\{1}\{2}", Properties.Settings.Default.StorageLocation, folderName, fileNameAvatar);
                        mContact.ImageLink = dir;
                    }
                    else
                    {
                        // update link of avatar
                        var old_file_name = mContact.ImageLink.Split('\\').Last();
                        mContact.ImageLink = mContact.ImageLink.Replace(old_file_name, fileNameAvatar);
                    }
                    // copy image to server
                    if (link.Length > 0)
                    {
                        AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                        Directory.CreateDirectory(mContact.ImageLink.Replace(mContact.ImageLink.Split('\\').Last(), ""));
                        File.Copy(link, mContact.ImageLink, true);
                    }

                }
                //update to db
                if (mContact.ContactId == -1)
                {
                    ContactManager.InsertContact(mContact);
                }
                else
                {
                    ContactManager.UpdateContact(mContact);
                }
                //emit main form reload gridview control
                emitUpdateData?.Invoke();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        public void setReadOnlyMode(bool value)
        {
            FirstNameTextEdit.ReadOnly = value;
            MiddleNameTextEdit.ReadOnly = value;
            LastNameTextEdit.ReadOnly = value;
            TitleTextEdit.ReadOnly = value;
            DepartmentTextEdit.ReadOnly = value;
            ReportToTextEdit.ReadOnly = value;
            isHotCheckEdit.ReadOnly = value;
            EmailTextEdit.ReadOnly = value;
            SecondaryEmailTextEdit.ReadOnly = value;
            CellPhoneTextEdit.ReadOnly = value;
            WorkPhoneTextEdit.ReadOnly = value;
            OtherPhoneTextEdit.ReadOnly = value;
            AddressTextEdit.ReadOnly = value;
            CityTextEdit.ReadOnly = value;
            StateTextEdit.ReadOnly = value;
            PostalCodeTextEdit.ReadOnly = value;
            ProfileLinkTextEdit.ReadOnly = value;
            MiscNotesMemoEdit.ReadOnly = value;
            CompanyNameComboboxEdit.ReadOnly = value;
            //ImagePictureEdit.Enabled = !value;
            sbOk.Enabled = !value;
            isReadOnlyMod = value;
        }
        // get list company
        private void getlistCompany(ref Dictionary<string, long> listCompany )
        {
            try {
                listCompany.Clear();
                DataTable dt = CompanyManager.getNameCompanies();
                if (dt == null) return;
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    DataRow data_row = dt.Rows[i];
                    listCompany.Add(data_row["Name"].ToString(), Convert.ToInt64(data_row["CompanyId"].ToString()));
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}