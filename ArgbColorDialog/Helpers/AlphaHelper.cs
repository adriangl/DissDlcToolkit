
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CutoutPro.Winforms.Helpers
{
	/// <summary>
	/// Description of AlphaHelper.
	/// </summary>
	public class AlphaHelper
	{
		private ArgbColorControl m_control;
		private System.Globalization.CultureInfo c = System.Globalization.CultureInfo.InvariantCulture;
		
		public void Step1_SetArgbColorControl(ArgbColorControl control)
		{
			m_control = control;
		}
		
		private void MakeBufferSameSizeAsControl()
		{
			PictureBox alpha = m_control.alpha;
			Bitmap buffer = m_control.AlphaBuffer;
			if (buffer != null && buffer.Width == alpha.Width && buffer.Height == alpha.Height) return;
			
			if (buffer != null) buffer.Dispose();
			m_control.AlphaBuffer = new Bitmap(alpha.Width, alpha.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
		}
		
		public void Step2_Paint(Graphics eg)
		{
			MakeBufferSameSizeAsControl();
			
			PictureBox alpha = m_control.alpha;
			Bitmap alphaBuffer = m_control.AlphaBuffer;
			Color selectedColor = m_control.Color;
			ColorDialogSettings settings = m_control.Settings;
			
			Graphics g = Graphics.FromImage(alphaBuffer);
			g.Clear(Color.Transparent);
			
			// Draw grid.
			int w = alpha.Width;
			int h = alpha.Height;
			int size = 8;
			for (int x = 0; x < w; x += size)
			{
				for (int y = 0; y < h; y += size)
				{
					if ((x+y)%(size*2) == 0)
					{
						g.FillRectangle(Brushes.LightGray, x, y, size, size);
					}
				}
			}
			
			for (int x = 0; x < w; x++)
			{
				float f = (float)x/w;
				Color color = Color.FromArgb((int)(f*255), selectedColor);
				g.DrawLine(new Pen(color, 1), x, 0, x, h);
			}
			
			float alphaX = (int)(settings.AlphaValue*alpha.Width);
			ImageProcessing.Invert(new RectangleF(alphaX-6, 0, 6, h), alphaBuffer);
			
			eg.DrawImage(alphaBuffer, 0, 0);
		}
		
		public void Step2_AlphaTextChanged()
		{
			TextBox alphaTextBox = m_control.alphaTextBox;
			ColorDialogSettings settings = m_control.Settings;
			ToolTip tip = m_control.tip;
			PictureBox alpha = m_control.alpha;
			
			try
			{
				// Parse alue from alpha text box.
				int a = int.Parse(alphaTextBox.Text, c);
				if (a < 0 || a > 255)
					throw new Exception("Alpha must be in range 0 and 255");
				settings.AlphaValue = (float)a/255f;
				alphaTextBox.BackColor = SystemColors.Window;
				tip.SetToolTip(alphaTextBox, null);
				
				RefreshColorHelper helper = new RefreshColorHelper();
				helper.Step1_SetArgbColorControl(m_control);
				helper.Step2_ChangeColorCode(true);
				helper.Step3_Refresh();
			}
			catch (Exception ex)
			{
				alphaTextBox.BackColor = Color.Red;
				tip.SetToolTip(alphaTextBox, ex.Message);
			}
		}
	}
}
