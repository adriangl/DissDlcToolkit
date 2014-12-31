
using System;
using System.Drawing;
using System.Windows.Forms;
using CutoutPro.Winforms.Helpers;

namespace CutoutPro.Winforms
{
	/// <summary>
	/// Description of ArgbColorDialog.
	/// </summary>
	public partial class ArgbColorControl : UserControl
	{
		public ArgbColorControl()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			#region "Preset color event setup"
			// c1x1 is already set.
			c1x2.Click += C1x1Click;
			c1x3.Click += C1x1Click;
			c1x4.Click += C1x1Click;
			c1x5.Click += C1x1Click;
			c1x6.Click += C1x1Click;
			
			c2x1.Click += C1x1Click;
			c2x2.Click += C1x1Click;
			c2x3.Click += C1x1Click;
			c2x4.Click += C1x1Click;
			c2x5.Click += C1x1Click;
			c2x6.Click += C1x1Click;
			
			c3x1.Click += C1x1Click;
			c3x2.Click += C1x1Click;
			c3x3.Click += C1x1Click;
			c3x4.Click += C1x1Click;
			c3x5.Click += C1x1Click;
			c3x6.Click += C1x1Click;
			
			c4x1.Click += C1x1Click;
			c4x2.Click += C1x1Click;
			c4x3.Click += C1x1Click;
			c4x4.Click += C1x1Click;
			c4x5.Click += C1x1Click;
			c4x6.Click += C1x1Click;
			
			c5x1.Click += C1x1Click;
			c5x2.Click += C1x1Click;
			c5x3.Click += C1x1Click;
			c5x4.Click += C1x1Click;
			c5x5.Click += C1x1Click;
			c5x6.Click += C1x1Click;
			
			c6x1.Click += C1x1Click;
			c6x2.Click += C1x1Click;
			c6x3.Click += C1x1Click;
			c6x4.Click += C1x1Click;
			c6x5.Click += C1x1Click;
			c6x6.Click += C1x1Click;
			
			c7x1.Click += C1x1Click;
			c7x2.Click += C1x1Click;
			c7x3.Click += C1x1Click;
			c7x4.Click += C1x1Click;
			c7x5.Click += C1x1Click;
			c7x6.Click += C1x1Click;
			
			c8x1.Click += C1x1Click;
			c8x2.Click += C1x1Click;
			c8x3.Click += C1x1Click;
			c8x4.Click += C1x1Click;
			c8x5.Click += C1x1Click;
			c8x6.Click += C1x1Click;
			#endregion
		}
		
		private ColorDialogSettings m_settings = new ColorDialogSettings();
		private Bitmap m_alphaBuffer = null;
		private Bitmap m_brightnessBuffer = null;
		private Bitmap m_hsvBuffer = null;
		private bool m_sendColorCodeChanged = true;
		private bool m_sendAlphaChanged = true;
		
		private Form m_oldParent = null;
		
		public event EventHandler SelectedColorChanged;
		
		/// <summary>
		/// When set to true, the color code text box sends events.
		/// </summary>
		public bool SendColorCodeChanged
		{
			get
			{
				return m_sendColorCodeChanged;
			}
			set
			{
				m_sendColorCodeChanged = value;
			}
		}
		
		/// <summary>
		/// When set to true, the alpha text box sends events.
		/// </summary>
		public bool SendAlphaChanged
		{
			get
			{
				return m_sendAlphaChanged;
			}
			set
			{
				m_sendAlphaChanged = value;
			}
		}
		
		public ColorDialogSettings Settings
		{
			get 
			{
				return m_settings;
			}
			set
			{
				m_settings = value;
			}
		}
		
		public void ProcessSelectedColorChanged()
		{
			if (this.SelectedColorChanged != null) SelectedColorChanged(this, new EventArgs());
		}
		
		void CancelButtonClick(object sender, EventArgs e)
		{
		}
		
		void OkButtonClick(object sender, EventArgs e)
		{
		}
	
		public Color Color
		{
			get
			{
				return Color.FromArgb((int)(this.m_settings.AlphaValue*255), Utils.ColorFromHSV(m_settings.Hue, m_settings.Saturation, m_settings.Brightness));
			}
			set
			{
				m_settings.SetColor(value);
				
				this.alphaTextBox.Text = ((int)(m_settings.AlphaValue*255)).ToString();
				this.brightnessTextBox.Text = ((int)(m_settings.Brightness*255)).ToString();
			}
		}
		
		public Bitmap AlphaBuffer
		{
			get
			{
				return m_alphaBuffer;
			}
			set
			{
				m_alphaBuffer = value;
			}
		}
		
		public Bitmap BrightnessBuffer
		{
			get
			{
				return m_brightnessBuffer;
			}
			set
			{
				m_brightnessBuffer = value;
			}
		}
		
