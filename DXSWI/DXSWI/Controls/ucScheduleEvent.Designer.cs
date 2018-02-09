namespace DXSWI.Controls
{
    partial class ucScheduleEvent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbeType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.teTitle = new DevExpress.XtraEditors.TextEdit();
            this.teLenght = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ceAllDay = new DevExpress.XtraEditors.CheckEdit();
            this.cePublicEntry = new DevExpress.XtraEditors.CheckEdit();
            this.meDescription = new DevExpress.XtraEditors.MemoEdit();
            this.deDate = new DevExpress.XtraEditors.DateEdit();
            this.deTime = new DevExpress.XtraEditors.TimeSpanEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLenght.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePublicEntry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbeType);
            this.layoutControl1.Controls.Add(this.teTitle);
            this.layoutControl1.Controls.Add(this.teLenght);
            this.layoutControl1.Controls.Add(this.ceAllDay);
            this.layoutControl1.Controls.Add(this.cePublicEntry);
            this.layoutControl1.Controls.Add(this.meDescription);
            this.layoutControl1.Controls.Add(this.deDate);
            this.layoutControl1.Controls.Add(this.deTime);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(426, 354);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbeType
            // 
            this.cbeType.EditValue = "Call";
            this.cbeType.Location = new System.Drawing.Point(68, 12);
            this.cbeType.Name = "cbeType";
            this.cbeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeType.Properties.Items.AddRange(new object[] {
            "Call",
            "Email",
            "Meeting",
            "Interview",
            "Personal",
            "Other"});
            this.cbeType.Size = new System.Drawing.Size(158, 20);
            this.cbeType.StyleController = this.layoutControl1;
            this.cbeType.TabIndex = 4;
            // 
            // teTitle
            // 
            this.teTitle.Location = new System.Drawing.Point(68, 36);
            this.teTitle.Name = "teTitle";
            this.teTitle.Size = new System.Drawing.Size(346, 20);
            this.teTitle.StyleController = this.layoutControl1;
            this.teTitle.TabIndex = 5;
            // 
            // teLenght
            // 
            this.teLenght.EditValue = "1 hour";
            this.teLenght.Location = new System.Drawing.Point(286, 84);
            this.teLenght.Name = "teLenght";
            this.teLenght.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teLenght.Properties.Items.AddRange(new object[] {
            "15 minutes",
            "30 minutes",
            "1 hour",
            "1,5 hours",
            "2 hours",
            "4 hours",
            "more than 4 hours"});
            this.teLenght.Size = new System.Drawing.Size(128, 20);
            this.teLenght.StyleController = this.layoutControl1;
            this.teLenght.TabIndex = 7;
            // 
            // ceAllDay
            // 
            this.ceAllDay.Location = new System.Drawing.Point(230, 60);
            this.ceAllDay.Name = "ceAllDay";
            this.ceAllDay.Properties.Caption = "All day/ No Specific Time";
            this.ceAllDay.Size = new System.Drawing.Size(184, 19);
            this.ceAllDay.StyleController = this.layoutControl1;
            this.ceAllDay.TabIndex = 8;
            this.ceAllDay.CheckedChanged += new System.EventHandler(this.ceAllDay_CheckedChanged);
            // 
            // cePublicEntry
            // 
            this.cePublicEntry.Location = new System.Drawing.Point(230, 12);
            this.cePublicEntry.Name = "cePublicEntry";
            this.cePublicEntry.Properties.Caption = "Public Entry";
            this.cePublicEntry.Size = new System.Drawing.Size(184, 19);
            this.cePublicEntry.StyleController = this.layoutControl1;
            this.cePublicEntry.TabIndex = 9;
            this.cePublicEntry.CheckedChanged += new System.EventHandler(this.cePublicEntry_CheckedChanged);
            // 
            // meDescription
            // 
            this.meDescription.Location = new System.Drawing.Point(12, 124);
            this.meDescription.Name = "meDescription";
            this.meDescription.Size = new System.Drawing.Size(402, 218);
            this.meDescription.StyleController = this.layoutControl1;
            this.meDescription.TabIndex = 10;
            // 
            // deDate
            // 
            this.deDate.EditValue = null;
            this.deDate.Location = new System.Drawing.Point(68, 60);
            this.deDate.Name = "deDate";
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Size = new System.Drawing.Size(158, 20);
            this.deDate.StyleController = this.layoutControl1;
            this.deDate.TabIndex = 11;
            // 
            // deTime
            // 
            this.deTime.EditValue = null;
            this.deTime.Location = new System.Drawing.Point(68, 84);
            this.deTime.Name = "deTime";
            this.deTime.Properties.AllowEditDays = false;
            this.deTime.Properties.AllowEditSeconds = false;
            this.deTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTime.Properties.DisplayFormat.FormatString = "d";
            this.deTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTime.Properties.EditFormat.FormatString = "d";
            this.deTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deTime.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.deTime.Properties.Mask.EditMask = "HH:mm";
            this.deTime.Properties.MaxDays = 0;
            this.deTime.Size = new System.Drawing.Size(158, 20);
            this.deTime.StyleController = this.layoutControl1;
            this.deTime.TabIndex = 12;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.layoutControlItem8,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(426, 354);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbeType;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(218, 24);
            this.layoutControlItem1.Text = "Type";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.meDescription;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(406, 238);
            this.layoutControlItem7.Text = "Description";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.teTitle;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(406, 24);
            this.layoutControlItem2.Text = "Title";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.deDate;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(218, 24);
            this.layoutControlItem8.Text = "Date";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cePublicEntry;
            this.layoutControlItem6.Location = new System.Drawing.Point(218, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(188, 24);
            this.layoutControlItem6.Text = "Public Entry";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.deTime;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(218, 24);
            this.layoutControlItem3.Text = "Time";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(53, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ceAllDay;
            this.layoutControlItem5.Location = new System.Drawing.Point(218, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(188, 24);
            this.layoutControlItem5.Text = "All day/ No Specific Time";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.teLenght;
            this.layoutControlItem4.Location = new System.Drawing.Point(218, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(188, 24);
            this.layoutControlItem4.Text = "Length";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(53, 13);
            // 
            // ucScheduleEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucScheduleEvent";
            this.Size = new System.Drawing.Size(426, 354);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLenght.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cePublicEntry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.ComboBoxEdit cbeType;
        private DevExpress.XtraEditors.TextEdit teTitle;
        private DevExpress.XtraEditors.ComboBoxEdit teLenght;
        private DevExpress.XtraEditors.CheckEdit ceAllDay;
        private DevExpress.XtraEditors.CheckEdit cePublicEntry;
        private DevExpress.XtraEditors.MemoEdit meDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.DateEdit deDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.TimeSpanEdit deTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
