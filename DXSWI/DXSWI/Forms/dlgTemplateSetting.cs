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
using DXSWI.Forms;
using SWIBLL;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;

namespace DXSWI.Forms
{
    public partial class dlgTemplateSetting : DevExpress.XtraEditors.XtraForm
    {
        public delegate void updateData(string subject, string content);
        public event updateData updateDataEvent;
        public dlgTemplateSetting()
        {
            InitializeComponent();
            updateListTemplate();
        }

        private void dlgTemplateSetting_KeyDown(object sender, KeyEventArgs e)
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

        private void sbCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sbSet_Click(object sender, EventArgs e)
        {
            if (gvTemplate.SelectedRowsCount > 0)
            {
                try
                {
                    // delete this running task data
                    int row = gvTemplate.GetSelectedRows().First();
                    DataRow data_row = gvTemplate.GetDataRow(row);
                    string subject = data_row["Subject"].ToString();
                    string content = data_row["Content"].ToString();
                    updateDataEvent?.Invoke(subject, content);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
            } else 
            {
                XtraMessageBox.Show("No template has been chosen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbEdit_Click(object sender, EventArgs e)
        {
            if (gvTemplate.SelectedRowsCount > 0)
            {
                try
                {
                    // delete this running task data
                    int row = gvTemplate.GetSelectedRows().First();
                    DataRow data_row = gvTemplate.GetDataRow(row);
                    int emailTemplateID = int.Parse(data_row["EmailTemplateId"].ToString());
                    dlgEmailTemplateEdit dlg = new dlgEmailTemplateEdit(emailTemplateID);
                    dlg.updateDataEvent += updateListTemplate;
                    dlg.ShowDialog();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sbNew_Click(object sender, EventArgs e)
        {
            dlgEmailTemplateEdit dlg = new dlgEmailTemplateEdit(-1);
            dlg.updateDataEvent += updateListTemplate;
            dlg.ShowDialog();
        }

        private void updateListTemplate()
        {
            try
            {
                // load data in candidate table and show in grid control
                gcTemplates.DataSource = EmailTemplateManager.GetEmailTemplates();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gcTemplates_DoubleClick(object sender, EventArgs e)
        {
            sbEdit.PerformClick();
        }

        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.Info != null || e.SelectedControl != gcTemplates) return;

            //Get the view at the current mouse position
            GridView view = gcTemplates.FocusedView as GridView;
            if (view == null) return;
            //Get the view's element information that resides at the current position
            GridHitInfo info = view.CalcHitInfo(e.ControlMousePosition);
            //Display a hint for row indicator cells
            if (info.InRowCell)
            {
                int row = info.RowHandle;
                DataRow data_row = gvTemplate.GetDataRow(row);
                string subject = data_row["Subject"].ToString();
                string content = data_row["Content"].ToString();
                string cellKey = info.RowHandle.ToString() + " - " + info.Column.ToString();
                e.Info = new ToolTipControlInfo(cellKey, string.Format("Subject: {0} \r\nContent:{1}",subject, content));
            }
        }
    }
}