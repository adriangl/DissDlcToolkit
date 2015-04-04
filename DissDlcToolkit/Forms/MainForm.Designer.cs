namespace DissDlcToolkit
{
    partial class MainForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabHostMain = new System.Windows.Forms.TabControl();
            this.tabDlcGen = new System.Windows.Forms.TabPage();
            this.mainFormDlcGenUserControl2 = new DissDlcToolkit.Forms.MainFormDlcGenUserControl();
            this.tabAttachments = new System.Windows.Forms.TabPage();
            this.mainFormAttachmentsUserControl2 = new DissDlcToolkit.Forms.MainFormAttachmentsUserControl();
            this.tabBgmGen = new System.Windows.Forms.TabPage();
            this.mainFormBgmGenUserControl2 = new DissDlcToolkit.Forms.MainFormBgmGenUserControl();
            this.tabSwap = new System.Windows.Forms.TabPage();
            this.mainFormSwapSlotsUserControl1 = new DissDlcToolkit.Forms.MainFormSwapSlotsUserControl();
            this.tabExex = new System.Windows.Forms.TabPage();
            this.mainFormExexUserControl3 = new DissDlcToolkit.Forms.MainFormExexUserControl();
            this.tabReporter = new System.Windows.Forms.TabPage();
            this.mainFormDlcReporterUserControl2 = new DissDlcToolkit.Forms.MainFormDlcReporterUserControl();
            this.mainFormDlcGenUserControl1 = new DissDlcToolkit.Forms.MainFormDlcGenUserControl();
            this.mainFormExexUserControl2 = new DissDlcToolkit.Forms.MainFormExexUserControl();
            this.mainFormExexUserControl1 = new DissDlcToolkit.Forms.MainFormExexUserControl();
            this.mainFormAttachmentsUserControl1 = new DissDlcToolkit.Forms.MainFormAttachmentsUserControl();
            this.mainFormBgmGenUserControl1 = new DissDlcToolkit.Forms.MainFormBgmGenUserControl();
            this.mainFormDlcReporterUserControl1 = new DissDlcToolkit.Forms.MainFormDlcReporterUserControl();
            this.menuStrip1.SuspendLayout();
            this.tabHostMain.SuspendLayout();
            this.tabDlcGen.SuspendLayout();
            this.tabAttachments.SuspendLayout();
            this.tabBgmGen.SuspendLayout();
            this.tabSwap.SuspendLayout();
            this.tabExex.SuspendLayout();
            this.tabReporter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            resources.ApplyResources(this.aboutToolStripMenuItem1, "aboutToolStripMenuItem1");
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // tabHostMain
            // 
            this.tabHostMain.Controls.Add(this.tabDlcGen);
            this.tabHostMain.Controls.Add(this.tabAttachments);
            this.tabHostMain.Controls.Add(this.tabBgmGen);
            this.tabHostMain.Controls.Add(this.tabSwap);
            this.tabHostMain.Controls.Add(this.tabExex);
            this.tabHostMain.Controls.Add(this.tabReporter);
            resources.ApplyResources(this.tabHostMain, "tabHostMain");
            this.tabHostMain.Name = "tabHostMain";
            this.tabHostMain.SelectedIndex = 0;
            // 
            // tabDlcGen
            // 
            this.tabDlcGen.Controls.Add(this.mainFormDlcGenUserControl2);
            resources.ApplyResources(this.tabDlcGen, "tabDlcGen");
            this.tabDlcGen.Name = "tabDlcGen";
            this.tabDlcGen.UseVisualStyleBackColor = true;
            // 
            // mainFormDlcGenUserControl2
            // 
            resources.ApplyResources(this.mainFormDlcGenUserControl2, "mainFormDlcGenUserControl2");
            this.mainFormDlcGenUserControl2.Name = "mainFormDlcGenUserControl2";
            // 
            // tabAttachments
            // 
            this.tabAttachments.Controls.Add(this.mainFormAttachmentsUserControl2);
            resources.ApplyResources(this.tabAttachments, "tabAttachments");
            this.tabAttachments.Name = "tabAttachments";
            this.tabAttachments.UseVisualStyleBackColor = true;
            // 
            // mainFormAttachmentsUserControl2
            // 
            resources.ApplyResources(this.mainFormAttachmentsUserControl2, "mainFormAttachmentsUserControl2");
            this.mainFormAttachmentsUserControl2.Name = "mainFormAttachmentsUserControl2";
            // 
            // tabBgmGen
            // 
            this.tabBgmGen.Controls.Add(this.mainFormBgmGenUserControl2);
            resources.ApplyResources(this.tabBgmGen, "tabBgmGen");
            this.tabBgmGen.Name = "tabBgmGen";
            this.tabBgmGen.UseVisualStyleBackColor = true;
            // 
            // mainFormBgmGenUserControl2
            // 
            resources.ApplyResources(this.mainFormBgmGenUserControl2, "mainFormBgmGenUserControl2");
            this.mainFormBgmGenUserControl2.Name = "mainFormBgmGenUserControl2";
            // 
            // tabSwap
            // 
            this.tabSwap.Controls.Add(this.mainFormSwapSlotsUserControl1);
            resources.ApplyResources(this.tabSwap, "tabSwap");
            this.tabSwap.Name = "tabSwap";
            this.tabSwap.UseVisualStyleBackColor = true;
            // 
            // mainFormSwapSlotsUserControl1
            // 
            resources.ApplyResources(this.mainFormSwapSlotsUserControl1, "mainFormSwapSlotsUserControl1");
            this.mainFormSwapSlotsUserControl1.Name = "mainFormSwapSlotsUserControl1";
            // 
            // tabExex
            // 
            this.tabExex.Controls.Add(this.mainFormExexUserControl3);
            resources.ApplyResources(this.tabExex, "tabExex");
            this.tabExex.Name = "tabExex";
            this.tabExex.UseVisualStyleBackColor = true;
            // 
            // mainFormExexUserControl3
            // 
            resources.ApplyResources(this.mainFormExexUserControl3, "mainFormExexUserControl3");
            this.mainFormExexUserControl3.Name = "mainFormExexUserControl3";
            // 
            // tabReporter
            // 
            this.tabReporter.Controls.Add(this.mainFormDlcReporterUserControl2);
            resources.ApplyResources(this.tabReporter, "tabReporter");
            this.tabReporter.Name = "tabReporter";
            this.tabReporter.UseVisualStyleBackColor = true;
            // 
            // mainFormDlcReporterUserControl2
            // 
            resources.ApplyResources(this.mainFormDlcReporterUserControl2, "mainFormDlcReporterUserControl2");
            this.mainFormDlcReporterUserControl2.Name = "mainFormDlcReporterUserControl2";
            // 
            // mainFormDlcGenUserControl1
            // 
            resources.ApplyResources(this.mainFormDlcGenUserControl1, "mainFormDlcGenUserControl1");
            this.mainFormDlcGenUserControl1.Name = "mainFormDlcGenUserControl1";
            // 
            // mainFormExexUserControl2
            // 
            resources.ApplyResources(this.mainFormExexUserControl2, "mainFormExexUserControl2");
            this.mainFormExexUserControl2.Name = "mainFormExexUserControl2";
            // 
            // mainFormExexUserControl1
            // 
            resources.ApplyResources(this.mainFormExexUserControl1, "mainFormExexUserControl1");
            this.mainFormExexUserControl1.Name = "mainFormExexUserControl1";
            // 
            // mainFormAttachmentsUserControl1
            // 
            resources.ApplyResources(this.mainFormAttachmentsUserControl1, "mainFormAttachmentsUserControl1");
            this.mainFormAttachmentsUserControl1.Name = "mainFormAttachmentsUserControl1";
            // 
            // mainFormBgmGenUserControl1
            // 
            resources.ApplyResources(this.mainFormBgmGenUserControl1, "mainFormBgmGenUserControl1");
            this.mainFormBgmGenUserControl1.Name = "mainFormBgmGenUserControl1";
            // 
            // mainFormDlcReporterUserControl1
            // 
            resources.ApplyResources(this.mainFormDlcReporterUserControl1, "mainFormDlcReporterUserControl1");
            this.mainFormDlcReporterUserControl1.Name = "mainFormDlcReporterUserControl1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabHostMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabHostMain.ResumeLayout(false);
            this.tabDlcGen.ResumeLayout(false);
            this.tabAttachments.ResumeLayout(false);
            this.tabBgmGen.ResumeLayout(false);
            this.tabSwap.ResumeLayout(false);
            this.tabExex.ResumeLayout(false);
            this.tabReporter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabHostMain;
        private System.Windows.Forms.TabPage tabDlcGen;
        private System.Windows.Forms.TabPage tabExex;
        private System.Windows.Forms.TabPage tabReporter;
        private Forms.MainFormDlcGenUserControl mainFormDlcGenUserControl1;
        private Forms.MainFormExexUserControl mainFormExexUserControl1;
        private Forms.MainFormDlcReporterUserControl mainFormDlcReporterUserControl1;
        private System.Windows.Forms.TabPage tabAttachments;
        private Forms.MainFormAttachmentsUserControl mainFormAttachmentsUserControl1;
        private System.Windows.Forms.TabPage tabBgmGen;
        private Forms.MainFormBgmGenUserControl mainFormBgmGenUserControl1;
        private Forms.MainFormExexUserControl mainFormExexUserControl2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabSwap;
        private Forms.MainFormDlcGenUserControl mainFormDlcGenUserControl2;
        private Forms.MainFormAttachmentsUserControl mainFormAttachmentsUserControl2;
        private Forms.MainFormBgmGenUserControl mainFormBgmGenUserControl2;
        private Forms.MainFormSwapSlotsUserControl mainFormSwapSlotsUserControl1;
        private Forms.MainFormExexUserControl mainFormExexUserControl3;
        private Forms.MainFormDlcReporterUserControl mainFormDlcReporterUserControl2;

    }
}

