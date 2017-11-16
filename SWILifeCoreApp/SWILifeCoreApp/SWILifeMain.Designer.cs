namespace SWILifeCoreApp
{
    partial class SWILifeMain
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
            System.Windows.Forms.TabPage tabPageUser;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SWILifeMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCandidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addJobOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxQuickSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCompany = new System.Windows.Forms.TabPage();
            this.tabPageCandidate = new System.Windows.Forms.TabPage();
            this.tabPageJobOrder = new System.Windows.Forms.TabPage();
            this.tabPageContact = new System.Windows.Forms.TabPage();
            this.tabPageActivity = new System.Windows.Forms.TabPage();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.imageListControl = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tabPageUser = new System.Windows.Forms.TabPage();
            tabPageUser.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageUser
            // 
            tabPageUser.BackColor = System.Drawing.Color.Transparent;
            tabPageUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tabPageUser.Controls.Add(this.tableLayoutPanel1);
            tabPageUser.ImageIndex = 6;
            tabPageUser.Location = new System.Drawing.Point(54, 4);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            tabPageUser.Size = new System.Drawing.Size(1292, 694);
            tabPageUser.TabIndex = 0;
            tabPageUser.ToolTipText = "Manages users";
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.Silver;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.functionsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripTextBoxQuickSearch});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1350, 27);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.forwardToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 23);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("signOutToolStripMenuItem.Image")));
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.signOutToolStripMenuItem.Text = "Logout";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.addCompanyToolStripMenuItem,
            this.addCandidateToolStripMenuItem,
            this.addJobOrderToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.functionsToolStripMenuItem.Text = "&Functions";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addContactToolStripMenuItem.Image")));
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            // 
            // addCompanyToolStripMenuItem
            // 
            this.addCompanyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addCompanyToolStripMenuItem.Image")));
            this.addCompanyToolStripMenuItem.Name = "addCompanyToolStripMenuItem";
            this.addCompanyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Y)));
            this.addCompanyToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.addCompanyToolStripMenuItem.Text = "Add Company";
            // 
            // addCandidateToolStripMenuItem
            // 
            this.addCandidateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addCandidateToolStripMenuItem.Image")));
            this.addCandidateToolStripMenuItem.Name = "addCandidateToolStripMenuItem";
            this.addCandidateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.addCandidateToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.addCandidateToolStripMenuItem.Text = "Add Candidate";
            // 
            // addJobOrderToolStripMenuItem
            // 
            this.addJobOrderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addJobOrderToolStripMenuItem.Image")));
            this.addJobOrderToolStripMenuItem.Name = "addJobOrderToolStripMenuItem";
            this.addJobOrderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.addJobOrderToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.addJobOrderToolStripMenuItem.Text = "Add Job Order";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // toolStripTextBoxQuickSearch
            // 
            this.toolStripTextBoxQuickSearch.Margin = new System.Windows.Forms.Padding(50, 0, 1, 0);
            this.toolStripTextBoxQuickSearch.Name = "toolStripTextBoxQuickSearch";
            this.toolStripTextBoxQuickSearch.Size = new System.Drawing.Size(400, 23);
            this.toolStripTextBoxQuickSearch.Text = "Quick search..";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlMain.AllowDrop = true;
            this.tabControlMain.Controls.Add(tabPageUser);
            this.tabControlMain.Controls.Add(this.tabPageCompany);
            this.tabControlMain.Controls.Add(this.tabPageCandidate);
            this.tabControlMain.Controls.Add(this.tabPageJobOrder);
            this.tabControlMain.Controls.Add(this.tabPageContact);
            this.tabControlMain.Controls.Add(this.tabPageActivity);
            this.tabControlMain.Controls.Add(this.tabPageReport);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.ImageList = this.imageListControl;
            this.tabControlMain.ItemSize = new System.Drawing.Size(50, 50);
            this.tabControlMain.Location = new System.Drawing.Point(0, 27);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1350, 702);
            this.tabControlMain.TabIndex = 1;
            this.tabControlMain.TabStop = false;
            // 
            // tabPageCompany
            // 
            this.tabPageCompany.ImageKey = "company2.png";
            this.tabPageCompany.Location = new System.Drawing.Point(54, 4);
            this.tabPageCompany.Name = "tabPageCompany";
            this.tabPageCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompany.Size = new System.Drawing.Size(1292, 694);
            this.tabPageCompany.TabIndex = 1;
            this.tabPageCompany.ToolTipText = "Company";
            this.tabPageCompany.UseVisualStyleBackColor = true;
            // 
            // tabPageCandidate
            // 
            this.tabPageCandidate.ImageIndex = 2;
            this.tabPageCandidate.Location = new System.Drawing.Point(54, 4);
            this.tabPageCandidate.Name = "tabPageCandidate";
            this.tabPageCandidate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCandidate.Size = new System.Drawing.Size(1292, 694);
            this.tabPageCandidate.TabIndex = 2;
            this.tabPageCandidate.ToolTipText = "Candidates";
            this.tabPageCandidate.UseVisualStyleBackColor = true;
            // 
            // tabPageJobOrder
            // 
            this.tabPageJobOrder.ImageIndex = 5;
            this.tabPageJobOrder.Location = new System.Drawing.Point(54, 4);
            this.tabPageJobOrder.Name = "tabPageJobOrder";
            this.tabPageJobOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJobOrder.Size = new System.Drawing.Size(1292, 694);
            this.tabPageJobOrder.TabIndex = 3;
            this.tabPageJobOrder.UseVisualStyleBackColor = true;
            // 
            // tabPageContact
            // 
            this.tabPageContact.ImageIndex = 13;
            this.tabPageContact.Location = new System.Drawing.Point(54, 4);
            this.tabPageContact.Name = "tabPageContact";
            this.tabPageContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContact.Size = new System.Drawing.Size(1292, 694);
            this.tabPageContact.TabIndex = 4;
            this.tabPageContact.UseVisualStyleBackColor = true;
            // 
            // tabPageActivity
            // 
            this.tabPageActivity.ImageIndex = 0;
            this.tabPageActivity.Location = new System.Drawing.Point(54, 4);
            this.tabPageActivity.Name = "tabPageActivity";
            this.tabPageActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActivity.Size = new System.Drawing.Size(1292, 694);
            this.tabPageActivity.TabIndex = 5;
            this.tabPageActivity.UseVisualStyleBackColor = true;
            // 
            // tabPageReport
            // 
            this.tabPageReport.ImageIndex = 11;
            this.tabPageReport.Location = new System.Drawing.Point(54, 4);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(1292, 694);
            this.tabPageReport.TabIndex = 6;
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // imageListControl
            // 
            this.imageListControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListControl.ImageStream")));
            this.imageListControl.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListControl.Images.SetKeyName(0, "activity.png");
            this.imageListControl.Images.SetKeyName(1, "Candidate_Search.png");
            this.imageListControl.Images.SetKeyName(2, "Candidates.png");
            this.imageListControl.Images.SetKeyName(3, "company.png");
            this.imageListControl.Images.SetKeyName(4, "company2.png");
            this.imageListControl.Images.SetKeyName(5, "job.png");
            this.imageListControl.Images.SetKeyName(6, "login.png");
            this.imageListControl.Images.SetKeyName(7, "login2.png");
            this.imageListControl.Images.SetKeyName(8, "logout.png");
            this.imageListControl.Images.SetKeyName(9, "lollipop.png");
            this.imageListControl.Images.SetKeyName(10, "report.jpg");
            this.imageListControl.Images.SetKeyName(11, "report2.jpg");
            this.imageListControl.Images.SetKeyName(12, "contact.png");
            this.imageListControl.Images.SetKeyName(13, "contact2.png");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1280, 64);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(341, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage user";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1286, 688);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripMenuItem.Image")));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.backToolStripMenuItem.Text = "&Back";
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("forwardToolStripMenuItem.Image")));
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.forwardToolStripMenuItem.Text = "Forwar&d";
            // 
            // SWILifeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "SWILifeMain";
            this.Text = "SWILife";
            tabPageUser.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCandidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addJobOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCompany;
        private System.Windows.Forms.ImageList imageListControl;
        private System.Windows.Forms.TabPage tabPageCandidate;
        private System.Windows.Forms.TabPage tabPageJobOrder;
        private System.Windows.Forms.TabPage tabPageContact;
        private System.Windows.Forms.TabPage tabPageActivity;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxQuickSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem;
    }
}

