namespace DXSWI.Controls
{
    partial class ucChangePageBar
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbePageSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.sbFirst = new DevExpress.XtraEditors.SimpleButton();
            this.sbPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lcCurrentPage = new DevExpress.XtraEditors.LabelControl();
            this.sbNext = new DevExpress.XtraEditors.SimpleButton();
            this.sbLas = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbePageSize.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelControl1);
            this.flowLayoutPanel1.Controls.Add(this.cbePageSize);
            this.flowLayoutPanel1.Controls.Add(this.sbFirst);
            this.flowLayoutPanel1.Controls.Add(this.sbPrevious);
            this.flowLayoutPanel1.Controls.Add(this.labelControl2);
            this.flowLayoutPanel1.Controls.Add(this.lcCurrentPage);
            this.flowLayoutPanel1.Controls.Add(this.sbNext);
            this.flowLayoutPanel1.Controls.Add(this.sbLas);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(551, 32);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(3, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Page size";
            // 
            // cbePageSize
            // 
            this.cbePageSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbePageSize.Location = new System.Drawing.Point(54, 4);
            this.cbePageSize.Name = "cbePageSize";
            this.cbePageSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbePageSize.Properties.Items.AddRange(new object[] {
            "15",
            "50",
            "75",
            "100"});
            this.cbePageSize.Size = new System.Drawing.Size(100, 20);
            this.cbePageSize.TabIndex = 1;
            // 
            // sbFirst
            // 
            this.sbFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbFirst.Location = new System.Drawing.Point(160, 3);
            this.sbFirst.Name = "sbFirst";
            this.sbFirst.Size = new System.Drawing.Size(75, 23);
            this.sbFirst.TabIndex = 2;
            this.sbFirst.Text = "First";
            // 
            // sbPrevious
            // 
            this.sbPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbPrevious.Location = new System.Drawing.Point(241, 3);
            this.sbPrevious.Name = "sbPrevious";
            this.sbPrevious.Size = new System.Drawing.Size(75, 23);
            this.sbPrevious.TabIndex = 2;
            this.sbPrevious.Text = "Previous";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(322, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Page";
            // 
            // lcCurrentPage
            // 
            this.lcCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lcCurrentPage.Location = new System.Drawing.Point(352, 8);
            this.lcCurrentPage.Name = "lcCurrentPage";
            this.lcCurrentPage.Size = new System.Drawing.Size(28, 13);
            this.lcCurrentPage.TabIndex = 4;
            this.lcCurrentPage.Text = "1/200";
            // 
            // sbNext
            // 
            this.sbNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbNext.Location = new System.Drawing.Point(386, 3);
            this.sbNext.Name = "sbNext";
            this.sbNext.Size = new System.Drawing.Size(75, 23);
            this.sbNext.TabIndex = 2;
            this.sbNext.Text = "Next";
            // 
            // sbLas
            // 
            this.sbLas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbLas.Location = new System.Drawing.Point(467, 3);
            this.sbLas.Name = "sbLas";
            this.sbLas.Size = new System.Drawing.Size(75, 23);
            this.sbLas.TabIndex = 2;
            this.sbLas.Text = "Last";
            // 
            // ucChangePageBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ucChangePageBar";
            this.Size = new System.Drawing.Size(551, 32);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbePageSize.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbePageSize;
        private DevExpress.XtraEditors.SimpleButton sbFirst;
        private DevExpress.XtraEditors.SimpleButton sbPrevious;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lcCurrentPage;
        private DevExpress.XtraEditors.SimpleButton sbNext;
        private DevExpress.XtraEditors.SimpleButton sbLas;
    }
}
