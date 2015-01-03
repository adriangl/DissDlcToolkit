using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DissDlcToolkit.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, 
                "http://dissidiaforums.com/showthread.php?16404-DDFF-DLC-Toolkit-All-in-one-DLC-generation-edition-tool!");
            linkLabel2.Links.Add(0, linkLabel2.Text.Length,
                "https://github.com/adriangl/DissDlcToolkit");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openLink(e);
        }       

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openLink(e);
        }

        private static void openLink(LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
