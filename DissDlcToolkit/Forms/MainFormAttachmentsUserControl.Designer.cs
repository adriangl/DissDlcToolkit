namespace DissDlcToolkit.Forms
{
    partial class MainFormAttachmentsUserControl
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.attachmentLinkBaseControllerTextBox = new System.Windows.Forms.TextBox();
            this.attachmentLinkBrowseCharacterControllerButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.attachmentLinkIdRadioButton = new System.Windows.Forms.RadioButton();
            this.attachmentLinkControllerRadioButton = new System.Windows.Forms.RadioButton();
            this.attachmentLinkDataLabel = new System.Windows.Forms.Label();
            this.attachmentLinkDataTextBox = new System.Windows.Forms.TextBox();
            this.attachmentLinkBrowseLinkedControllerButton = new System.Windows.Forms.Button();
            this.attachmentLinkGenerateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.attachmentCreationBaseComboBox = new System.Windows.Forms.ComboBox();
            this.attachmentCreationDlcSlotComboBox = new System.Windows.Forms.ComboBox();
            this.attachmentCreationGmoFileTextBox = new System.Windows.Forms.TextBox();
            this.attachmentCreationGenerateButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.attachmentCreationBrowseGmoFileButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 278);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(6, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Linking";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.attachmentLinkBaseControllerTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.attachmentLinkBrowseCharacterControllerButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.attachmentLinkDataLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.attachmentLinkDataTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.attachmentLinkBrowseLinkedControllerButton, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.attachmentLinkGenerateButton, 4, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 94);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Base controller";
            // 
            // attachmentLinkBaseControllerTextBox
            // 
            this.attachmentLinkBaseControllerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.attachmentLinkBaseControllerTextBox, 2);
            this.attachmentLinkBaseControllerTextBox.Location = new System.Drawing.Point(80, 5);
            this.attachmentLinkBaseControllerTextBox.Name = "attachmentLinkBaseControllerTextBox";
            this.attachmentLinkBaseControllerTextBox.Size = new System.Drawing.Size(148, 20);
            this.attachmentLinkBaseControllerTextBox.TabIndex = 8;
            // 
            // attachmentLinkBrowseCharacterControllerButton
            // 
            this.attachmentLinkBrowseCharacterControllerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attachmentLinkBrowseCharacterControllerButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.attachmentLinkBrowseCharacterControllerButton.Location = new System.Drawing.Point(239, 4);
            this.attachmentLinkBrowseCharacterControllerButton.Name = "attachmentLinkBrowseCharacterControllerButton";
            this.attachmentLinkBrowseCharacterControllerButton.Size = new System.Drawing.Size(61, 23);
            this.attachmentLinkBrowseCharacterControllerButton.TabIndex = 6;
            this.attachmentLinkBrowseCharacterControllerButton.Text = "Browse...";
            this.attachmentLinkBrowseCharacterControllerButton.UseVisualStyleBackColor = true;
            this.attachmentLinkBrowseCharacterControllerButton.Click += new System.EventHandler(this.attachmentLinkBrowseCharacterControllerButton_Click);
            // 
            // panel2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.attachmentLinkIdRadioButton);
            this.panel2.Controls.Add(this.attachmentLinkControllerRadioButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 31);
            this.panel2.TabIndex = 9;
            // 
            // attachmentLinkIdRadioButton
            // 
            this.attachmentLinkIdRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentLinkIdRadioButton.AutoSize = true;
            this.attachmentLinkIdRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.attachmentLinkIdRadioButton.Location = new System.Drawing.Point(135, 7);
            this.attachmentLinkIdRadioButton.Name = "attachmentLinkIdRadioButton";
            this.attachmentLinkIdRadioButton.Size = new System.Drawing.Size(93, 17);
            this.attachmentLinkIdRadioButton.TabIndex = 2;
            this.attachmentLinkIdRadioButton.TabStop = true;
            this.attachmentLinkIdRadioButton.Text = "Attachment ID";
            this.attachmentLinkIdRadioButton.UseVisualStyleBackColor = true;
            this.attachmentLinkIdRadioButton.CheckedChanged += new System.EventHandler(this.attachmentLinkIdRadioButton_CheckedChanged);
            // 
            // attachmentLinkControllerRadioButton
            // 
            this.attachmentLinkControllerRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentLinkControllerRadioButton.AutoSize = true;
            this.attachmentLinkControllerRadioButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.attachmentLinkControllerRadioButton.Location = new System.Drawing.Point(6, 7);
            this.attachmentLinkControllerRadioButton.Name = "attachmentLinkControllerRadioButton";
            this.attachmentLinkControllerRadioButton.Size = new System.Drawing.Size(125, 17);
            this.attachmentLinkControllerRadioButton.TabIndex = 0;
            this.attachmentLinkControllerRadioButton.Text = "Attachment controller";
            this.attachmentLinkControllerRadioButton.UseVisualStyleBackColor = true;
            this.attachmentLinkControllerRadioButton.CheckedChanged += new System.EventHandler(this.attachmentLinkControllerRadioButton_CheckedChanged);
            // 
            // attachmentLinkDataLabel
            // 
            this.attachmentLinkDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentLinkDataLabel.AutoSize = true;
            this.attachmentLinkDataLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.attachmentLinkDataLabel.Location = new System.Drawing.Point(3, 71);
            this.attachmentLinkDataLabel.Name = "attachmentLinkDataLabel";
            this.attachmentLinkDataLabel.Size = new System.Drawing.Size(71, 13);
            this.attachmentLinkDataLabel.TabIndex = 10;
            this.attachmentLinkDataLabel.Text = "DummyText";
            // 
            // attachmentLinkDataTextBox
            // 
            this.attachmentLinkDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.attachmentLinkDataTextBox, 2);
            this.attachmentLinkDataTextBox.Location = new System.Drawing.Point(80, 68);
            this.attachmentLinkDataTextBox.Name = "attachmentLinkDataTextBox";
            this.attachmentLinkDataTextBox.Size = new System.Drawing.Size(148, 20);
            this.attachmentLinkDataTextBox.TabIndex = 11;
            this.attachmentLinkDataTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.attachmentLinkDataTextBox_KeyPress);
            // 
            // attachmentLinkBrowseLinkedControllerButton
            // 
            this.attachmentLinkBrowseLinkedControllerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attachmentLinkBrowseLinkedControllerButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.attachmentLinkBrowseLinkedControllerButton.Location = new System.Drawing.Point(239, 66);
            this.attachmentLinkBrowseLinkedControllerButton.Name = "attachmentLinkBrowseLinkedControllerButton";
            this.attachmentLinkBrowseLinkedControllerButton.Size = new System.Drawing.Size(61, 23);
            this.attachmentLinkBrowseLinkedControllerButton.TabIndex = 12;
            this.attachmentLinkBrowseLinkedControllerButton.Text = "Browse...";
            this.attachmentLinkBrowseLinkedControllerButton.UseVisualStyleBackColor = true;
            this.attachmentLinkBrowseLinkedControllerButton.Click += new System.EventHandler(this.attachmentLinkBrowseLinkedControllerButton_Click);
            // 
            // attachmentLinkGenerateButton
            // 
            this.attachmentLinkGenerateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attachmentLinkGenerateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.attachmentLinkGenerateButton.Location = new System.Drawing.Point(311, 65);
            this.attachmentLinkGenerateButton.Margin = new System.Windows.Forms.Padding(0);
            this.attachmentLinkGenerateButton.Name = "attachmentLinkGenerateButton";
            this.attachmentLinkGenerateButton.Size = new System.Drawing.Size(75, 26);
            this.attachmentLinkGenerateButton.TabIndex = 13;
            this.attachmentLinkGenerateButton.Text = "Link!";
            this.attachmentLinkGenerateButton.UseVisualStyleBackColor = true;
            this.attachmentLinkGenerateButton.Click += new System.EventHandler(this.attachmentLinkGenerateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creation";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.attachmentCreationBaseComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.attachmentCreationDlcSlotComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.attachmentCreationGmoFileTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.attachmentCreationGenerateButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(389, 122);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DLC Slot";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "GMO File";
            // 
            // attachmentCreationBaseComboBox
            // 
            this.attachmentCreationBaseComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentCreationBaseComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.attachmentCreationBaseComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel1.SetColumnSpan(this.attachmentCreationBaseComboBox, 2);
            this.attachmentCreationBaseComboBox.FormattingEnabled = true;
            this.attachmentCreationBaseComboBox.Location = new System.Drawing.Point(80, 5);
            this.attachmentCreationBaseComboBox.Name = "attachmentCreationBaseComboBox";
            this.attachmentCreationBaseComboBox.Size = new System.Drawing.Size(148, 21);
            this.attachmentCreationBaseComboBox.TabIndex = 3;
            this.attachmentCreationBaseComboBox.SelectedIndexChanged += new System.EventHandler(this.attachmentCreationBaseComboBox_SelectedIndexChanged);
            this.attachmentCreationBaseComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.attachmentCreationBaseComboBox_Validating);
            // 
            // attachmentCreationDlcSlotComboBox
            // 
            this.attachmentCreationDlcSlotComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentCreationDlcSlotComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.attachmentCreationDlcSlotComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel1.SetColumnSpan(this.attachmentCreationDlcSlotComboBox, 2);
            this.attachmentCreationDlcSlotComboBox.FormattingEnabled = true;
            this.attachmentCreationDlcSlotComboBox.Location = new System.Drawing.Point(80, 36);
            this.attachmentCreationDlcSlotComboBox.Name = "attachmentCreationDlcSlotComboBox";
            this.attachmentCreationDlcSlotComboBox.Size = new System.Drawing.Size(148, 21);
            this.attachmentCreationDlcSlotComboBox.TabIndex = 4;
            this.attachmentCreationDlcSlotComboBox.SelectedIndexChanged += new System.EventHandler(this.attachmentCreationDlcSlotComboBox_SelectedIndexChanged);
            this.attachmentCreationDlcSlotComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.attachmentCreationDlcSlotComboBox_Validating);
            // 
            // attachmentCreationGmoFileTextBox
            // 
            this.attachmentCreationGmoFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.attachmentCreationGmoFileTextBox, 2);
            this.attachmentCreationGmoFileTextBox.Enabled = false;
            this.attachmentCreationGmoFileTextBox.Location = new System.Drawing.Point(80, 67);
            this.attachmentCreationGmoFileTextBox.Name = "attachmentCreationGmoFileTextBox";
            this.attachmentCreationGmoFileTextBox.Size = new System.Drawing.Size(148, 20);
            this.attachmentCreationGmoFileTextBox.TabIndex = 5;
            // 
            // attachmentCreationGenerateButton
            // 
            this.attachmentCreationGenerateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attachmentCreationGenerateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.attachmentCreationGenerateButton.Location = new System.Drawing.Point(157, 96);
            this.attachmentCreationGenerateButton.Name = "attachmentCreationGenerateButton";
            this.attachmentCreationGenerateButton.Size = new System.Drawing.Size(71, 25);
            this.attachmentCreationGenerateButton.TabIndex = 7;
            this.attachmentCreationGenerateButton.Text = "Generate!";
            this.attachmentCreationGenerateButton.UseVisualStyleBackColor = true;
            this.attachmentCreationGenerateButton.Click += new System.EventHandler(this.attachmentCreationGenerateButton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.attachmentCreationBrowseGmoFileButton);
            this.panel3.Location = new System.Drawing.Point(231, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 31);
            this.panel3.TabIndex = 8;
            // 
            // attachmentCreationBrowseGmoFileButton
            // 
            this.attachmentCreationBrowseGmoFileButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.attachmentCreationBrowseGmoFileButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.attachmentCreationBrowseGmoFileButton.Location = new System.Drawing.Point(8, 2);
            this.attachmentCreationBrowseGmoFileButton.Name = "attachmentCreationBrowseGmoFileButton";
            this.attachmentCreationBrowseGmoFileButton.Size = new System.Drawing.Size(87, 25);
            this.attachmentCreationBrowseGmoFileButton.TabIndex = 6;
            this.attachmentCreationBrowseGmoFileButton.Text = "Browse...";
            this.attachmentCreationBrowseGmoFileButton.UseVisualStyleBackColor = true;
            this.attachmentCreationBrowseGmoFileButton.Click += new System.EventHandler(this.attachmentCreationBrowseGmoFileButton_Click);
            // 
            // MainFormAttachmentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MainFormAttachmentsUserControl";
            this.Size = new System.Drawing.Size(407, 278);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox attachmentLinkBaseControllerTextBox;
        private System.Windows.Forms.Button attachmentLinkBrowseCharacterControllerButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton attachmentLinkIdRadioButton;
        private System.Windows.Forms.RadioButton attachmentLinkControllerRadioButton;
        private System.Windows.Forms.Label attachmentLinkDataLabel;
        private System.Windows.Forms.TextBox attachmentLinkDataTextBox;
        private System.Windows.Forms.Button attachmentLinkBrowseLinkedControllerButton;
        private System.Windows.Forms.Button attachmentLinkGenerateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox attachmentCreationBaseComboBox;
        private System.Windows.Forms.ComboBox attachmentCreationDlcSlotComboBox;
        private System.Windows.Forms.TextBox attachmentCreationGmoFileTextBox;
        private System.Windows.Forms.Button attachmentCreationGenerateButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button attachmentCreationBrowseGmoFileButton;
    }
}
