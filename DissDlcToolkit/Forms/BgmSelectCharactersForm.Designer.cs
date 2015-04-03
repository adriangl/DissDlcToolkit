namespace DissDlcToolkit.Forms
{
    partial class BgmSelectCharactersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BgmSelectCharactersForm));
            this.bgmSelectCharactersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.bgmSelectCharactersListGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bgmSelectCharactersSaveButton = new System.Windows.Forms.Button();
            this.bgmSelectCharactersInvertSelection = new System.Windows.Forms.Button();
            this.bgmSelectCharactersSelectAllButton = new System.Windows.Forms.Button();
            this.bgmSelectCharactersListGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgmSelectCharactersCheckedListBox
            // 
            this.bgmSelectCharactersCheckedListBox.CheckOnClick = true;
            this.bgmSelectCharactersCheckedListBox.FormattingEnabled = true;
            this.bgmSelectCharactersCheckedListBox.Items.AddRange(new object[] {
            "Warrior of Light",
            "Garland",
            "Firion",
            "The Emperor",
            "Onion Knight",
            "Cloud of Darkness",
            "Cecil",
            "Golbez",
            "Bartz",
            "Ex-Death",
            "Terra",
            "Kefka",
            "Cloud",
            "Sephiroth",
            "Squall",
            "Ultimecia",
            "Zidane",
            "Kuja",
            "Tidus",
            "Jecht",
            "Shantotto",
            "Gabranth",
            "Kain",
            "Gilgamesh",
            "Tifa",
            "Laguna",
            "Yuna",
            "Prishe",
            "Vaan",
            "Lightning",
            "Chaos & Feral Chaos"});
            this.bgmSelectCharactersCheckedListBox.Location = new System.Drawing.Point(6, 19);
            this.bgmSelectCharactersCheckedListBox.Name = "bgmSelectCharactersCheckedListBox";
            this.bgmSelectCharactersCheckedListBox.Size = new System.Drawing.Size(206, 274);
            this.bgmSelectCharactersCheckedListBox.TabIndex = 0;
            // 
            // bgmSelectCharactersListGroupBox
            // 
            this.bgmSelectCharactersListGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.bgmSelectCharactersListGroupBox.Controls.Add(this.bgmSelectCharactersCheckedListBox);
            this.bgmSelectCharactersListGroupBox.Location = new System.Drawing.Point(12, 12);
            this.bgmSelectCharactersListGroupBox.Name = "bgmSelectCharactersListGroupBox";
            this.bgmSelectCharactersListGroupBox.Size = new System.Drawing.Size(218, 361);
            this.bgmSelectCharactersListGroupBox.TabIndex = 1;
            this.bgmSelectCharactersListGroupBox.TabStop = false;
            this.bgmSelectCharactersListGroupBox.Text = "Character list";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bgmSelectCharactersInvertSelection, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bgmSelectCharactersSaveButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bgmSelectCharactersSelectAllButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 299);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 56);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // bgmSelectCharactersSaveButton
            // 
            this.bgmSelectCharactersSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.bgmSelectCharactersSaveButton, 2);
            this.bgmSelectCharactersSaveButton.Location = new System.Drawing.Point(3, 31);
            this.bgmSelectCharactersSaveButton.Name = "bgmSelectCharactersSaveButton";
            this.bgmSelectCharactersSaveButton.Size = new System.Drawing.Size(200, 22);
            this.bgmSelectCharactersSaveButton.TabIndex = 1;
            this.bgmSelectCharactersSaveButton.Text = "Save";
            this.bgmSelectCharactersSaveButton.UseVisualStyleBackColor = true;
            this.bgmSelectCharactersSaveButton.Click += new System.EventHandler(this.bgmSelectCharactersSaveButton_Click);
            // 
            // bgmSelectCharactersInvertSelection
            // 
            this.bgmSelectCharactersInvertSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmSelectCharactersInvertSelection.Location = new System.Drawing.Point(106, 3);
            this.bgmSelectCharactersInvertSelection.Name = "bgmSelectCharactersInvertSelection";
            this.bgmSelectCharactersInvertSelection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bgmSelectCharactersInvertSelection.Size = new System.Drawing.Size(97, 22);
            this.bgmSelectCharactersInvertSelection.TabIndex = 3;
            this.bgmSelectCharactersInvertSelection.Text = "Invert selection";
            this.bgmSelectCharactersInvertSelection.UseVisualStyleBackColor = true;
            this.bgmSelectCharactersInvertSelection.Click += new System.EventHandler(this.bgmSelectCharactersInvertSelection_Click);
            // 
            // bgmSelectCharactersSelectAllButton
            // 
            this.bgmSelectCharactersSelectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmSelectCharactersSelectAllButton.Location = new System.Drawing.Point(3, 3);
            this.bgmSelectCharactersSelectAllButton.Name = "bgmSelectCharactersSelectAllButton";
            this.bgmSelectCharactersSelectAllButton.Size = new System.Drawing.Size(97, 22);
            this.bgmSelectCharactersSelectAllButton.TabIndex = 2;
            this.bgmSelectCharactersSelectAllButton.Text = "Select all";
            this.bgmSelectCharactersSelectAllButton.UseVisualStyleBackColor = true;
            this.bgmSelectCharactersSelectAllButton.Click += new System.EventHandler(this.bgmSelectCharactersSelectAllButton_Click);
            // 
            // BgmSelectCharactersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 383);
            this.Controls.Add(this.bgmSelectCharactersListGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BgmSelectCharactersForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select characters";
            this.bgmSelectCharactersListGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox bgmSelectCharactersCheckedListBox;
        private System.Windows.Forms.GroupBox bgmSelectCharactersListGroupBox;
        private System.Windows.Forms.Button bgmSelectCharactersSaveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bgmSelectCharactersInvertSelection;
        private System.Windows.Forms.Button bgmSelectCharactersSelectAllButton;
    }
}