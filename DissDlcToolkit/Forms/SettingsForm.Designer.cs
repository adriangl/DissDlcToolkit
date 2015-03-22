namespace DissDlcToolkit.Forms
{
    partial class SettingsForm
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
            this.generalSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsMainDlcFolderTextBox = new System.Windows.Forms.TextBox();
            this.settingsSaveButton = new System.Windows.Forms.Button();
            this.browseMainDlcFolderButton = new System.Windows.Forms.Button();
            this.generalSettingsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalSettingsGroupBox
            // 
            this.generalSettingsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.generalSettingsGroupBox.Location = new System.Drawing.Point(13, 13);
            this.generalSettingsGroupBox.Name = "generalSettingsGroupBox";
            this.generalSettingsGroupBox.Size = new System.Drawing.Size(383, 58);
            this.generalSettingsGroupBox.TabIndex = 0;
            this.generalSettingsGroupBox.TabStop = false;
            this.generalSettingsGroupBox.Text = "General";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.43243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.56757F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.settingsMainDlcFolderTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.browseMainDlcFolderButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(370, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main DLC folder";
            // 
            // settingsMainDlcFolderTextBox
            // 
            this.settingsMainDlcFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsMainDlcFolderTextBox.Location = new System.Drawing.Point(100, 6);
            this.settingsMainDlcFolderTextBox.Name = "settingsMainDlcFolderTextBox";
            this.settingsMainDlcFolderTextBox.ReadOnly = true;
            this.settingsMainDlcFolderTextBox.Size = new System.Drawing.Size(196, 20);
            this.settingsMainDlcFolderTextBox.TabIndex = 2;
            // 
            // settingsSaveButton
            // 
            this.settingsSaveButton.Location = new System.Drawing.Point(166, 77);
            this.settingsSaveButton.Name = "settingsSaveButton";
            this.settingsSaveButton.Size = new System.Drawing.Size(75, 23);
            this.settingsSaveButton.TabIndex = 1;
            this.settingsSaveButton.Text = "Save";
            this.settingsSaveButton.UseVisualStyleBackColor = true;
            this.settingsSaveButton.Click += new System.EventHandler(this.settingsSaveButton_Click);
            // 
            // browseMainDlcFolderButton
            // 
            this.browseMainDlcFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.browseMainDlcFolderButton.Location = new System.Drawing.Point(302, 4);
            this.browseMainDlcFolderButton.Name = "browseMainDlcFolderButton";
            this.browseMainDlcFolderButton.Size = new System.Drawing.Size(65, 23);
            this.browseMainDlcFolderButton.TabIndex = 3;
            this.browseMainDlcFolderButton.Text = "Browse...";
            this.browseMainDlcFolderButton.UseVisualStyleBackColor = true;
            this.browseMainDlcFolderButton.Click += new System.EventHandler(this.browseMainDlcFolderButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 108);
            this.Controls.Add(this.settingsSaveButton);
            this.Controls.Add(this.generalSettingsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.generalSettingsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox generalSettingsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox settingsMainDlcFolderTextBox;
        private System.Windows.Forms.Button settingsSaveButton;
        private System.Windows.Forms.Button browseMainDlcFolderButton;
    }
}