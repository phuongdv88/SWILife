namespace DXSWI.Forms
{
    partial class dlgLogActivity
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ucScheduleEvent2 = new DXSWI.Controls.ucScheduleEvent();
            this.cbeRegarding = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ceChangeStatus = new DevExpress.XtraEditors.CheckEdit();
            this.cbeStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ceLogActivity = new DevExpress.XtraEditors.CheckEdit();
            this.cbeActivityType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.meActivityNote = new DevExpress.XtraEditors.MemoEdit();
            this.sbAdd = new DevExpress.XtraEditors.SimpleButton();
            this.ceScheduleEvent = new DevExpress.XtraEditors.CheckEdit();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciRegarding = new DevExpress.XtraLayout.LayoutControlItem();
            this.Status = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeRegarding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceChangeStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceLogActivity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeActivityType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meActivityNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceScheduleEvent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRegarding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ucScheduleEvent2);
            this.layoutControl1.Controls.Add(this.cbeRegarding);
            this.layoutControl1.Controls.Add(this.ceChangeStatus);
            this.layoutControl1.Controls.Add(this.cbeStatus);
            this.layoutControl1.Controls.Add(this.ceLogActivity);
            this.layoutControl1.Controls.Add(this.cbeActivityType);
            this.layoutControl1.Controls.Add(this.meActivityNote);
            this.layoutControl1.Controls.Add(this.sbAdd);
            this.layoutControl1.Controls.Add(this.ceScheduleEvent);
            this.layoutControl1.Controls.Add(this.sbCancel);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(904, 649);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ucScheduleEvent2
            // 
            this.ucScheduleEvent2.Enabled = false;
            this.ucScheduleEvent2.Location = new System.Drawing.Point(24, 370);
            this.ucScheduleEvent2.Name = "ucScheduleEvent2";
            this.ucScheduleEvent2.Size = new System.Drawing.Size(856, 229);
            this.ucScheduleEvent2.TabIndex = 14;
            // 
            // cbeRegarding
            // 
            this.cbeRegarding.EditValue = "General";
            this.cbeRegarding.Location = new System.Drawing.Point(78, 12);
            this.cbeRegarding.Name = "cbeRegarding";
            this.cbeRegarding.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeRegarding.Properties.Items.AddRange(new object[] {
            "General"});
            this.cbeRegarding.Size = new System.Drawing.Size(814, 20);
            this.cbeRegarding.StyleController = this.layoutControl1;
            this.cbeRegarding.TabIndex = 4;
            this.cbeRegarding.SelectedIndexChanged += new System.EventHandler(this.cbeRegarding_SelectedIndexChanged);
            // 
            // ceChangeStatus
            // 
            this.ceChangeStatus.Enabled = false;
            this.ceChangeStatus.Location = new System.Drawing.Point(24, 66);
            this.ceChangeStatus.Name = "ceChangeStatus";
            this.ceChangeStatus.Properties.Caption = "Change Status";
            this.ceChangeStatus.Size = new System.Drawing.Size(145, 19);
            this.ceChangeStatus.StyleController = this.layoutControl1;
            this.ceChangeStatus.TabIndex = 5;
            this.ceChangeStatus.CheckedChanged += new System.EventHandler(this.ceChangeStatus_CheckedChanged);
            // 
            // cbeStatus
            // 
            this.cbeStatus.Enabled = false;
            this.cbeStatus.Location = new System.Drawing.Point(173, 66);
            this.cbeStatus.Name = "cbeStatus";
            this.cbeStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeStatus.Properties.Items.AddRange(new object[] {
            "No Contact",
            "Contacted",
            "Candidate Responded",
            "Qualifying",
            "Submitted",
            "Interviewing",
            "Offered",
            "Not In Consideration",
            "Client Declined",
            "Placed",
            "Other"});
            this.cbeStatus.Size = new System.Drawing.Size(707, 20);
            this.cbeStatus.StyleController = this.layoutControl1;
            this.cbeStatus.TabIndex = 6;
            // 
            // ceLogActivity
            // 
            this.ceLogActivity.Location = new System.Drawing.Point(24, 132);
            this.ceLogActivity.Name = "ceLogActivity";
            this.ceLogActivity.Properties.Caption = "Log an Activity";
            this.ceLogActivity.Size = new System.Drawing.Size(856, 19);
            this.ceLogActivity.StyleController = this.layoutControl1;
            this.ceLogActivity.TabIndex = 7;
            this.ceLogActivity.CheckedChanged += new System.EventHandler(this.ceLogActivity_CheckedChanged);
            // 
            // cbeActivityType
            // 
            this.cbeActivityType.Enabled = false;
            this.cbeActivityType.Location = new System.Drawing.Point(90, 155);
            this.cbeActivityType.Name = "cbeActivityType";
            this.cbeActivityType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeActivityType.Properties.Items.AddRange(new object[] {
            "Call",
            "Talked",
            "Message",
            "Cv Submitted",
            "Email",
            "Meeting",
            "Other"});
            this.cbeActivityType.Size = new System.Drawing.Size(790, 20);
            this.cbeActivityType.StyleController = this.layoutControl1;
            this.cbeActivityType.TabIndex = 9;
            // 
            // meActivityNote
            // 
            this.meActivityNote.Location = new System.Drawing.Point(24, 195);
            this.meActivityNote.Name = "meActivityNote";
            this.meActivityNote.Size = new System.Drawing.Size(856, 106);
            this.meActivityNote.StyleController = this.layoutControl1;
            this.meActivityNote.TabIndex = 10;
            // 
            // sbAdd
            // 
            this.sbAdd.Location = new System.Drawing.Point(568, 615);
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Size = new System.Drawing.Size(157, 22);
            this.sbAdd.StyleController = this.layoutControl1;
            this.sbAdd.TabIndex = 12;
            this.sbAdd.Text = "Add";
            this.sbAdd.Click += new System.EventHandler(this.sbAdd_Click);
            // 
            // ceScheduleEvent
            // 
            this.ceScheduleEvent.Location = new System.Drawing.Point(24, 347);
            this.ceScheduleEvent.Name = "ceScheduleEvent";
            this.ceScheduleEvent.Properties.Caption = "Schedule Event";
            this.ceScheduleEvent.Size = new System.Drawing.Size(856, 19);
            this.ceScheduleEvent.StyleController = this.layoutControl1;
            this.ceScheduleEvent.TabIndex = 8;
            this.ceScheduleEvent.CheckedChanged += new System.EventHandler(this.ceScheduleEvent_CheckedChanged);
            // 
            // sbCancel
            // 
            this.sbCancel.Location = new System.Drawing.Point(729, 615);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(163, 22);
            this.sbCancel.StyleController = this.layoutControl1;
            this.sbCancel.TabIndex = 13;
            this.sbCancel.Text = "Exit";
            this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciRegarding,
            this.Status,
            this.layoutControlGroup2,
            this.layoutControlItem8,
            this.layoutControlGroup3,
            this.layoutControlItem9,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(904, 649);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciRegarding
            // 
            this.lciRegarding.Control = this.cbeRegarding;
            this.lciRegarding.Location = new System.Drawing.Point(0, 0);
            this.lciRegarding.Name = "lciRegarding";
            this.lciRegarding.Size = new System.Drawing.Size(884, 24);
            this.lciRegarding.Text = "Regarding";
            this.lciRegarding.TextSize = new System.Drawing.Size(63, 13);
            // 
            // Status
            // 
            this.Status.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Status.Location = new System.Drawing.Point(0, 24);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(884, 66);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ceChangeStatus;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(149, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbeStatus;
            this.layoutControlItem2.Location = new System.Drawing.Point(149, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(711, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 90);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(884, 215);
            this.layoutControlGroup2.Text = "Activity";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceLogActivity;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(860, 23);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbeActivityType;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(860, 24);
            this.layoutControlItem5.Text = "Activity Type";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.meActivityNote;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 47);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(860, 126);
            this.layoutControlItem6.Text = "Activity Note";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.sbAdd;
            this.layoutControlItem8.Location = new System.Drawing.Point(556, 603);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(161, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem10});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 305);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(884, 298);
            this.layoutControlGroup3.Text = "Schedule Event";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceScheduleEvent;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(860, 23);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.ucScheduleEvent2;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(860, 233);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.sbCancel;
            this.layoutControlItem9.Location = new System.Drawing.Point(717, 603);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(167, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 603);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(556, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dlgLogActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 649);
            this.Controls.Add(this.layoutControl1);
            this.KeyPreview = true;
            this.Name = "dlgLogActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Activity";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dlgLogActivity_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeRegarding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceChangeStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceLogActivity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeActivityType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meActivityNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceScheduleEvent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRegarding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbeRegarding;
        private DevExpress.XtraEditors.CheckEdit ceChangeStatus;
        private DevExpress.XtraEditors.ComboBoxEdit cbeStatus;
        private DevExpress.XtraEditors.CheckEdit ceLogActivity;
        private DevExpress.XtraEditors.CheckEdit ceScheduleEvent;
        private DevExpress.XtraEditors.ComboBoxEdit cbeActivityType;
        private DevExpress.XtraEditors.MemoEdit meActivityNote;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciRegarding;
        private DevExpress.XtraLayout.LayoutControlGroup Status;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton sbAdd;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private Controls.ucScheduleEvent ucScheduleEvent2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
    }
}