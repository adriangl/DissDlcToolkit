namespace DissDlcToolkit.Forms
{
    partial class MainFormDlcReporterUserControl
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.reporterLoadFolderButton = new System.Windows.Forms.Button();
            this.reporterDataTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reporterSaveToTextButton = new System.Windows.Forms.Button();
            this.reporterSaveToExcelButton = new System.Windows.Forms.Button();
            this.reporterFolderLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel3.Controls.Add(this.reporterLoadFolderButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.reporterDataTextBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.reporterFolderLabel, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.78F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(401, 272);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // reporterLoadFolderButton
            // 
            this.reporterLoadFolderButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.reporterLoadFolderButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.reporterLoadFolderButton.Location = new System.Drawing.Point(3, 3);
            this.reporterLoadFolderButton.Name = "reporterLoadFolderButton";
            this.reporterLoadFolderButton.Size = new System.Drawing.Size(97, 23);
            this.reporterLoadFolderButton.TabIndex = 21;
            this.reporterLoadFolderButton.Text = "Load DLC folder";
            this.reporterLoadFolderButton.UseVisualStyleBackColor = true;
            this.reporterLoadFolderButton.Click += new System.EventHandler(this.reporterLoadFolderButton_Click);
            // 
            // reporterDataTextBox
            // 
            this.reporterDataTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel3.SetColumnSpan(this.reporterDataTextBox, 3);
            this.reporterDataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporterDataTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporterDataTextBox.Location = new System.Drawing.Point(3, 33);
            this.reporterDataTextBox.Multiline = true;
            this.reporterDataTextBox.Name = "reporterDataTextBox";
            this.reporterDataTextBox.ReadOnly = true;
            this.reporterDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reporterDataTextBox.Size = new System.Drawing.Size(395, 205);
            this.reporterDataTextBox.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reporterSaveToTextButton);
            this.panel1.Controls.Add(this.reporterSaveToExcelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(104, 241);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 31);
            this.panel1.TabIndex = 23;
            // 
            // reporterSaveToTextButton
            // 
            this.reporterSaveToTextButton.Enabled = false;
            this.reporterSaveToTextButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.reporterSaveToTextButton.Location = new System.Drawing.Point(105, 2);
            this.reporterSaveToTextButton.Name = "reporterSaveToTextButton";
            this.reporterSaveToTextButton.Size = new System.Drawing.Size(87, 26);
            this.reporterSaveToTextButton.TabIndex = 1;
            this.reporterSaveToTextButton.Text = "Export to text";
            this.reporterSaveToTextButton.UseVisualStyleBackColor = true;
            this.reporterSaveToTextButton.Click += new System.EventHandler(this.reporterSaveToTextButton_Click);
            // 
            // reporterSaveToExcelButton
            // 
            this.reporterSaveToExcelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reporterSaveToExcelButton.Enabled = false;
            this.reporterSaveToExcelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.reporterSaveToExcelButton.Location = new System.Drawing.Point(0, 2);
            this.reporterSaveToExcelButton.Name = "reporterSaveToExcelButton";
            this.reporterSaveToExcelButton.Size = new System.Drawing.Size(87, 26);
            this.reporterSaveToExcelButton.TabIndex = 0;
            this.reporterSaveToExcelButton.Text = "Export to Excel";
            this.reporterSaveToExcelButton.UseVisualStyleBackColor = true;
            this.reporterSaveToExcelButton.Click += new System.EventHandler(this.reporterSaveToExcelButton_Click);
            // 
            // reporterFolderLabel
            // 
            this.reporterFolderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reporterFolderLabel.AutoEllipsis = true;
            this.tableLayoutPanel3.SetColumnSpan(this.reporterFolderLabel, 2);
            this.reporterFolderLabel.Location = new System.Drawing.Point(107, 8);
            this.reporterFolderLabel.Name = "reporterFolderLabel";
            this.reporterFolderLabel.Size = new System.Drawing.Size(291, 13);
            this.reporterFolderLabel.TabIndex = 24;
            // 
            // MainFormDlcReporterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "MainFormDlcReporterUserControl";
            this.Size = new System.Drawing.Size(407, 278);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button reporterLoadFolderButton;
        private System.Windows.Forms.TextBox reporterDataTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reporterSaveToTextButton;
        private System.Windows.Forms.Button reporterSaveToExcelButton;
        private System.Windows.Forms.Label reporterFolderLabel;
    }
}