		public Bitmap HsvBuffer
		{
			get
			{
				return m_hsvBuffer;
			}
			set
			{
				m_hsvBuffer = value;
			}
		}
		
		void AlphaPaint(object sender, PaintEventArgs e)
		{
			AlphaHelper helper = new AlphaHelper();
			helper.Step1_SetArgbColorControl(this);
			helper.Step2_Paint(e.Graphics);
		}
		
		void AlphaMouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				AlphaValue = (float)e.X/alpha.Width;
				alpha.Refresh();
			}
		}
		
		void AlphaMouseUp(object sender, MouseEventArgs e)
		{
		}
		
		private float AlphaValue
		{
			get
			{
				return m_settings.AlphaValue;
			}
			set
			{
				m_settings.AlphaValue = value < 0 ? 0 : value > 1 ? 1 : value;
				alphaTextBox.Text = ((int)(m_settings.AlphaValue*255)).ToString();
				alphaTextBox.BackColor = SystemColors.Window;
				tip.SetToolTip(alphaTextBox, null);
				if (this.SelectedColorChanged != null)
					this.SelectedColorChanged(this, new EventArgs());
			}
		}
		
		void AlphaMouseDown(object sender, MouseEventArgs e)
		{
			AlphaValue = (float)e.X/alpha.Width;
			alpha.Refresh();
		}
		
		void AlphaTextBoxTextChanged(object sender, EventArgs e)
		{
			if (!m_sendAlphaChanged) return;
			
			AlphaHelper helper = new AlphaHelper();
			helper.Step1_SetArgbColorControl(this);
			helper.Step2_AlphaTextChanged();
		}
		
		void ArgbColorDialogKeyPress(object sender, KeyPressEventArgs e)
		{
		}
		
		void ArgbColorDialogResize(object sender, EventArgs e)
		{
			hsvBox.Refresh();
		}
		
		void HsvBoxPaint(object sender, PaintEventArgs e)
		{
			HsvPaintHelper helper = new HsvPaintHelper();
			helper.Step1_SetArgbColorControl(this);
			helper.Step2_Paint(e.Graphics);
		}
		
		void BrightnessPaint(object sender, PaintEventArgs e)
		{
			BrightnessHelper helper = new BrightnessHelper();
			helper.Step1_SetArgbControl(this);
			helper.Step2_PaintBrightness(e.Graphics);
		}
		
		private void SetBrightness(float x)
		{
			BrightnessHelper helper = new BrightnessHelper();
			helper.Step1_SetArgbControl(this);
			helper.Step2_ChangeByMousePos(x);
		}
		
		void BrightnessMouseDown(object sender, MouseEventArgs e)
		{
			SetBrightness(e.X);
		}
		
		void BrightnessMouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				SetBrightness(e.X);
			}
		}
		
		void BrightnessTextBoxTextChanged(object sender, EventArgs e)
		{
			BrightnessHelper helper = new BrightnessHelper();
			helper.Step1_SetArgbControl(this);
			helper.Step2_ChangedText();
		}
		
		// Users a helper class to do all the updates to the interface.
		private void SetHsv(float x, float y)
		{
			HsvPickerHelper helper = new HsvPickerHelper();
			helper.Step1_SetArgbColorControl(this);
			helper.Step2_SetHsv(x, y);
		}
		
		void HsvBoxMouseDown(object sender, MouseEventArgs e)
		{
			SetHsv(e.X, e.Y);
		}
		
		void HsvBoxMouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				SetHsv(e.X, e.Y);
			}
		}
		
		// Handles all colors.
		void C1x1Click(object sender, EventArgs e)
		{
			Label colorLabel = (Label)sender;
			this.Color = colorLabel.BackColor;
			
			RefreshColorHelper helper = new RefreshColorHelper();
			helper.Step1_SetArgbColorControl(this);
			helper.Step2_ChangeColorCode(true);
			helper.Step3_Refresh();
		}
		
		void CodeTextChanged(object sender, EventArgs e)
		{
			if (!m_sendColorCodeChanged) return;
			
			ColorCodeHelper helper = new ColorCodeHelper();
			helper.Step1_SetArgbColorControl(this);
			helper.debug_Step2_ColorCodeChanged();
		}
		
		void ParentFormClosing(object sender, EventArgs e)
		{
			// Release the image buffers.
			m_hsvBuffer.Dispose();
			m_hsvBuffer = null;
			m_alphaBuffer.Dispose();
			m_alphaBuffer = null;
			m_brightnessBuffer.Dispose();
			m_brightnessBuffer = null;
		}
		
		void ArgbColorControlParentChanged(object sender, EventArgs e)
		{
			// Remove event from old parent.
			if (m_oldParent != null) m_oldParent.FormClosing -= ParentFormClosing;
			
			// Link up event in new parent so we get message when it closes.
			m_oldParent = FindForm();
			
			if (m_oldParent != null) m_oldParent.FormClosing += ParentFormClosing;
		}
	}
}
