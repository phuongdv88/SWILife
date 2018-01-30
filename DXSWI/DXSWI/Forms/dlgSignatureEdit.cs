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
using DevExpress.XtraRichEdit;
using DXSWI.Modules;
using SWIBLL;
using System.IO;
using System.Security.Principal;

namespace DXSWI.Forms
{
    public partial class dlgSignatureEdit : DevExpress.XtraEditors.XtraForm
    {
        public delegate void updateSignature(string sig);
        public event updateSignature updateSignatureEvent;
        string _linkSignatureFile = string.Empty;
        public dlgSignatureEdit()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            // load signature from db
            // link to save signature of user:
            try
            {
                _linkSignatureFile = string.Format(@"{0}user\signature\{1}\signature.doc", Properties.Settings.Default.StorageLocation, UserManager.ActivatedUser.UserName);
                if (File.Exists(_linkSignatureFile))
                {
                    recMain.LoadDocument(_linkSignatureFile);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void sbSave_Click(object sender, EventArgs e)
        {
            // save to db
            try
            {
                if (!File.Exists(_linkSignatureFile))
                {
                    AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                    Directory.CreateDirectory(_linkSignatureFile.Replace("signature.doc", ""));
                }
                recMain.SaveDocument(_linkSignatureFile, DocumentFormat.Doc);
                updateSignatureEvent?.Invoke(recMain.HtmlText);
                Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dlgSignatureEdit_KeyDown(object sender, KeyEventArgs e)
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
    }
}