
using System;
using System.Windows.Forms;

namespace CutoutPro.Winforms.Helpers
{
	/// <summary>
	/// Description of RefreshColorHelper.
	/// </summary>
	public class RefreshColorHelper
	{
		public RefreshColorHelper()
		{
		}
		
		private ArgbColorControl m_control;
		private bool m_changeColorCode = false;
		private bool m_changeAlpha = false;
		
		public void Step1_SetArgbColorControl(ArgbColorControl control)
		{
			m_control = control;
		}
		
		public void Step2_ChangeColorCode(bool yes)
		{
			m_changeColorCode = yes;
		}
		
		public void Step2_ChangeAlpha(bool yes)
		{
			m_changeAlpha = yes;
		}
		
		public void Step3_Refresh()
		{
			if (m_changeColorCode)
			{
				// Prevent sending event in loop.
				bool send = m_control.SendColorCodeChanged;
				m_control.SendColorCodeChanged = false;
				m_control.code.Text = Utils.HexStringFromArgbColor(m_control.Color);
				m_control.SendColorCodeChanged = send;
			}
			
			if (m_changeAlpha)
			{
				// Prevents sending event in loop.
				bool send = m_control.SendAlphaChanged;
				m_control.SendAlphaChanged = false;
				m_control.alphaTextBox.Text = m_control.Color.A.ToString();
				m_control.SendAlphaChanged = send;
			}
			
			m_control.hsvBox.Refresh();
			m_control.brightness.Refresh();
			m_control.alpha.Refresh();
			m_control.ProcessSelectedColorChanged();
		}
	}
}
