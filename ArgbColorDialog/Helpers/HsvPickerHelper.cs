
using System;
using System.Windows.Forms;
using System.Drawing;

namespace CutoutPro.Winforms.Helpers
{
	/// <summary>
	/// Make rendering and picking color from HSV area easier.
	/// </summary>
	public class HsvPickerHelper
	{
		private ArgbColorControl m_control;
		
		public HsvPickerHelper()
		{
		}
		
		public void Step1_SetArgbColorControl(ArgbColorControl control)
		{
			m_control = control;
		}
		
		public void Step2_SetHsv(float x, float y)
		{
			PictureBox hsvBox = m_control.hsvBox;
			ColorDialogSettings settings = m_control.Settings;
			TextBox brightnessTextBox = m_control.brightnessTextBox;
			PictureBox brightness = m_control.brightness;
			PictureBox alpha = m_control.alpha;
			
			x /= hsvBox.Width;
			y /= hsvBox.Height;
			x = x < 0 ? 0 : x > 1 ? 1 : x;
			y = y < 0 ? 0 : y > 1 ? 1 : y;
			settings.Hue = x*360;
			settings.Saturation = y;
			settings.Brightness = settings.Brightness == 0 ? 1 : settings.Brightness;
			brightnessTextBox.Text = ((int)(settings.Brightness*255)).ToString();
			
			RefreshColorHelper helper = new RefreshColorHelper();
			helper.Step1_SetArgbColorControl(m_control);
			helper.Step2_ChangeColorCode(true);
			helper.Step3_Refresh();
		}
	}
}
