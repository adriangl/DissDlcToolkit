namespace DissDlcToolkit.Forms
{
    partial class MainFormBgmGenUserControl
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bgmGenSaveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bgmGenDlcSlotComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bgmGenNewButton = new System.Windows.Forms.Button();
            this.bgmGenLoadButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.bgmGenStageSelectButton = new System.Windows.Forms.Button();
            this.bgmGenCharactersSelectButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.bgmGenBrowseAt3Button = new System.Windows.Forms.Button();
            this.bgmGenAt3FileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bgmGenBgmTitleTextBox = new System.Windows.Forms.TextBox();
            this.bgmGenBgmVolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.bgmGenVolumeTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bgmGenAddButton = new System.Windows.Forms.Button();
            this.bgmGenRemoveButton = new System.Windows.Forms.Button();
            this.bgmGenUpButton = new System.Windows.Forms.Button();
            this.bgmGenDownButton = new System.Windows.Forms.Button();
            this.bgmGenBgmListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgmGenBgmVolumeTrackBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bgmGenSaveButton);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.bgmGenBgmListBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 278);
            this.panel1.TabIndex = 1;
            // 
            // bgmGenSaveButton
            // 
            this.bgmGenSaveButton.Enabled = false;
            this.bgmGenSaveButton.Location = new System.Drawing.Point(235, 230);
            this.bgmGenSaveButton.Name = "bgmGenSaveButton";
            this.bgmGenSaveButton.Size = new System.Drawing.Size(75, 23);
            this.bgmGenSaveButton.TabIndex = 27;
            this.bgmGenSaveButton.Text = "Save";
            this.bgmGenSaveButton.UseVisualStyleBackColor = true;
            this.bgmGenSaveButton.Click += new System.EventHandler(this.bgmGenSaveButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.3038F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.6962F));
            this.tableLayoutPanel4.Controls.Add(this.bgmGenDlcSlotComboBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(136, 7);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(158, 32);
            this.tableLayoutPanel4.TabIndex = 26;
            // 
            // bgmGenDlcSlotComboBox
            // 
            this.bgmGenDlcSlotComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmGenDlcSlotComboBox.Enabled = false;
            this.bgmGenDlcSlotComboBox.FormattingEnabled = true;
            this.bgmGenDlcSlotComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.bgmGenDlcSlotComboBox.Location = new System.Drawing.Point(73, 5);
            this.bgmGenDlcSlotComboBox.Name = "bgmGenDlcSlotComboBox";
            this.bgmGenDlcSlotComboBox.Size = new System.Drawing.Size(82, 21);
            this.bgmGenDlcSlotComboBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "DLC Slot";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.bgmGenNewButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bgmGenLoadButton, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(123, 32);
            this.tableLayoutPanel3.TabIndex = 25;
            // 
            // bgmGenNewButton
            // 
            this.bgmGenNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmGenNewButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bgmGenNewButton.Location = new System.Drawing.Point(3, 3);
            this.bgmGenNewButton.Name = "bgmGenNewButton";
            this.bgmGenNewButton.Size = new System.Drawing.Size(55, 25);
            this.bgmGenNewButton.TabIndex = 21;
            this.bgmGenNewButton.Text = "New";
            this.bgmGenNewButton.UseVisualStyleBackColor = true;
            this.bgmGenNewButton.Click += new System.EventHandler(this.bgmGenNewButton_Click);
            // 
            // bgmGenLoadButton
            // 
            this.bgmGenLoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmGenLoadButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bgmGenLoadButton.Location = new System.Drawing.Point(64, 3);
            this.bgmGenLoadButton.Name = "bgmGenLoadButton";
            this.bgmGenLoadButton.Size = new System.Drawing.Size(56, 25);
            this.bgmGenLoadButton.TabIndex = 22;
            this.bgmGenLoadButton.Text = "Load...";
            this.bgmGenLoadButton.UseVisualStyleBackColor = true;
            this.bgmGenLoadButton.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel5);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(136, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 160);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BGM Info";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.bgmGenStageSelectButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.bgmGenCharactersSelectButton, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 119);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(256, 35);
            this.tableLayoutPanel5.TabIndex = 26;
            // 
            // bgmGenStageSelectButton
            // 
            this.bgmGenStageSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmGenStageSelectButton.Enabled = false;
            this.bgmGenStageSelectButton.Location = new System.Drawing.Point(131, 6);
            this.bgmGenStageSelectButton.Name = "bgmGenStageSelectButton";
            this.bgmGenStageSelectButton.Size = new System.Drawing.Size(122, 23);
            this.bgmGenStageSelectButton.TabIndex = 1;
            this.bgmGenStageSelectButton.Text = "Stages by default";
            this.bgmGenStageSelectButton.UseVisualStyleBackColor = true;
            this.bgmGenStageSelectButton.Click += new System.EventHandler(this.bgmGenStageSelectButton_Click);
            // 
            // bgmGenCharactersSelectButton
            // 
            this.bgmGenCharactersSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmGenCharactersSelectButton.Enabled = false;
            this.bgmGenCharactersSelectButton.Location = new System.Drawing.Point(3, 6);
            this.bgmGenCharactersSelectButton.Name = "bgmGenCharactersSelectButton";
            this.bgmGenCharactersSelectButton.Size = new System.Drawing.Size(122, 23);
            this.bgmGenCharactersSelectButton.TabIndex = 0;
            this.bgmGenCharactersSelectButton.Text = "Characters by default";
            this.bgmGenCharactersSelectButton.UseVisualStyleBackColor = true;
            this.bgmGenCharactersSelectButton.Click += new System.EventHandler(this.bgmGenCharactersSelectButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.17188F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.04688F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.14563F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.14563F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.bgmGenBrowseAt3Button, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.bgmGenAt3FileTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bgmGenBgmTitleTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bgmGenBgmVolumeTrackBar, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.bgmGenVolumeTextBox, 3, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(256, 97);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Volume (%)";
            // 
            // bgmGenBrowseAt3Button
            // 
            this.bgmGenBrowseAt3Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmGenBrowseAt3Button.Enabled = false;
            this.bgmGenBrowseAt3Button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bgmGenBrowseAt3Button.Location = new System.Drawing.Point(193, 36);
            this.bgmGenBrowseAt3Button.Name = "bgmGenBrowseAt3Button";
            this.bgmGenBrowseAt3Button.Size = new System.Drawing.Size(60, 24);
            this.bgmGenBrowseAt3Button.TabIndex = 28;
            this.bgmGenBrowseAt3Button.Text = "Browse...";
            this.bgmGenBrowseAt3Button.UseVisualStyleBackColor = true;
            this.bgmGenBrowseAt3Button.Click += new System.EventHandler(this.bgmGenBrowseAt3Button_Click);
            // 
            // bgmGenAt3FileTextBox
            // 
            this.bgmGenAt3FileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.bgmGenAt3FileTextBox, 2);
            this.bgmGenAt3FileTextBox.Enabled = false;
            this.bgmGenAt3FileTextBox.Location = new System.Drawing.Point(70, 38);
            this.bgmGenAt3FileTextBox.Name = "bgmGenAt3FileTextBox";
            this.bgmGenAt3FileTextBox.Size = new System.Drawing.Size(117, 20);
            this.bgmGenAt3FileTextBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AT3 File";
            // 
            // bgmGenBgmTitleTextBox
            // 
            this.bgmGenBgmTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.bgmGenBgmTitleTextBox, 3);
            this.bgmGenBgmTitleTextBox.Enabled = false;
            this.bgmGenBgmTitleTextBox.Location = new System.Drawing.Point(70, 6);
            this.bgmGenBgmTitleTextBox.MaxLength = 36;
            this.bgmGenBgmTitleTextBox.Name = "bgmGenBgmTitleTextBox";
            this.bgmGenBgmTitleTextBox.Size = new System.Drawing.Size(183, 20);
            this.bgmGenBgmTitleTextBox.TabIndex = 26;
            // 
            // bgmGenBgmVolumeTrackBar
            // 
            this.bgmGenBgmVolumeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmGenBgmVolumeTrackBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel2.SetColumnSpan(this.bgmGenBgmVolumeTrackBar, 2);
            this.bgmGenBgmVolumeTrackBar.Enabled = false;
            this.bgmGenBgmVolumeTrackBar.Location = new System.Drawing.Point(70, 67);
            this.bgmGenBgmVolumeTrackBar.Maximum = 100;
            this.bgmGenBgmVolumeTrackBar.Name = "bgmGenBgmVolumeTrackBar";
            this.bgmGenBgmVolumeTrackBar.Size = new System.Drawing.Size(117, 27);
            this.bgmGenBgmVolumeTrackBar.TabIndex = 29;
            this.bgmGenBgmVolumeTrackBar.Scroll += new System.EventHandler(this.bgmGenBgmVolumeTrackBar_Scroll);
            // 
            // bgmGenVolumeTextBox
            // 
            this.bgmGenVolumeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmGenVolumeTextBox.Location = new System.Drawing.Point(193, 70);
            this.bgmGenVolumeTextBox.Name = "bgmGenVolumeTextBox";
            this.bgmGenVolumeTextBox.ReadOnly = true;
            this.bgmGenVolumeTextBox.Size = new System.Drawing.Size(60, 20);
            this.bgmGenVolumeTextBox.TabIndex = 31;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bgmGenAddButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bgmGenRemoveButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bgmGenUpButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bgmGenDownButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 211);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(123, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // bgmGenAddButton
            // 
            this.bgmGenAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmGenAddButton.Enabled = false;
            this.bgmGenAddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bgmGenAddButton.Location = new System.Drawing.Point(3, 33);
            this.bgmGenAddButton.Name = "bgmGenAddButton";
            this.bgmGenAddButton.Size = new System.Drawing.Size(55, 24);
            this.bgmGenAddButton.TabIndex = 24;
            this.bgmGenAddButton.Text = "Add";
            this.bgmGenAddButton.UseVisualStyleBackColor = true;
            this.bgmGenAddButton.Click += new System.EventHandler(this.bgmGenAddButton_Click);
            // 
            // bgmGenRemoveButton
            // 
            this.bgmGenRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmGenRemoveButton.Enabled = false;
            this.bgmGenRemoveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bgmGenRemoveButton.Location = new System.Drawing.Point(64, 33);
            this.bgmGenRemoveButton.Name = "bgmGenRemoveButton";
            this.bgmGenRemoveButton.Size = new System.Drawing.Size(56, 24);
            this.bgmGenRemoveButton.TabIndex = 23;
            this.bgmGenRemoveButton.Text = "Remove";
            this.bgmGenRemoveButton.UseVisualStyleBackColor = true;
            this.bgmGenRemoveButton.Click += new System.EventHandler(this.bgmGenRemoveButton_Click);
            // 
            // bgmGenUpButton
            // 
            this.bgmGenUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmGenUpButton.Enabled = false;
            this.bgmGenUpButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bgmGenUpButton.Location = new System.Drawing.Point(3, 3);
            this.bgmGenUpButton.Name = "bgmGenUpButton";
            this.bgmGenUpButton.Size = new System.Drawing.Size(55, 24);
            this.bgmGenUpButton.TabIndex = 21;
            this.bgmGenUpButton.Text = "Up";
            this.bgmGenUpButton.UseVisualStyleBackColor = true;
            this.bgmGenUpButton.Click += new System.EventHandler(this.bgmGenUpButton_Click);
            // 
            // bgmGenDownButton
            // 
            this.bgmGenDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bgmGenDownButton.Enabled = false;
            this.bgmGenDownButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bgmGenDownButton.Location = new System.Drawing.Point(64, 3);
            this.bgmGenDownButton.Name = "bgmGenDownButton";
            this.bgmGenDownButton.Size = new System.Drawing.Size(56, 24);
            this.bgmGenDownButton.TabIndex = 22;
            this.bgmGenDownButton.Text = "Down";
            this.bgmGenDownButton.UseVisualStyleBackColor = true;
            this.bgmGenDownButton.Click += new System.EventHandler(this.bgmGenDownButton_Click);
            // 
            // bgmGenBgmListBox
            // 
            this.bgmGenBgmListBox.Enabled = false;
            this.bgmGenBgmListBox.FormattingEnabled = true;
            this.bgmGenBgmListBox.Location = new System.Drawing.Point(6, 45);
            this.bgmGenBgmListBox.Name = "bgmGenBgmListBox";
            this.bgmGenBgmListBox.Size = new System.Drawing.Size(124, 160);
            this.bgmGenBgmListBox.TabIndex = 0;
            this.bgmGenBgmListBox.SelectedIndexChanged += new System.EventHandler(this.bgmGenBgmListBox_SelectedIndexChanged);
            // 
            // MainFormBgmGenUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MainFormBgmGenUserControl";
            this.Size = new System.Drawing.Size(407, 278);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgmGenBgmVolumeTrackBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox bgmGenDlcSlotComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button bgmGenNewButton;
        private System.Windows.Forms.Button bgmGenLoadButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bgmGenBrowseAt3Button;
        private System.Windows.Forms.TextBox bgmGenAt3FileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bgmGenBgmTitleTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bgmGenAddButton;
        private System.Windows.Forms.Button bgmGenRemoveButton;
        private System.Windows.Forms.Button bgmGenUpButton;
        private System.Windows.Forms.Button bgmGenDownButton;
        private System.Windows.Forms.ListBox bgmGenBgmListBox;
        private System.Windows.Forms.Button bgmGenSaveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button bgmGenStageSelectButton;
        private System.Windows.Forms.Button bgmGenCharactersSelectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar bgmGenBgmVolumeTrackBar;
        private System.Windows.Forms.TextBox bgmGenVolumeTextBox;
    }
}
