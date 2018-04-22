namespace DrKhaled.Xmrizer
{
    partial class SearchForm
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
            this.comboBoxSymbol = new MetroFramework.Controls.MetroComboBox();
            this.txtValue = new MetroFramework.Controls.MetroTextBox();
            this.listConditions = new System.Windows.Forms.ListBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.comboBoxProperties = new MetroFramework.Controls.MetroComboBox();
            this.txtFC = new MetroFramework.Controls.MetroTextBox();
            this.txtOC = new MetroFramework.Controls.MetroTextBox();
            this.txtCategory = new MetroFramework.Controls.MetroTextBox();
            this.btnAddFC = new MetroFramework.Controls.MetroButton();
            this.btnAddOC = new MetroFramework.Controls.MetroButton();
            this.btnAddCategory = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFile = new MetroFramework.Controls.MetroLabel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSymbol
            // 
            this.comboBoxSymbol.FormattingEnabled = true;
            this.comboBoxSymbol.ItemHeight = 23;
            this.comboBoxSymbol.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "!="});
            this.comboBoxSymbol.Location = new System.Drawing.Point(207, 73);
            this.comboBoxSymbol.Name = "comboBoxSymbol";
            this.comboBoxSymbol.Size = new System.Drawing.Size(69, 29);
            this.comboBoxSymbol.TabIndex = 1;
            this.comboBoxSymbol.UseSelectable = true;
            // 
            // txtValue
            // 
            // 
            // 
            // 
            this.txtValue.CustomButton.Image = null;
            this.txtValue.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtValue.CustomButton.Name = "";
            this.txtValue.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValue.CustomButton.TabIndex = 1;
            this.txtValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValue.CustomButton.UseSelectable = true;
            this.txtValue.CustomButton.Visible = false;
            this.txtValue.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtValue.Lines = new string[0];
            this.txtValue.Location = new System.Drawing.Point(282, 73);
            this.txtValue.MaxLength = 32767;
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.PromptText = "Value";
            this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValue.SelectedText = "";
            this.txtValue.SelectionLength = 0;
            this.txtValue.SelectionStart = 0;
            this.txtValue.ShortcutsEnabled = true;
            this.txtValue.Size = new System.Drawing.Size(160, 29);
            this.txtValue.TabIndex = 2;
            this.txtValue.UseSelectable = true;
            this.txtValue.WaterMark = "Value";
            this.txtValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listConditions
            // 
            this.listConditions.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listConditions.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listConditions.FormattingEnabled = true;
            this.listConditions.ItemHeight = 21;
            this.listConditions.Location = new System.Drawing.Point(5, 26);
            this.listConditions.Name = "listConditions";
            this.listConditions.Size = new System.Drawing.Size(633, 193);
            this.listConditions.TabIndex = 3;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(448, 73);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(111, 31);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Add";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(504, 463);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(166, 31);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "OK";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // comboBoxProperties
            // 
            this.comboBoxProperties.FormattingEnabled = true;
            this.comboBoxProperties.ItemHeight = 23;
            this.comboBoxProperties.Location = new System.Drawing.Point(24, 73);
            this.comboBoxProperties.Name = "comboBoxProperties";
            this.comboBoxProperties.PromptText = "Property";
            this.comboBoxProperties.Size = new System.Drawing.Size(177, 29);
            this.comboBoxProperties.TabIndex = 6;
            this.comboBoxProperties.UseSelectable = true;
            // 
            // txtFC
            // 
            // 
            // 
            // 
            this.txtFC.CustomButton.Image = null;
            this.txtFC.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtFC.CustomButton.Name = "";
            this.txtFC.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFC.CustomButton.TabIndex = 1;
            this.txtFC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFC.CustomButton.UseSelectable = true;
            this.txtFC.CustomButton.Visible = false;
            this.txtFC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFC.Lines = new string[0];
            this.txtFC.Location = new System.Drawing.Point(26, 112);
            this.txtFC.MaxLength = 32767;
            this.txtFC.Name = "txtFC";
            this.txtFC.PasswordChar = '\0';
            this.txtFC.PromptText = "FC Value";
            this.txtFC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFC.SelectedText = "";
            this.txtFC.SelectionLength = 0;
            this.txtFC.SelectionStart = 0;
            this.txtFC.ShortcutsEnabled = true;
            this.txtFC.Size = new System.Drawing.Size(160, 29);
            this.txtFC.TabIndex = 9;
            this.txtFC.UseSelectable = true;
            this.txtFC.WaterMark = "FC Value";
            this.txtFC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOC
            // 
            // 
            // 
            // 
            this.txtOC.CustomButton.Image = null;
            this.txtOC.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtOC.CustomButton.Name = "";
            this.txtOC.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtOC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOC.CustomButton.TabIndex = 1;
            this.txtOC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOC.CustomButton.UseSelectable = true;
            this.txtOC.CustomButton.Visible = false;
            this.txtOC.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOC.Lines = new string[0];
            this.txtOC.Location = new System.Drawing.Point(26, 147);
            this.txtOC.MaxLength = 32767;
            this.txtOC.Name = "txtOC";
            this.txtOC.PasswordChar = '\0';
            this.txtOC.PromptText = "OC Value";
            this.txtOC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOC.SelectedText = "";
            this.txtOC.SelectionLength = 0;
            this.txtOC.SelectionStart = 0;
            this.txtOC.ShortcutsEnabled = true;
            this.txtOC.Size = new System.Drawing.Size(160, 29);
            this.txtOC.TabIndex = 12;
            this.txtOC.UseSelectable = true;
            this.txtOC.WaterMark = "OC Value";
            this.txtOC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCategory
            // 
            // 
            // 
            // 
            this.txtCategory.CustomButton.Image = null;
            this.txtCategory.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtCategory.CustomButton.Name = "";
            this.txtCategory.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCategory.CustomButton.TabIndex = 1;
            this.txtCategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCategory.CustomButton.UseSelectable = true;
            this.txtCategory.CustomButton.Visible = false;
            this.txtCategory.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCategory.Lines = new string[0];
            this.txtCategory.Location = new System.Drawing.Point(26, 182);
            this.txtCategory.MaxLength = 32767;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.PromptText = "Category Value";
            this.txtCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategory.SelectedText = "";
            this.txtCategory.SelectionLength = 0;
            this.txtCategory.SelectionStart = 0;
            this.txtCategory.ShortcutsEnabled = true;
            this.txtCategory.Size = new System.Drawing.Size(160, 29);
            this.txtCategory.TabIndex = 14;
            this.txtCategory.UseSelectable = true;
            this.txtCategory.WaterMark = "Category Value";
            this.txtCategory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCategory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddFC
            // 
            this.btnAddFC.Location = new System.Drawing.Point(192, 111);
            this.btnAddFC.Name = "btnAddFC";
            this.btnAddFC.Size = new System.Drawing.Size(111, 31);
            this.btnAddFC.TabIndex = 15;
            this.btnAddFC.Text = "Add";
            this.btnAddFC.UseSelectable = true;
            this.btnAddFC.Click += new System.EventHandler(this.btnAddFC_Click);
            // 
            // btnAddOC
            // 
            this.btnAddOC.Location = new System.Drawing.Point(192, 146);
            this.btnAddOC.Name = "btnAddOC";
            this.btnAddOC.Size = new System.Drawing.Size(111, 31);
            this.btnAddOC.TabIndex = 16;
            this.btnAddOC.Text = "Add";
            this.btnAddOC.UseSelectable = true;
            this.btnAddOC.Click += new System.EventHandler(this.btnAddOC_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(192, 181);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(111, 31);
            this.btnAddCategory.TabIndex = 17;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseSelectable = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblFile);
            this.panel2.Controls.Add(this.listConditions);
            this.panel2.Location = new System.Drawing.Point(24, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 228);
            this.panel2.TabIndex = 18;
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
            this.lblFile.Text = "Search Conditions";
            this.lblFile.UseCustomBackColor = true;
            this.lblFile.UseCustomForeColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 514);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnAddOC);
            this.Controls.Add(this.btnAddFC);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtOC);
            this.Controls.Add(this.txtFC);
            this.Controls.Add(this.comboBoxProperties);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.comboBoxSymbol);
            this.Name = "SearchForm";
            this.Resizable = false;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox comboBoxSymbol;
        private MetroFramework.Controls.MetroTextBox txtValue;
        private System.Windows.Forms.ListBox listConditions;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroComboBox comboBoxProperties;
        private MetroFramework.Controls.MetroTextBox txtFC;
        private MetroFramework.Controls.MetroTextBox txtOC;
        private MetroFramework.Controls.MetroTextBox txtCategory;
        private MetroFramework.Controls.MetroButton btnAddFC;
        private MetroFramework.Controls.MetroButton btnAddOC;
        private MetroFramework.Controls.MetroButton btnAddCategory;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel lblFile;
    }
}