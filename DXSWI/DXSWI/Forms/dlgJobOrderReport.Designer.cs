namespace DXSWI.Forms
{
    partial class dlgJobOrderReport
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            this.ccMain = new DevExpress.XtraCharts.ChartControl();
            this.reportJobOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ccMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportJobOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ccMain
            // 
            this.ccMain.DataBindings = null;
            this.ccMain.DataSource = this.reportJobOrderBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.ccMain.Diagram = xyDiagram1;
            this.ccMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ccMain.Legend.Name = "Default Legend";
            this.ccMain.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.ccMain.Location = new System.Drawing.Point(0, 0);
            this.ccMain.Name = "ccMain";
            series1.ArgumentDataMember = "StepName";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Candidate";
            series1.ShowInLegend = false;
            series1.ValueDataMembersSerializable = "Value";
            sideBySideBarSeriesView1.ColorEach = true;
            series1.View = sideBySideBarSeriesView1;
            this.ccMain.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.ccMain.Size = new System.Drawing.Size(670, 441);
            this.ccMain.TabIndex = 0;
            // 
            // reportJobOrderBindingSource
            // 
            this.reportJobOrderBindingSource.DataSource = typeof(SWIBLL.Models.ReportJobOrder);
            // 
            // dlgJobOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 441);
            this.Controls.Add(this.ccMain);
            this.KeyPreview = true;
            this.Name = "dlgJobOrderReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dlgJobOrderReport";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportJobOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl ccMain;
        private System.Windows.Forms.BindingSource reportJobOrderBindingSource;
    }
}