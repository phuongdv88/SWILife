namespace DXSWI.Forms
{
    partial class dlgSmsController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gcSendingMessages = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resendThisMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvSendingMessages = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSentMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSentStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeToSend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcReceivingMessages = new DevExpress.XtraGrid.GridControl();
            this.gvReceivingMessages = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCanName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSentTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teFrom = new DevExpress.XtraEditors.TextEdit();
            this.meMessage = new DevExpress.XtraEditors.MemoEdit();
            this.sbSend = new DevExpress.XtraEditors.SimpleButton();
            this.meNewMessage = new DevExpress.XtraEditors.MemoEdit();
            this.teToPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNewTextMessage = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSendingMessages)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSendingMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReceivingMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReceivingMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNewMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teToPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewTextMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gcSendingMessages);
            this.dataLayoutControl1.Controls.Add(this.gcReceivingMessages);
            this.dataLayoutControl1.Controls.Add(this.teFrom);
            this.dataLayoutControl1.Controls.Add(this.meMessage);
            this.dataLayoutControl1.Controls.Add(this.sbSend);
            this.dataLayoutControl1.Controls.Add(this.meNewMessage);
            this.dataLayoutControl1.Controls.Add(this.teToPhoneNumber);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1110, 613);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gcSendingMessages
            // 
            this.gcSendingMessages.ContextMenuStrip = this.contextMenuStrip1;
            this.gcSendingMessages.Location = new System.Drawing.Point(583, 42);
            this.gcSendingMessages.MainView = this.gvSendingMessages;
            this.gcSendingMessages.Name = "gcSendingMessages";
            this.gcSendingMessages.Size = new System.Drawing.Size(503, 269);
            this.gcSendingMessages.TabIndex = 9;
            this.gcSendingMessages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSendingMessages});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resendThisMessageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 26);
            // 
            // resendThisMessageToolStripMenuItem
            // 
            this.resendThisMessageToolStripMenuItem.Name = "resendThisMessageToolStripMenuItem";
            this.resendThisMessageToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.resendThisMessageToolStripMenuItem.Text = "Resend This Message";
            this.resendThisMessageToolStripMenuItem.Click += new System.EventHandler(this.resendThisMessageToolStripMenuItem_Click);
            // 
            // gvSendingMessages
            // 
            this.gvSendingMessages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPhoneNumber,
            this.colSentMessage,
            this.colSentStatus,
            this.colTimeToSend,
            this.colName});
            this.gvSendingMessages.GridControl = this.gcSendingMessages;
            this.gvSendingMessages.Name = "gvSendingMessages";
            this.gvSendingMessages.OptionsBehavior.Editable = false;
            this.gvSendingMessages.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvSendingMessages_RowClick);
            this.gvSendingMessages.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvSendingMessages_CustomDrawCell);
            this.gvSendingMessages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvSendingMessages_KeyDown);
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "Phone Number";
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 1;
            this.colPhoneNumber.Width = 74;
            // 
            // colSentMessage
            // 
            this.colSentMessage.Caption = "Message";
            this.colSentMessage.FieldName = "Message";
            this.colSentMessage.Name = "colSentMessage";
            this.colSentMessage.Visible = true;
            this.colSentMessage.VisibleIndex = 2;
            this.colSentMessage.Width = 131;
            // 
            // colSentStatus
            // 
            this.colSentStatus.Caption = "Status";
            this.colSentStatus.FieldName = "Status";
            this.colSentStatus.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText;
            this.colSentStatus.Name = "colSentStatus";
            this.colSentStatus.Visible = true;
            this.colSentStatus.VisibleIndex = 4;
            this.colSentStatus.Width = 44;
            // 
            // colTimeToSend
            // 
            this.colTimeToSend.Caption = "Sent Time";
            this.colTimeToSend.FieldName = "TimeToSend";
            this.colTimeToSend.Name = "colTimeToSend";
            this.colTimeToSend.Visible = true;
            this.colTimeToSend.VisibleIndex = 3;
            this.colTimeToSend.Width = 110;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "CandidateName";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // gcReceivingMessages
            // 
            this.gcReceivingMessages.Location = new System.Drawing.Point(24, 42);
            this.gcReceivingMessages.MainView = this.gvReceivingMessages;
            this.gcReceivingMessages.Name = "gcReceivingMessages";
            this.gcReceivingMessages.Size = new System.Drawing.Size(531, 266);
            this.gcReceivingMessages.TabIndex = 4;
            this.gcReceivingMessages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReceivingMessages});
            // 
            // gvReceivingMessages
            // 
            this.gvReceivingMessages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCanName,
            this.colSender,
            this.colSentTime,
            this.colMessage});
            this.gvReceivingMessages.GridControl = this.gcReceivingMessages;
            this.gvReceivingMessages.Name = "gvReceivingMessages";
            this.gvReceivingMessages.OptionsBehavior.Editable = false;
            this.gvReceivingMessages.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvReceivingMessages_RowClick);
            this.gvReceivingMessages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvReceivingMessages_KeyDown);
            // 
            // colCanName
            // 
            this.colCanName.Caption = "Name";
            this.colCanName.FieldName = "CandidateName";
            this.colCanName.Name = "colCanName";
            this.colCanName.Visible = true;
            this.colCanName.VisibleIndex = 0;
            // 
            // colSender
            // 
            this.colSender.Caption = "Sender";
            this.colSender.FieldName = "Sender";
            this.colSender.Name = "colSender";
            this.colSender.Visible = true;
            this.colSender.VisibleIndex = 1;
            this.colSender.Width = 100;
            // 
            // colSentTime
            // 
            this.colSentTime.Caption = "Sent";
            this.colSentTime.FieldName = "SentTime";
            this.colSentTime.Name = "colSentTime";
            this.colSentTime.Visible = true;
            this.colSentTime.VisibleIndex = 2;
            this.colSentTime.Width = 129;
            // 
            // colMessage
            // 
            this.colMessage.Caption = "Message";
            this.colMessage.FieldName = "Message";
            this.colMessage.Name = "colMessage";
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 3;
            this.colMessage.Width = 193;
            // 
            // teFrom
            // 
            this.teFrom.Location = new System.Drawing.Point(119, 312);
            this.teFrom.Name = "teFrom";
            this.teFrom.Properties.ReadOnly = true;
            this.teFrom.Size = new System.Drawing.Size(436, 20);
            this.teFrom.StyleController = this.dataLayoutControl1;
            this.teFrom.TabIndex = 5;
            // 
            // meMessage
            // 
            this.meMessage.Location = new System.Drawing.Point(24, 352);
            this.meMessage.Name = "meMessage";
            this.meMessage.Properties.ReadOnly = true;
            this.meMessage.Size = new System.Drawing.Size(531, 237);
            this.meMessage.StyleController = this.dataLayoutControl1;
            this.meMessage.TabIndex = 6;
            // 
            // sbSend
            // 
            this.sbSend.Location = new System.Drawing.Point(583, 567);
            this.sbSend.Name = "sbSend";
            this.sbSend.Size = new System.Drawing.Size(503, 22);
            this.sbSend.StyleController = this.dataLayoutControl1;
            this.sbSend.TabIndex = 7;
            this.sbSend.Text = "Reply";
            this.sbSend.Click += new System.EventHandler(this.sbSend_Click);
            // 
            // meNewMessage
            // 
            this.meNewMessage.Location = new System.Drawing.Point(583, 355);
            this.meNewMessage.Name = "meNewMessage";
            this.meNewMessage.Properties.MaxLength = 160;
            this.meNewMessage.Size = new System.Drawing.Size(503, 208);
            this.meNewMessage.StyleController = this.dataLayoutControl1;
            this.meNewMessage.TabIndex = 8;
            this.meNewMessage.EditValueChanged += new System.EventHandler(this.meNewMessage_EditValueChanged);
            // 
            // teToPhoneNumber
            // 
            this.teToPhoneNumber.Location = new System.Drawing.Point(678, 315);
            this.teToPhoneNumber.Name = "teToPhoneNumber";
            this.teToPhoneNumber.Size = new System.Drawing.Size(408, 20);
            this.teToPhoneNumber.StyleController = this.dataLayoutControl1;
            this.teToPhoneNumber.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1110, 613);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(559, 593);
            this.layoutControlGroup2.Text = "Receiving Messages";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcReceivingMessages;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(535, 270);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.meMessage;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 294);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(535, 257);
            this.layoutControlItem3.Text = "Message";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.teFrom;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 270);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(535, 24);
            this.layoutControlItem2.Text = "Phone Number:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.lciNewTextMessage,
            this.layoutControlItem4,
            this.layoutControlItem7});
            this.layoutControlGroup3.Location = new System.Drawing.Point(559, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(531, 593);
            this.layoutControlGroup3.Text = "Sending Message";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gcSendingMessages;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(507, 273);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // lciNewTextMessage
            // 
            this.lciNewTextMessage.Control = this.meNewMessage;
            this.lciNewTextMessage.Location = new System.Drawing.Point(0, 297);
            this.lciNewTextMessage.Name = "lciNewTextMessage";
            this.lciNewTextMessage.Size = new System.Drawing.Size(507, 228);
            this.lciNewTextMessage.Text = "New Message[160]";
            this.lciNewTextMessage.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciNewTextMessage.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sbSend;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 525);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(507, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.teToPhoneNumber;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 273);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(507, 24);
            this.layoutControlItem7.Text = "To:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(92, 13);
            // 
            // dlgSmsController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 613);
            this.Controls.Add(this.dataLayoutControl1);
            this.KeyPreview = true;
            this.Name = "dlgSmsController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sms Controller";
            this.Load += new System.EventHandler(this.dlgSmsController_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dlgSmsController_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSendingMessages)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSendingMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReceivingMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReceivingMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNewMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teToPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewTextMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gcReceivingMessages;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReceivingMessages;
        private DevExpress.XtraEditors.TextEdit teFrom;
        private DevExpress.XtraEditors.MemoEdit meMessage;
        private DevExpress.XtraEditors.SimpleButton sbSend;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl gcSendingMessages;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSendingMessages;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSentMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colSentStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeToSend;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSender;
        private DevExpress.XtraGrid.Columns.GridColumn colSentTime;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraEditors.MemoEdit meNewMessage;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lciNewTextMessage;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit teToPhoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn colCanName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resendThisMessageToolStripMenuItem;
    }
}