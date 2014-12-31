
using System;
using System.Windows.Forms;
using System.Drawing;

namespace CutoutPro.Winforms.Helpers
{
	/// <summary>
	/// Description of HsvPaintHelper.
	/// </summary>
	public class HsvPaintHelper
	{
		private ArgbColorControl m_control;
		
		public void Step1_SetArgbColorControl(ArgbColorControl control)
		{
			m_control = control;
		}
		
		private void MakeBufferSameSizeAsPictureBox(out bool changed)
		{
			PictureBox hsvBox = m_control.hsvBox;
			Bitmap buffer = m_control.HsvBuffer;
			if (buffer != null && buffer.Width == hsvBox.Width && buffer.Height == hsvBox.Height) 
			{
				changed = false;
				return;
			}
			
			changed = true;
			if (buffer != null) buffer.Dispose();
			m_control.HsvBuffer = new Bitmap(hsvBox.Width, hsvBox.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
		}
		
		private void PreprocessBuffer()
		{
			Bitmap buffer = m_control.HsvBuffer;
			ImageProcessing.Hsv(new Rectangle(0, 0, buffer.Width, buffer.Height), buffer);
		}
		
		public void Step2_Paint(Graphics eg)
		{
			bool bufferChanged = false;
			MakeBufferSameSizeAsPictureBox(out bufferChanged);
			if (bufferChanged) PreprocessBuffer();
			
			eg.DrawImage(m_control.HsvBuffer, 0, 0);
			
			// Draw cross at top of buffer.
			float mx = m_control.Settings.Hue / 360;
			float my = m_control.Settings.Saturation;
			mx *= m_control.hsvBox.Width;
			my *= m_control.hsvBox.Height;
			eg.DrawLine(Pens.Black, mx-5, my, mx-1, my);
			eg.DrawLine(Pens.Black, mx, my-5, mx, my-1);
			eg.DrawLine(Pens.Black, mx+1, my, mx+5, my);
			eg.DrawLine(Pens.Black, mx, my+1, mx, my+5);
		}
	}
}
