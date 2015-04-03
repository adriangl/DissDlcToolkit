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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.generalSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.settingsMainDlcFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseMainDlcFolderButton = new System.Windows.Forms.Button();
            this.exexSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsBackupExex = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.settingsDlcGenReadmeEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.settingsAttachmentReadmeEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.settingsBgmReadmeEnabled = new System.Windows.Forms.CheckBox();
            this.generalSettingsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.exexSettingsGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
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
            this.settingsMainDlcFolderTextBox.Location = new System.Drawing.Point(98, 6);
            this.settingsMainDlcFolderTextBox.Name = "settingsMainDlcFolderTextBox";
            this.settingsMainDlcFolderTextBox.ReadOnly = true;
            this.settingsMainDlcFolderTextBox.Size = new System.Drawing.Size(193, 20);
            this.settingsMainDlcFolderTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main DLC folder";
            // 
            // browseMainDlcFolderButton
            // 
            this.browseMainDlcFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.browseMainDlcFolderButton.Location = new System.Drawing.Point(297, 4);
            this.browseMainDlcFolderButton.Name = "browseMainDlcFolderButton";
            this.browseMainDlcFolderButton.Size = new System.Drawing.Size(70, 23);
            this.browseMainDlcFolderButton.TabIndex = 3;
            this.browseMainDlcFolderButton.Text = "Browse...";
            this.browseMainDlcFolderButton.UseVisualStyleBackColor = true;
            this.browseMainDlcFolderButton.Click += new System.EventHandler(this.browseMainDlcFolderButton_Click);
            // 
            // exexSettingsGroupBox
            // 
            this.exexSettingsGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.exexSettingsGroupBox.Location = new System.Drawing.Point(12, 138);
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
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
            this.label2.Location = new System.Drawing.Point(26, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Backup original .exex when saving";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // settingsBackupExex
            // 
            this.settingsBackupExex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBackupExex.AutoSize = true;
            this.settingsBackupExex.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsBackupExex.Location = new System.Drawing.Point(3, 3);
            this.settingsBackupExex.Name = "settingsBackupExex";
            this.settingsBackupExex.Size = new System.Drawing.Size(17, 14);
            this.settingsBackupExex.TabIndex = 1;
            this.settingsBackupExex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settingsBackupExex.UseVisualStyleBackColor = true;
            this.settingsBackupExex.CheckedChanged += new System.EventHandler(this.settingsBackupExex_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DLC Generation";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.053691F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.94631F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.settingsDlcGenReadmeEnabled, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(370, 21);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(26, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Create \'readme.txt\'";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // settingsDlcGenReadmeEnabled
            // 
            this.settingsDlcGenReadmeEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsDlcGenReadmeEnabled.AutoSize = true;
            this.settingsDlcGenReadmeEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsDlcGenReadmeEnabled.Location = new System.Drawing.Point(3, 3);
            this.settingsDlcGenReadmeEnabled.Name = "settingsDlcGenReadmeEnabled";
            this.settingsDlcGenReadmeEnabled.Size = new System.Drawing.Size(17, 14);
            this.settingsDlcGenReadmeEnabled.TabIndex = 1;
            this.settingsDlcGenReadmeEnabled.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settingsDlcGenReadmeEnabled.UseVisualStyleBackColor = true;
            this.settingsDlcGenReadmeEnabled.CheckedChanged += new System.EventHandler(this.settingsDlcGenReadmeEnabled_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 53);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attachments";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.053691F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.94631F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.settingsAttachmentReadmeEnabled, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(370, 21);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label4, 2);
            this.label4.Location = new System.Drawing.Point(26, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Create \'readme.txt\'";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // settingsAttachmentReadmeEnabled
            // 
            this.settingsAttachmentReadmeEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsAttachmentReadmeEnabled.AutoSize = true;
            this.settingsAttachmentReadmeEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsAttachmentReadmeEnabled.Location = new System.Drawing.Point(3, 3);
            this.settingsAttachmentReadmeEnabled.Name = "settingsAttachmentReadmeEnabled";
            this.settingsAttachmentReadmeEnabled.Size = new System.Drawing.Size(17, 14);
            this.settingsAttachmentReadmeEnabled.TabIndex = 1;
            this.settingsAttachmentReadmeEnabled.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settingsAttachmentReadmeEnabled.UseVisualStyleBackColor = true;
            this.settingsAttachmentReadmeEnabled.CheckedChanged += new System.EventHandler(this.settingsAttachmentReadmeEnabled_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel5);
            this.groupBox3.Location = new System.Drawing.Point(12, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 53);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BGM Generation";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.053691F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.94631F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel5.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.settingsBgmReadmeEnabled, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(370, 21);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.label5, 2);
            this.label5.Location = new System.Drawing.Point(26, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Create \'readme.txt\'";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // settingsBgmReadmeEnabled
            // 
            this.settingsBgmReadmeEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBgmReadmeEnabled.AutoSize = true;
            this.settingsBgmReadmeEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsBgmReadmeEnabled.Location = new System.Drawing.Point(3, 3);
            this.settingsBgmReadmeEnabled.Name = "settingsBgmReadmeEnabled";
            this.settingsBgmReadmeEnabled.Size = new System.Drawing.Size(17, 14);
            this.settingsBgmReadmeEnabled.TabIndex = 1;
            this.settingsBgmReadmeEnabled.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settingsBgmReadmeEnabled.UseVisualStyleBackColor = true;
            this.settingsBgmReadmeEnabled.CheckedChanged += new System.EventHandler(this.settingsBgmReadmeEnabled_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 325);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generalSettingsGroupBox);
            this.Controls.Add(this.exexSettingsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.generalSettingsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.exexSettingsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox settingsDlcGenReadmeEnabled;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox settingsAttachmentReadmeEnabled;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox settingsBgmReadmeEnabled;
    }
}