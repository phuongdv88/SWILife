namespace DXSWI.Controls
{
    partial class ucContact
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pcCheckControls = new DevExpress.XtraEditors.PanelControl();
            this.ceList = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ceAlphabetical = new DevExpress.XtraEditors.CheckEdit();
            this.ceCards = new DevExpress.XtraEditors.CheckEdit();
            this.ceState = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCheckControls)).BeginInit();
            this.pcCheckControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAlphabetical.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCards.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceState.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(46, 156);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Uc contact";
            // 
            // pcCheckControls
            // 
            this.pcCheckControls.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcCheckControls.Controls.Add(this.ceList);
            this.pcCheckControls.Controls.Add(this.labelControl2);
            this.pcCheckControls.Controls.Add(this.ceAlphabetical);
            this.pcCheckControls.Controls.Add(this.ceCards);
            this.pcCheckControls.Controls.Add(this.ceState);
            this.pcCheckControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcCheckControls.Location = new System.Drawing.Point(0, 0);
            this.pcCheckControls.Name = "pcCheckControls";
            this.pcCheckControls.Size = new System.Drawing.Size(150, 135);
            this.pcCheckControls.TabIndex = 7;
            // 
            // ceList
            // 
            this.ceList.EditValue = true;
            this.ceList.Location = new System.Drawing.Point(18, 7);
            this.ceList.Name = "ceList";
            this.ceList.Properties.AutoWidth = true;
            this.ceList.Properties.Caption = "List";
            this.ceList.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceList.Properties.RadioGroupIndex = 0;
            this.ceList.Size = new System.Drawing.Size(38, 19);
            this.ceList.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 13);
            this.labelControl2.TabIndex = 4;
            // 
            // ceAlphabetical
            // 
            this.ceAlphabetical.Location = new System.Drawing.Point(18, 32);
            this.ceAlphabetical.Name = "ceAlphabetical";
            this.ceAlphabetical.Properties.AutoWidth = true;
            this.ceAlphabetical.Properties.Caption = "Alphabetical";
            this.ceAlphabetical.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceAlphabetical.Properties.RadioGroupIndex = 0;
            this.ceAlphabetical.Size = new System.Drawing.Size(80, 19);
            this.ceAlphabetical.TabIndex = 1;
            this.ceAlphabetical.TabStop = false;
            // 
            // ceCards
            // 
            this.ceCards.Location = new System.Drawing.Point(18, 100);
            this.ceCards.Name = "ceCards";
            this.ceCards.Properties.AutoWidth = true;
            this.ceCards.Properties.Caption = "Card";
            this.ceCards.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceCards.Properties.RadioGroupIndex = 0;
            this.ceCards.Size = new System.Drawing.Size(45, 19);
            this.ceCards.TabIndex = 3;
            this.ceCards.TabStop = false;
            // 
            // ceState
            // 
            this.ceState.Location = new System.Drawing.Point(18, 57);
            this.ceState.Name = "ceState";
            this.ceState.Properties.AutoWidth = true;
            this.ceState.Properties.Caption = "By State";
            this.ceState.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceState.Properties.RadioGroupIndex = 0;
            this.ceState.Size = new System.Drawing.Size(63, 19);
            this.ceState.TabIndex = 2;
            this.ceState.TabStop = false;
            // 
            // ucContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcCheckControls);
            this.Controls.Add(this.labelControl1);
            this.Name = "ucContact";
            this.Size = new System.Drawing.Size(150, 324);
            ((System.ComponentModel.ISupportInitialize)(this.pcCheckControls)).EndInit();
            this.pcCheckControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAlphabetical.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCards.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceState.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pcCheckControls;
        private DevExpress.XtraEditors.CheckEdit ceList;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit ceAlphabetical;
        private DevExpress.XtraEditors.CheckEdit ceCards;
        private DevExpress.XtraEditors.CheckEdit ceState;
    }
}
