namespace DrKhaled.Xmrizer
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFilePath = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowseFile = new MetroFramework.Controls.MetroButton();
            this.lblFile = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRules = new MetroFramework.Controls.MetroLabel();
            this.btnLoadTree = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblRuleName = new MetroFramework.Controls.MetroLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblRuleConditions = new System.Windows.Forms.Label();
            this.lblConditionsHeader = new System.Windows.Forms.Label();
            this.lblRuleOC = new System.Windows.Forms.Label();
            this.lblRuleFC = new System.Windows.Forms.Label();
            this.lblRuleCategory = new MetroFramework.Controls.MetroLabel();
            this.checkBoxFC = new MetroFramework.Controls.MetroCheckBox();
            this.checkBoxOC = new MetroFramework.Controls.MetroCheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(20, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 321);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(320, 313);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtFilePath);
            this.panel2.Controls.Add(this.btnBrowseFile);
            this.panel2.Controls.Add(this.lblFile);
            this.panel2.Location = new System.Drawing.Point(20, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 64);
            this.panel2.TabIndex = 1;
            // 
            // txtFilePath
            // 
            // 
            // 
            // 
            this.txtFilePath.CustomButton.Image = null;
            this.txtFilePath.CustomButton.Location = new System.Drawing.Point(426, 2);
            this.txtFilePath.CustomButton.Name = "";
            this.txtFilePath.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilePath.CustomButton.TabIndex = 1;
            this.txtFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilePath.CustomButton.UseSelectable = true;
            this.txtFilePath.CustomButton.Visible = false;
            this.txtFilePath.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFilePath.Lines = new string[0];
            this.txtFilePath.Location = new System.Drawing.Point(6, 27);
            this.txtFilePath.MaxLength = 32767;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.SelectionLength = 0;
            this.txtFilePath.SelectionStart = 0;
            this.txtFilePath.ShortcutsEnabled = true;
            this.txtFilePath.Size = new System.Drawing.Size(452, 28);
            this.txtFilePath.TabIndex = 2;
            this.txtFilePath.UseSelectable = true;
            this.txtFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(463, 27);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(177, 28);
            this.btnBrowseFile.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnBrowseFile.TabIndex = 1;
            this.btnBrowseFile.Text = "Browse...";
            this.btnBrowseFile.UseSelectable = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // lblFile
            // 
            this.lblFile.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFile.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFile.ForeColor = System.Drawing.Color.White;
            this.lblFile.Location = new System.Drawing.Point(0, 0);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(644, 23);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "File";
            this.lblFile.UseCustomBackColor = true;
            this.lblFile.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel3.Location = new System.Drawing.Point(12, 543);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(654, 2);
            this.metroLabel3.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblStatus.Location = new System.Drawing.Point(20, 585);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 19);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status.";
            this.lblStatus.UseCustomForeColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblRules);
            this.panel3.Location = new System.Drawing.Point(20, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 30);
            this.panel3.TabIndex = 5;
            // 
            // lblRules
            // 
            this.lblRules.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRules.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRules.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRules.ForeColor = System.Drawing.Color.White;
            this.lblRules.Location = new System.Drawing.Point(0, 0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(326, 30);
            this.lblRules.TabIndex = 1;
            this.lblRules.Text = "Rules";
            this.lblRules.UseCustomBackColor = true;
            this.lblRules.UseCustomForeColor = true;
            // 
            // btnLoadTree
            // 
            this.btnLoadTree.Location = new System.Drawing.Point(20, 502);
            this.btnLoadTree.Name = "btnLoadTree";
            this.btnLoadTree.Size = new System.Drawing.Size(328, 35);
            this.btnLoadTree.TabIndex = 6;
            this.btnLoadTree.Text = "Load Tree";
            this.btnLoadTree.UseSelectable = true;
            this.btnLoadTree.Click += new System.EventHandler(this.btnLoadTree_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel1.Location = new System.Drawing.Point(13, 580);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(654, 2);
            this.metroLabel1.TabIndex = 7;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(13, 547);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(653, 30);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Search...";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblRuleName);
            this.panel4.Location = new System.Drawing.Point(355, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(312, 30);
            this.panel4.TabIndex = 10;
            // 
            // lblRuleName
            // 
            this.lblRuleName.BackColor = System.Drawing.Color.Teal;
            this.lblRuleName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRuleName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRuleName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRuleName.ForeColor = System.Drawing.Color.White;
            this.lblRuleName.Location = new System.Drawing.Point(0, 0);
            this.lblRuleName.Name = "lblRuleName";
            this.lblRuleName.Size = new System.Drawing.Size(310, 30);
            this.lblRuleName.TabIndex = 1;
            this.lblRuleName.Text = "ruleName";
            this.lblRuleName.UseCustomBackColor = true;
            this.lblRuleName.UseCustomForeColor = true;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblRuleConditions);
            this.panel5.Controls.Add(this.lblConditionsHeader);
            this.panel5.Controls.Add(this.lblRuleOC);
            this.panel5.Controls.Add(this.lblRuleFC);
            this.panel5.Controls.Add(this.lblRuleCategory);
            this.panel5.Location = new System.Drawing.Point(355, 177);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(312, 320);
            this.panel5.TabIndex = 9;
            // 
            // lblRuleConditions
            // 
            this.lblRuleConditions.AutoSize = true;
            this.lblRuleConditions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRuleConditions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuleConditions.ForeColor = System.Drawing.Color.Gray;
            this.lblRuleConditions.Location = new System.Drawing.Point(0, 118);
            this.lblRuleConditions.Name = "lblRuleConditions";
            this.lblRuleConditions.Size = new System.Drawing.Size(136, 25);
            this.lblRuleConditions.TabIndex = 4;
            this.lblRuleConditions.Text = "ruleConditions";
            // 
            // lblConditionsHeader
            // 
            this.lblConditionsHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblConditionsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConditionsHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConditionsHeader.ForeColor = System.Drawing.Color.White;
            this.lblConditionsHeader.Location = new System.Drawing.Point(0, 91);
            this.lblConditionsHeader.Name = "lblConditionsHeader";
            this.lblConditionsHeader.Size = new System.Drawing.Size(310, 27);
            this.lblConditionsHeader.TabIndex = 3;
            this.lblConditionsHeader.Text = "Conditions :";
            // 
            // lblRuleOC
            // 
            this.lblRuleOC.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRuleOC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuleOC.ForeColor = System.Drawing.Color.Gray;
            this.lblRuleOC.Location = new System.Drawing.Point(0, 61);
            this.lblRuleOC.Name = "lblRuleOC";
            this.lblRuleOC.Size = new System.Drawing.Size(310, 30);
            this.lblRuleOC.TabIndex = 2;
            this.lblRuleOC.Text = "ruleOC";
            // 
            // lblRuleFC
            // 
            this.lblRuleFC.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRuleFC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuleFC.ForeColor = System.Drawing.Color.Gray;
            this.lblRuleFC.Location = new System.Drawing.Point(0, 30);
            this.lblRuleFC.Name = "lblRuleFC";
            this.lblRuleFC.Size = new System.Drawing.Size(310, 31);
            this.lblRuleFC.TabIndex = 1;
            this.lblRuleFC.Text = "ruleFC";
            // 
            // lblRuleCategory
            // 
            this.lblRuleCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRuleCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRuleCategory.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRuleCategory.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRuleCategory.ForeColor = System.Drawing.Color.White;
            this.lblRuleCategory.Location = new System.Drawing.Point(0, 0);
            this.lblRuleCategory.Name = "lblRuleCategory";
            this.lblRuleCategory.Size = new System.Drawing.Size(310, 30);
            this.lblRuleCategory.TabIndex = 0;
            this.lblRuleCategory.Text = "ruleCategory";
            this.lblRuleCategory.UseCustomBackColor = true;
            this.lblRuleCategory.UseCustomForeColor = true;
            // 
            // checkBoxFC
            // 
            this.checkBoxFC.AutoSize = true;
            this.checkBoxFC.Enabled = false;
            this.checkBoxFC.Location = new System.Drawing.Point(355, 504);
            this.checkBoxFC.Name = "checkBoxFC";
            this.checkBoxFC.Size = new System.Drawing.Size(77, 15);
            this.checkBoxFC.TabIndex = 11;
            this.checkBoxFC.Text = "FC Cluster";
            this.checkBoxFC.UseSelectable = true;
            // 
            // checkBoxOC
            // 
            this.checkBoxOC.AutoSize = true;
            this.checkBoxOC.Enabled = false;
            this.checkBoxOC.Location = new System.Drawing.Point(355, 522);
            this.checkBoxOC.Name = "checkBoxOC";
            this.checkBoxOC.Size = new System.Drawing.Size(80, 15);
            this.checkBoxOC.TabIndex = 12;
            this.checkBoxOC.Text = "OC Cluster";
            this.checkBoxOC.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 624);
            this.Controls.Add(this.checkBoxOC);
            this.Controls.Add(this.checkBoxFC);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnLoadTree);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Xmrizer";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox txtFilePath;
        private MetroFramework.Controls.MetroButton btnBrowseFile;
        private MetroFramework.Controls.MetroLabel lblFile;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel lblRules;
        private MetroFramework.Controls.MetroButton btnLoadTree;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TreeView treeView1;
        private MetroFramework.Controls.MetroLabel lblRuleCategory;
        private MetroFramework.Controls.MetroLabel lblRuleName;
        private MetroFramework.Controls.MetroCheckBox checkBoxFC;
        private MetroFramework.Controls.MetroCheckBox checkBoxOC;
        private System.Windows.Forms.Label lblRuleOC;
        private System.Windows.Forms.Label lblRuleFC;
        private System.Windows.Forms.Label lblRuleConditions;
        private System.Windows.Forms.Label lblConditionsHeader;
    }
}