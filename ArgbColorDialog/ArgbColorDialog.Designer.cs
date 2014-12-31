
namespace CutoutPro.Winforms
{
	partial class ArgbColorDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArgbColorDialog));
			CutoutPro.Winforms.ColorDialogSettings colorDialogSettings1 = new CutoutPro.Winforms.ColorDialogSettings();
			this.argbColorControl1 = new CutoutPro.Winforms.ArgbColorControl();
			this.previewColor = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// argbColorControl1
			// 
			this.argbColorControl1.AlphaBuffer = ((System.Drawing.Bitmap)(resources.GetObject("argbColorControl1.AlphaBuffer")));
			this.argbColorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.argbColorControl1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.argbColorControl1.BrightnessBuffer = ((System.Drawing.Bitmap)(resources.GetObject("argbColorControl1.BrightnessBuffer")));
			this.argbColorControl1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.argbColorControl1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.argbColorControl1.HsvBuffer = ((System.Drawing.Bitmap)(resources.GetObject("argbColorControl1.HsvBuffer")));
			this.argbColorControl1.Location = new System.Drawing.Point(0, 0);
			this.argbColorControl1.Name = "argbColorControl1";
			this.argbColorControl1.SendColorCodeChanged = true;
			colorDialogSettings1.AlphaValue = 1F;
			colorDialogSettings1.Brightness = 0F;
			colorDialogSettings1.Hue = 0F;
			colorDialogSettings1.Saturation = 0F;
			this.argbColorControl1.Settings = colorDialogSettings1;
			this.argbColorControl1.Size = new System.Drawing.Size(362, 193);
			this.argbColorControl1.TabIndex = 0;
			this.argbColorControl1.SelectedColorChanged += new System.EventHandler(this.ArgbColorControl1SelectedColorChanged);
			// 
			// previewColor
			// 
			this.previewColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.previewColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.previewColor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.previewColor.Location = new System.Drawing.Point(6, 196);
			this.previewColor.Name = "previewColor";
			this.previewColor.Size = new System.Drawing.Size(350, 33);
			this.previewColor.TabIndex = 1;
			this.previewColor.Text = "Done";
			this.previewColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.previewColor.BackColorChanged += new System.EventHandler(this.PreviewColorBackColorChanged);
			this.previewColor.Click += new System.EventHandler(this.PreviewColorClick);
			// 
			// ArgbColorDialog
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(361, 237);
			this.Controls.Add(this.previewColor);
			this.Controls.Add(this.argbColorControl1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ArgbColorDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select Color";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label previewColor;
		private CutoutPro.Winforms.ArgbColorControl argbColorControl1;
	}
}
