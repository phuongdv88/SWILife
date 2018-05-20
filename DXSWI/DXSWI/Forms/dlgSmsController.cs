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
using System.Globalization;

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
            aTimer.Interval = 1000 * 60; // check every 15s
            aTimer.Enabled = true;
            updateDataTimer(null, null);
            //int rowHandle = gvReceivingMessages.GetRowHandle(gvReceivingMessages.RowCount - 1);
            //gvReceivingMessages.FocusedRowHandle = rowHandle;
            //rowHandle = gvSendingMessages.GetRowHandle(gvSendingMessages.RowCount - 1);
            //gvSendingMessages.FocusedRowHandle = rowHandle;
            //gvSendingMessages.SelectRow(gvSendingMessages.RowCount - 2);
            //gvReceivingMessages.SelectRow(gvReceivingMessages.RowCount - 2);
        }
        void updateDataTimer(object source, EventArgs e)
        {
            updateData();
        }
        private async Task updateSending()
        {
            try
            {
                int row = -1;
                if (gvSendingMessages.SelectedRowsCount > 0)
                {
                    row = gvSendingMessages.GetSelectedRows().First();
                }
                gcSendingMessages.DataSource = await SmsManager.GetDataTableSmsSendingAsync();
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

        private async Task  updateReceiving()
        {
            try
            {
                int index = gvReceivingMessages.GetDataSourceRowIndex(gvReceivingMessages.FocusedRowHandle);
                gcReceivingMessages.DataSource = await SmsManager.GetDataTableSmsReceivingAsync();
                int rowHandle = gvReceivingMessages.GetRowHandle(index);
                gvReceivingMessages.FocusedRowHandle = rowHandle;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task updateData()
        {
            updateReceiving();
            updateSending();
        }

        private void sbSend_Click(object sender, EventArgs e)
        {
            // show warning if lenght > 160            
            string sms = meNewMessage.Text.Trim();
            sms = string.Concat(sms.Normalize(NormalizationForm.FormD).Where(
  c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark));
            var number = teToPhoneNumber.Text.Trim();
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
                    tmp.CandidateId = SmsManager.getCandidateIdFromNumber(tmp.PhoneNumber);
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

        private void gvReceivingMessages_RowClick(object sender, RowClickEventArgs e)
        {

            try
            {
                if (gvReceivingMessages.SelectedRowsCount > 0)
                {
                    DataRow data_row = gvReceivingMessages.GetDataRow(gvReceivingMessages.GetSelectedRows().First());
                    teFrom.Text = data_row["Sender"].ToString();
                    var name = data_row["CandidateName"].ToString().Trim();
                    if (name.Length > 0)
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

        private void gvSendingMessages_RowClick(object sender, RowClickEventArgs e)
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

        private void resendThisMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Are you sure to resend sms message?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var smsId = Convert.ToInt64(gvSendingMessages.GetFocusedRowCellValue("SmsSendingId").ToString());
                    SmsManager.ResendSmsSending(smsId);
                    updateSending();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void meNewMessage_EditValueChanged(object sender, EventArgs e)
        {
            lciNewTextMessage.Text = string.Format("New Message[{0}]", 160 - meNewMessage.Text.Length);
        }
    }
}