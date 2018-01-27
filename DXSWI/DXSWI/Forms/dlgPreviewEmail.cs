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

namespace DXSWI.Forms
{
    public partial class dlgPreviewEmail : DevExpress.XtraEditors.XtraForm
    {
        public delegate void sendEmail();
        public event sendEmail sendEmailEvent;
        string _canName = string.Empty;
        string _comName = string.Empty;
        string _jobTitle = string.Empty;
        public dlgPreviewEmail(string subject, string contentHtml, string canName = "Nguyen Van A", string comName = "Swilife", string jobTitle = "Carrer consultant")
        {
            InitializeComponent();
            _canName = canName;
            _comName = comName;
            _jobTitle = jobTitle;
            textEditSubject.Text = genPreview(subject);
            recMain.HtmlText = genPreview(contentHtml);
        }

        private string genPreview(string content)
        {
            return content.Replace("[name]", _canName).Replace("[company]", _comName).Replace("[job]", _jobTitle);
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void setPreviewOnly(bool value)
        {
            if (value)
            {
                lciSend.Dispose();
                sbSend.Dispose();
                sbCancel.Text = "OK";
            }
        }

        private void sbSend_Click(object sender, EventArgs e)
        {
            Hide();
            sendEmailEvent?.Invoke();
            Close();
        }

        private void dlgPreviewEmail_KeyDown(object sender, KeyEventArgs e)
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
    }
}