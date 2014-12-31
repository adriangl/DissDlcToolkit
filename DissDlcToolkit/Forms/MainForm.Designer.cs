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
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabHostMain = new System.Windows.Forms.TabControl();
            this.tabDlcGen = new System.Windows.Forms.TabPage();
            this.mainFormDlcGenUserControl1 = new DissDlcToolkit.Forms.MainFormDlcGenUserControl();
            this.tabExex = new System.Windows.Forms.TabPage();
            this.mainFormExexUserControl1 = new DissDlcToolkit.Forms.MainFormExexUserControl();
            this.tabReporter = new System.Windows.Forms.TabPage();
            this.mainFormDlcReporterUserControl1 = new DissDlcToolkit.Forms.MainFormDlcReporterUserControl();
            this.menuStrip1.SuspendLayout();
            this.tabHostMain.SuspendLayout();
            this.tabDlcGen.SuspendLayout();
            this.tabExex.SuspendLayout();
            this.tabReporter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabHostMain
            // 
            this.tabHostMain.Controls.Add(this.tabDlcGen);
            this.tabHostMain.Controls.Add(this.tabExex);
            this.tabHostMain.Controls.Add(this.tabReporter);
            resources.ApplyResources(this.tabHostMain, "tabHostMain");
            this.tabHostMain.Name = "tabHostMain";
            this.tabHostMain.SelectedIndex = 0;
            // 
            // tabDlcGen
            // 
            this.tabDlcGen.Controls.Add(this.mainFormDlcGenUserControl1);
            resources.ApplyResources(this.tabDlcGen, "tabDlcGen");
            this.tabDlcGen.Name = "tabDlcGen";
            this.tabDlcGen.UseVisualStyleBackColor = true;
            // 
            // mainFormDlcGenUserControl1
            // 
            resources.ApplyResources(this.mainFormDlcGenUserControl1, "mainFormDlcGenUserControl1");
            this.mainFormDlcGenUserControl1.Name = "mainFormDlcGenUserControl1";
            // 
            // tabExex
            // 
            this.tabExex.Controls.Add(this.mainFormExexUserControl1);
            resources.ApplyResources(this.tabExex, "tabExex");
            this.tabExex.Name = "tabExex";
            this.tabExex.UseVisualStyleBackColor = true;
            // 
            // mainFormExexUserControl1
            // 
            resources.ApplyResources(this.mainFormExexUserControl1, "mainFormExexUserControl1");
            this.mainFormExexUserControl1.Name = "mainFormExexUserControl1";
            // 
            // tabReporter
            // 
            this.tabReporter.Controls.Add(this.mainFormDlcReporterUserControl1);
            resources.ApplyResources(this.tabReporter, "tabReporter");
            this.tabReporter.Name = "tabReporter";
            this.tabReporter.UseVisualStyleBackColor = true;
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
            this.tabExex.ResumeLayout(false);
            this.tabReporter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabHostMain;
        private System.Windows.Forms.TabPage tabDlcGen;
        private System.Windows.Forms.TabPage tabExex;
        private System.Windows.Forms.TabPage tabReporter;
        private Forms.MainFormDlcGenUserControl mainFormDlcGenUserControl1;
        private Forms.MainFormExexUserControl mainFormExexUserControl1;
        private Forms.MainFormDlcReporterUserControl mainFormDlcReporterUserControl1;

    }
}

