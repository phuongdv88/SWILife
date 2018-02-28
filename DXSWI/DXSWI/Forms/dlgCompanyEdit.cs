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
using System.Diagnostics;

namespace DXSWI.Forms
{
    public partial class dlgCompanyEdit : DevExpress.XtraEditors.XtraForm
    {
        long _comId = -1;
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
            _comId = comId;
            updateData();
        }

        void updateData()
        {
            if (_comId == -1)
            {
                isNew = true;
            }
            else
            {
                try
                {
                    isNew = false;
                    mCompany = CompanyManager.getCompany(_comId);
                    FillObjectToUi();
                    if (mCompany != null)
                    {
                        loadAttachment(mCompany.ScanLink);
                    }
                    // load contact of this company
                    gcContact.DataSource = ContactManager.getContactsByCompanyId(_comId);
                    gcJobOrder.DataSource = JobOrderManager.getJobOrdersByCompanyId(_comId);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void loadAttachment(string link)
        {
            // load attachment from disk
            if (link == null || link.Length == 0)
            {
                sliAttachment.Text = "No file chosen";
                sbDeleteAttachment.Enabled = false;
                sbDownloadAttachment.Enabled = false;
                sbViewFile.Enabled = false;

            }
            else
            {
                sliAttachment.Text = link.Split('\\').Last();
                sbDeleteAttachment.Enabled = true;
                sbDownloadAttachment.Enabled = true;
                sbViewFile.Enabled = true;
            }

        }

        public void getOjectFromUi()
        {
            if (mCompany == null)
                mCompany = new Company();
            mCompany.Name = NameTextEdit.Text;
            mCompany.PrimaryPhone = PrimaryPhoneTextEdit.Text;
            mCompany.SecondaryPhone = SecondaryPhoneTextEdit.Text;
            mCompany.FaxNumber = FaxNumberTextEdit.Text;
            mCompany.Address = AddressTextEdit.Text;
            mCompany.CountryOfOrigin = CountryOfOriginTextEdit.Text;
            mCompany.WebSite = WebSiteTextEdit.Text;
            mCompany.KeyTechnologies = KeyTechnologiesTextEdit.Text;
            mCompany.Industry = IndustryComboBoxEdit.Text;
            mCompany.ABC = ABCTextEdit.Text;
            mCompany.IsActive = IsActiveCheckEdit.Checked;
            mCompany.City = CityTextEdit.Text;
            mCompany.State = StateTextEdit.Text;
            mCompany.PostalCode = PostalCodeTextEdit.Text;
            mCompany.IsHot = IsHotCheckEdit.Checked;
            if (ContractSigingTimeDateEdit.Text.Length > 0)
            {
                mCompany.ContractSigingTime = DateTime.Parse(ContractSigingTimeDateEdit.DateTime.ToString("yyyy/MM/dd"));
            }
            mCompany.MiscNotes = MiscNotesTextEdit.Text;
            mCompany.ServiceContractTerms = ServiceContractTermsTextEdit.Text;
        }

        private void FillObjectToUi()
        {
            if (mCompany == null) return;
            
            NameTextEdit.Text = mCompany.Name;
            if(mCompany.Name.Length > 0)
            {
                Text = mCompany.Name;
            } else
            {
                Text = "New Company";
            }
            PrimaryPhoneTextEdit.Text = mCompany.PrimaryPhone;
            SecondaryPhoneTextEdit.Text = mCompany.SecondaryPhone;
            FaxNumberTextEdit.Text = mCompany.FaxNumber;
            AddressTextEdit.Text = mCompany.Address;
            CountryOfOriginTextEdit.Text = mCompany.CountryOfOrigin;
            WebSiteTextEdit.Text = mCompany.WebSite;
            KeyTechnologiesTextEdit.Text = mCompany.KeyTechnologies;
            IndustryComboBoxEdit.EditValue = mCompany.Industry;
            ABCTextEdit.Text = mCompany.ABC;
            IsActiveCheckEdit.Checked = mCompany.IsActive;
            CityTextEdit.Text = mCompany.City;
            StateTextEdit.Text = mCompany.State;
            PostalCodeTextEdit.Text = mCompany.PostalCode;
            IsHotCheckEdit.Checked = mCompany.IsHot;
            ContractSigingTimeDateEdit.Text = mCompany.ContractSigingTime.ToString("dd/MM/yyyy");
            MiscNotesTextEdit.Text = mCompany.MiscNotes;
            ServiceContractTermsTextEdit.Text = mCompany.ServiceContractTerms;

            // tooltip
            NameTextEdit.ToolTip = mCompany.Name;
            PrimaryPhoneTextEdit.ToolTip = mCompany.PrimaryPhone;
            SecondaryPhoneTextEdit.ToolTip = mCompany.SecondaryPhone;
            FaxNumberTextEdit.ToolTip = mCompany.FaxNumber;
            AddressTextEdit.ToolTip = mCompany.Address;
            CountryOfOriginTextEdit.ToolTip = mCompany.CountryOfOrigin;
            WebSiteTextEdit.ToolTip = mCompany.WebSite;
            KeyTechnologiesTextEdit.ToolTip = mCompany.KeyTechnologies;
            ABCTextEdit.ToolTip = mCompany.ABC;
            CityTextEdit.ToolTip = mCompany.City;
            StateTextEdit.ToolTip = mCompany.State;
            PostalCodeTextEdit.ToolTip = mCompany.PostalCode;
            ContractSigingTimeDateEdit.ToolTip = mCompany.ContractSigingTime.ToString("dd/MM/yyyy");
            MiscNotesTextEdit.ToolTip = mCompany.MiscNotes;
            ServiceContractTermsTextEdit.ToolTip = mCompany.ServiceContractTerms;
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
            sliAttachment.Text = FileName;
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
                    mCompany.UserId = UserManager.ActivatedUser.UserId;
                    if (!CompanyManager.IsCompanyExisted(mCompany))
                    {
                        CompanyManager.addNewCompany(mCompany);
                    }
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
                    Close();
                    break;
                default:
                    break;
            }
        }

        public void setReadOnlyMode(bool value)
        {
            NameTextEdit.ReadOnly = value;
            PrimaryPhoneTextEdit.ReadOnly = value;
            SecondaryPhoneTextEdit.ReadOnly = value;
            FaxNumberTextEdit.ReadOnly = value;
            AddressTextEdit.ReadOnly = value;
            CountryOfOriginTextEdit.ReadOnly = value;
            WebSiteTextEdit.ReadOnly = value;
            KeyTechnologiesTextEdit.ReadOnly = value;
            IndustryComboBoxEdit.ReadOnly = value;
            ABCTextEdit.ReadOnly = value;
            IsActiveCheckEdit.ReadOnly = value;
            CityTextEdit.ReadOnly = value;
            StateTextEdit.ReadOnly = value;
            PostalCodeTextEdit.ReadOnly = value;
            IsHotCheckEdit.ReadOnly = value;
            ContractSigingTimeDateEdit.ReadOnly = value;
            MiscNotesTextEdit.ReadOnly = value;
            ServiceContractTermsTextEdit.ReadOnly = value;
            sbAttachFile.Enabled = !value;
            sbDeleteAttachment.Enabled = !value;
            sbDownloadAttachment.Enabled = !value;
            sbOK.Enabled = !value;
        }

        private void sbViewFile_Click(object sender, EventArgs e)
        {
             try {
                if(mCompany.ScanLink == "")
                {
                    return;
                }
                Process p = new Process();
                p.StartInfo.FileName = mCompany.ScanLink;
                p.Start();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvContact_DoubleClick(object sender, EventArgs e)
        {
            EditContact();
        }
        public void EditContact()
        {
            try
            {
                // delete this running task data
                if (gvContact.SelectedRowsCount > 0)
                {
                    int row = gvContact.GetSelectedRows().First();
                    DataRow data_row = gvContact.GetDataRow(row);
                    long conId = Convert.ToInt64(data_row["ContactId"].ToString());
                    dlgContactEdit dlg = new dlgContactEdit(conId, null);
                    dlg.emitUpdateData += updateData;
                    dlg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvJobOrder_DoubleClick(object sender, EventArgs e)
        {
            EditJobOrder();
        }
        public void EditJobOrder()
        {
            long jobOrderId = -1;
            if (gvJobOrder.SelectedRowsCount > 0)
            {
                jobOrderId = Convert.ToInt64(gvJobOrder.GetDataRow(gvJobOrder.GetSelectedRows().First())["JobOrderId"].ToString());
            }
            dlgJobOrderEdit dlg = new dlgJobOrderEdit(jobOrderId);
            dlg.UpdateDataEvent += updateData;
            dlg.ShowDialog();
        }
    }
}