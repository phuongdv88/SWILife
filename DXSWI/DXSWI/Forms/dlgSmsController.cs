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
using SWIBLL;
using System.Text.RegularExpressions;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;

namespace DXSWI.Forms
{
    public partial class dlgSmsController : DevExpress.XtraEditors.XtraForm
    {
        public dlgSmsController()
        {
            InitializeComponent();
        }

        private void dlgSmsController_KeyDown(object sender, KeyEventArgs e)
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

        private void dlgSmsController_Load(object sender, EventArgs e)
        {
            Timer aTimer = new Timer();
            aTimer.Tick += updateDataTimer;
            aTimer.Interval = 1000 * 15; // check every 15s
            aTimer.Enabled = true;
            updateDataTimer(null, null);

            //GridColumn gridColumn = gvSendingMessages.Columns.AddVisible("Retry", string.Empty);
            //RepositoryItemButtonEdit repositoryItemButtonEdit = new RepositoryItemButtonEdit();
            //repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            //repositoryItemButtonEdit.ButtonClick += ribeRetry_ButtonClick;
            //gcSendingMessages.RepositoryItems.Add(repositoryItemButtonEdit);
            //gridColumn.ColumnEdit = repositoryItemButtonEdit;
            //gridColumn.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;

        }
        void updateDataTimer(object source, EventArgs e)
        {
            updateData();
        }
        private void updateSending()
        {
            try
            {
                int row = -1;
                if (gvSendingMessages.SelectedRowsCount > 0)
                {
                    row = gvSendingMessages.GetSelectedRows().First();
                }
                gcSendingMessages.DataSource = SmsManager.GetDataTableSmsSending();
                if (row != -1 && row < gvSendingMessages.RowCount)
                {
                    gvSendingMessages.ClearSelection();
                    gvSendingMessages.SelectRow(row);
                    gvSendingMessages.FocusedRowHandle = row;
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateReceiving()
        {
            try
            {
                int index = gvReceivingMessages.GetDataSourceRowIndex(gvReceivingMessages.FocusedRowHandle);
                gcReceivingMessages.DataSource = SmsManager.GetDataTableSmsReceiving();
                int rowHandle = gvReceivingMessages.GetRowHandle(index);
                gvReceivingMessages.FocusedRowHandle = rowHandle;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateData()
        {
            updateReceiving();
            updateSending();
        }

        private void gvReceivingMessages_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gvReceivingMessages.SelectedRowsCount > 0)
                {
                    DataRow data_row = gvReceivingMessages.GetDataRow(gvReceivingMessages.GetSelectedRows().First());
                    teFrom.Text = data_row["Sender"].ToString();
                    var name = data_row["CandidateName"].ToString().Trim();
                    if(name.Length > 0)
                    {
                        teFrom.Text = string.Format("{0} ({1})", name, teFrom.Text);
                    }
                    teToPhoneNumber.Text = data_row["Sender"].ToString();
                    //var name = 
                    meMessage.Text = data_row["Message"].ToString();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbSend_Click(object sender, EventArgs e)
        {
            // show warning if lenght > 160            
            string sms = meNewMessage.Text.Trim();
            var number = teFrom.Text.Trim();
            // correct number:
            // +84 -> 0; 84 -> 0; remove all of characters which is not a digit
            number = Regex.Replace(number, "\\D+", "", RegexOptions.Multiline);
            if (number.StartsWith("84"))
            {
                number = "0" + number.Remove(0, 2);
            }

            if (sms.Length == 0 || number.Length == 0)
                return;
            try
            {
                if (sms.Length > 160)
                {
                    throw new Exception("Cant send this message because message lengh > 160");
                }
                // if not start by 0 -> do not sent
                if (number.StartsWith("0") && number.Length > 9 && number.Length < 12)
                {
                    SmsSending tmp = new SmsSending() { PhoneNumber = number, Message = sms, TimeToSend = DateTime.Now };
                    SmsManager.InsertSmsSending(tmp);
                    updateSending();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                meNewMessage.Text = string.Empty;
            }

        }

        //private void gvSendingMessages_RowCellStyle(object sender, RowCellStyleEventArgs e)
        //{
        //    Color WaitingColor = Color.DarkGray;
        //    Color SentColor = Color.LightGreen;
        //    Color FailColor = Color.Red;
        //    Color ErrorColor = Color.DarkRed;

        //    //Changing the appearance settings of row cells dynamically 

        //    GridView view = sender as GridView;
        //    var value = view.GetRowCellValue(e.RowHandle, "Status").ToString();
        //    if (value == "Waiting")
        //    {
        //        e.Appearance.BackColor = WaitingColor;
        //    }
        //    else if (value == "Sent")
        //    {
        //        e.Appearance.BackColor = SentColor;
        //    }
        //    else if (value == "Fail")
        //    {
        //        e.Appearance.BackColor = FailColor;
        //    }
        //    else if (value == "Error")
        //    {
        //        e.Appearance.BackColor = ErrorColor;
        //    }

        //}

        private void gvSendingMessages_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            var value = view.GetRowCellValue(e.RowHandle, "Status").ToString();
            if (e.Column.FieldName == "CandidateName")
            {
                GridCellInfo cellInfo = e.Cell as GridCellInfo;
                TextEditViewInfo viewInfo = cellInfo.ViewInfo as TextEditViewInfo;
                if (viewInfo != null)
                {
                    if (value == "Waiting")
                    {
                        viewInfo.ContextImage = Properties.Resources.send;
                    }
                    else if (value == "Sent")
                    {
                        viewInfo.ContextImage = Properties.Resources.ok;
                    }
                    else if (value == "Fail")
                    {
                        viewInfo.ContextImage = Properties.Resources.fail;
                    }
                    else if (value == "Error")
                    {
                        viewInfo.ContextImage = Properties.Resources.error;
                    }
                    viewInfo.CalcViewInfo();
                }
            }
        }

        private void ribeRetry_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //resend 
            try
            {
                var smsId = Convert.ToInt64(gvSendingMessages.GetFocusedRowCellValue("SmsSendingId").ToString());
                SmsManager.ResendSmsSending(smsId);
                updateSending();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvSendingMessages_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gvSendingMessages.SelectedRowsCount > 0)
                {
                    DataRow data_row = gvSendingMessages.GetDataRow(gvSendingMessages.GetSelectedRows().First());
                    teToPhoneNumber.Text = data_row["PhoneNumber"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvReceivingMessages_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    if (XtraMessageBox.Show("Are you sure to delete this receiving sms message?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        deleteCurrentReceivingMessage();
                    }
                    break;
                default:
                    break;
            }
        }

        private void deleteCurrentReceivingMessage()
        {
            try
            {
                if (gvReceivingMessages.SelectedRowsCount > 0)
                {
                    DataRow data_row = gvReceivingMessages.GetDataRow(gvReceivingMessages.GetSelectedRows().First());
                    int id = Convert.ToInt32(data_row["SmsReceivingId"].ToString());
                    SmsManager.DeleteSmsReceiving(id);
                    updateReceiving();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvSendingMessages_KeyDown(object sender, KeyEventArgs e)
        {
            //if (sender is gvSendingMessages)
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        if (XtraMessageBox.Show("Are you sure to delete this sending sms message?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            deleteCurrentSendingMessage();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void deleteCurrentSendingMessage()
        {
            try
            {
                if (gvSendingMessages.SelectedRowsCount > 0)
                {
                    DataRow data_row = gvSendingMessages.GetDataRow(gvSendingMessages.GetSelectedRows().First());
                    int id = Convert.ToInt32(data_row["SmsSendingId"].ToString());
                    SmsManager.DeleteSmsSending(id);
                    updateSending();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}