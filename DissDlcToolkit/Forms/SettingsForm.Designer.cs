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
            this.settingsMainDlcFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseMainDlcFolderButton = new System.Windows.Forms.Button();
            this.exexSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsBackupExex = new System.Windows.Forms.CheckBox();
            this.generalSettingsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.exexSettingsGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalSettingsGroupBox
            // 
            this.generalSettingsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.generalSettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.generalSettingsGroupBox.Name = "generalSettingsGroupBox";
            this.generalSettingsGroupBox.Size = new System.Drawing.Size(384, 61);
            this.generalSettingsGroupBox.TabIndex = 0;
            this.generalSettingsGroupBox.TabStop = false;
            this.generalSettingsGroupBox.Text = "General";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.43243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.56757F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
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
            // settingsMainDlcFolderTextBox
            // 
            this.settingsMainDlcFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsMainDlcFolderTextBox.Location = new System.Drawing.Point(99, 6);
            this.settingsMainDlcFolderTextBox.Name = "settingsMainDlcFolderTextBox";
            this.settingsMainDlcFolderTextBox.ReadOnly = true;
            this.settingsMainDlcFolderTextBox.Size = new System.Drawing.Size(196, 20);
            this.settingsMainDlcFolderTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main DLC folder";
            // 
            // browseMainDlcFolderButton
            // 
            this.browseMainDlcFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.browseMainDlcFolderButton.Location = new System.Drawing.Point(301, 4);
            this.browseMainDlcFolderButton.Name = "browseMainDlcFolderButton";
            this.browseMainDlcFolderButton.Size = new System.Drawing.Size(66, 23);
            this.browseMainDlcFolderButton.TabIndex = 3;
            this.browseMainDlcFolderButton.Text = "Browse...";
            this.browseMainDlcFolderButton.UseVisualStyleBackColor = true;
            this.browseMainDlcFolderButton.Click += new System.EventHandler(this.browseMainDlcFolderButton_Click);
            // 
            // exexSettingsGroupBox
            // 
            this.exexSettingsGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.exexSettingsGroupBox.Location = new System.Drawing.Point(12, 79);
            this.exexSettingsGroupBox.Name = "exexSettingsGroupBox";
            this.exexSettingsGroupBox.Size = new System.Drawing.Size(384, 53);
            this.exexSettingsGroupBox.TabIndex = 1;
            this.exexSettingsGroupBox.TabStop = false;
            this.exexSettingsGroupBox.Text = ".exex editing";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.053691F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.94631F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.settingsBackupExex, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(370, 21);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(27, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Backup original .exex when saving";
            // 
            // settingsBackupExex
            // 
            this.settingsBackupExex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBackupExex.AutoSize = true;
            this.settingsBackupExex.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsBackupExex.Location = new System.Drawing.Point(3, 3);
            this.settingsBackupExex.Name = "settingsBackupExex";
            this.settingsBackupExex.Size = new System.Drawing.Size(18, 14);
            this.settingsBackupExex.TabIndex = 1;
            this.settingsBackupExex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settingsBackupExex.UseVisualStyleBackColor = true;
            this.settingsBackupExex.CheckedChanged += new System.EventHandler(this.settingsBackupExex_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 145);
            this.Controls.Add(this.generalSettingsGroupBox);
            this.Controls.Add(this.exexSettingsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.generalSettingsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.exexSettingsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox generalSettingsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox settingsMainDlcFolderTextBox;
        private System.Windows.Forms.Button browseMainDlcFolderButton;
        private System.Windows.Forms.GroupBox exexSettingsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox settingsBackupExex;
    }
}