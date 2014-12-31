
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CutoutPro.Winforms
{
	/// <summary>
	/// Contains the color dialog.
	/// </summary>
	public partial class ArgbColorDialog : Form
	{
		public ArgbColorDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			// this.Icon = AppIcon.StickmanIcon;
		}
		
		private Color m_color;
		private int[] m_customColors;
		
		public Color Color
		{
			get
			{return argbColorControl1.Color;}
			set
			{
				argbColorControl1.Color = value;
				previewColor.BackColor = Color.FromArgb(m_color.R, m_color.G, m_color.B);
			}
		}
		
		public bool FullOpen
		{
			get
			{return true;}
			set
			{}
		}
		
		
		public int[] CustomColors
		{
			get
			{return m_customColors;}
			set
			{m_customColors = value;}
		}
		
		public bool AnyColor
		{
			get
			{return true;}
			set
			{}
		}
		
		public bool SolidColorOnly
		{
			get
			{return false;}
			set
			{}
		}
		
		void ArgbColorControl1SelectedColorChanged(object sender, EventArgs e)
		{
			m_color = argbColorControl1.Color;
			previewColor.BackColor = Color.FromArgb(m_color.R, m_color.G, m_color.B);
		}
		
		void PreviewColorClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
		void PreviewColorBackColorChanged(object sender, EventArgs e)
		{
			Color backColor = this.previewColor.BackColor;
			float avg = (backColor.R+backColor.G+backColor.B)/3f;
			if (avg < 150)
				this.previewColor.ForeColor = Color.White;
			else
				this.previewColor.ForeColor = Color.Black;
		}
	}
}
