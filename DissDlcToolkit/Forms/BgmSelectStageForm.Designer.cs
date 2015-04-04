namespace DissDlcToolkit.Forms
{
    partial class BgmSelectStageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BgmSelectStageForm));
            this.bgmSelectStageCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.bgmSelectStageListGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bgmSelectStageInvertSelection = new System.Windows.Forms.Button();
            this.bgmSelectStageSaveButton = new System.Windows.Forms.Button();
            this.bgmSelectStageSelectAllButton = new System.Windows.Forms.Button();
            this.bgmSelectStageListGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgmSelectStageCheckedListBox
            // 
            this.bgmSelectStageCheckedListBox.CheckOnClick = true;
            this.bgmSelectStageCheckedListBox.FormattingEnabled = true;
            this.bgmSelectStageCheckedListBox.Items.AddRange(new object[] {
            "Old Chaos Shrine",
            "Pandaemonium",
            "World Of Darkness",
            "Lunar Subterrane",
            "The Rift",
            "Kefka\'s Tower",
            "Planet\'s Core",
            "Ultimecia\'s Castle",
            "Crystal World",
            "Dream\'s End",
            "Edge of Madness",
            "Order\'s Sanctuary",
            "Empyreal Paradox",
            "Sky Fortress Bahamut",
            "Orphan\'s Cradle",
            "Pandaemonium - Top Floor",
            "Crystal Tower",
            "Phantom Train",
            "M.S. Prima Vista"});
            this.bgmSelectStageCheckedListBox.Location = new System.Drawing.Point(6, 19);
            this.bgmSelectStageCheckedListBox.Name = "bgmSelectStageCheckedListBox";
            this.bgmSelectStageCheckedListBox.Size = new System.Drawing.Size(206, 274);
            this.bgmSelectStageCheckedListBox.TabIndex = 0;
            // 
            // bgmSelectStageListGroupBox
            // 
            this.bgmSelectStageListGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.bgmSelectStageListGroupBox.Controls.Add(this.bgmSelectStageCheckedListBox);
            this.bgmSelectStageListGroupBox.Location = new System.Drawing.Point(12, 12);
            this.bgmSelectStageListGroupBox.Name = "bgmSelectStageListGroupBox";
            this.bgmSelectStageListGroupBox.Size = new System.Drawing.Size(218, 361);
            this.bgmSelectStageListGroupBox.TabIndex = 1;
            this.bgmSelectStageListGroupBox.TabStop = false;
            this.bgmSelectStageListGroupBox.Text = "Stage list";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bgmSelectStageInvertSelection, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bgmSelectStageSaveButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bgmSelectStageSelectAllButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 299);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 56);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // bgmSelectStageInvertSelection
            // 
            this.bgmSelectStageInvertSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmSelectStageInvertSelection.Location = new System.Drawing.Point(106, 3);
            this.bgmSelectStageInvertSelection.Name = "bgmSelectStageInvertSelection";
            this.bgmSelectStageInvertSelection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bgmSelectStageInvertSelection.Size = new System.Drawing.Size(97, 22);
            this.bgmSelectStageInvertSelection.TabIndex = 3;
            this.bgmSelectStageInvertSelection.Text = "Invert selection";
            this.bgmSelectStageInvertSelection.UseVisualStyleBackColor = true;
            this.bgmSelectStageInvertSelection.Click += new System.EventHandler(this.bgmSelectStageInvertSelection_Click);
            // 
            // bgmSelectStageSaveButton
            // 
            this.bgmSelectStageSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.bgmSelectStageSaveButton, 2);
            this.bgmSelectStageSaveButton.Location = new System.Drawing.Point(3, 31);
            this.bgmSelectStageSaveButton.Name = "bgmSelectStageSaveButton";
            this.bgmSelectStageSaveButton.Size = new System.Drawing.Size(200, 22);
            this.bgmSelectStageSaveButton.TabIndex = 1;
            this.bgmSelectStageSaveButton.Text = "Save";
            this.bgmSelectStageSaveButton.UseVisualStyleBackColor = true;
            this.bgmSelectStageSaveButton.Click += new System.EventHandler(this.bgmSelectStageSaveButton_Click);
            // 
            // bgmSelectStageSelectAllButton
            // 
            this.bgmSelectStageSelectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmSelectStageSelectAllButton.Location = new System.Drawing.Point(3, 3);
            this.bgmSelectStageSelectAllButton.Name = "bgmSelectStageSelectAllButton";
            this.bgmSelectStageSelectAllButton.Size = new System.Drawing.Size(97, 22);
            this.bgmSelectStageSelectAllButton.TabIndex = 2;
            this.bgmSelectStageSelectAllButton.Text = "Select all";
            this.bgmSelectStageSelectAllButton.UseVisualStyleBackColor = true;
            this.bgmSelectStageSelectAllButton.Click += new System.EventHandler(this.bgmSelectStageSelectAllButton_Click);
            // 
            // BgmSelectStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 383);
            this.Controls.Add(this.bgmSelectStageListGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BgmSelectStageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select stage";
            this.bgmSelectStageListGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox bgmSelectStageCheckedListBox;
        private System.Windows.Forms.GroupBox bgmSelectStageListGroupBox;
        private System.Windows.Forms.Button bgmSelectStageSaveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bgmSelectStageInvertSelection;
        private System.Windows.Forms.Button bgmSelectStageSelectAllButton;
    }
}