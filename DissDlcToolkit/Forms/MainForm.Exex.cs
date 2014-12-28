using CutoutPro.Winforms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DissDlcToolkit
{
    public partial class MainForm
    {
        /**
         * This partial class handles all callbacks from the
         * ".exex editing" tab
         */

        private void exexParticleColorPictureBox_Click(object sender, EventArgs e)
        {
            exexParticleColorPictureBox.BackColor = openColorDialog(exexParticleColorPictureBox.BackColor);
        }

        private void exexOuterGlowPictureBox_Click(object sender, EventArgs e)
        {
            exexOuterGlowPictureBox.BackColor = openColorDialog(exexOuterGlowPictureBox.BackColor);
        }

        private void exexInnerGlowPictureBox_Click(object sender, EventArgs e)
        {
            exexInnerGlowPictureBox.BackColor = openColorDialog(exexInnerGlowPictureBox.BackColor);
        }

        private void exexSmoke1PictureBox_Click(object sender, EventArgs e)
        {
        
        }

        private void exexSmoke2PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void exexBoltsPictureBox_Click(object sender, EventArgs e)
        {

        }


        private Color openColorDialog(Color currentColor)
        {
            ArgbColorDialog dialog = new ArgbColorDialog();
            // Sets the initial color select to the current text color.
            dialog.Color = currentColor;

            dialog.ShowDialog();

            // Update the text box color
            return dialog.Color;
        }

    }
}
