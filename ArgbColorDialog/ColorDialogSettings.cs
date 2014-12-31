
using System;
using System.Drawing;

namespace CutoutPro.Winforms
{
	/// <summary>
	/// Contains color value in AHSV to prevent loosing information.
	/// </summary>
	public class ColorDialogSettings
	{
		private float m_alphaValue = 1;
		private float m_hue;
		private float m_saturation;
		private float m_brightness;
		
		public float AlphaValue
		{
			get
			{
				return m_alphaValue;
			}
			set 
			{
				m_alphaValue = value;
			}
		}
		
		public float Hue
		{
			get
			{
				return m_hue;
			}
			set
			{
				m_hue = value;
			}
		}
		
		public float Saturation
		{
			get
			{
				return m_saturation;
			}
			set
			{
				m_saturation = value;
			}
		}
		
		public float Brightness
		{
			get
			{
				return m_brightness;
			}
			set
			{
				m_brightness = value;
			}
		}
		
		public void SetColor(Color color)
		{
			double hue, saturation, brightness;
			Utils.ColorToHSV(color, out hue, out saturation, out brightness);
			this.m_hue = (float)hue;
			this.m_saturation = (float)saturation;
			this.m_brightness = (float)brightness;
			this.m_alphaValue = color.A/255f;
		}
	}
}
