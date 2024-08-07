using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAINLOADER.GUI.Games.Subpanels.CSGO
{
    public partial class Misc : Form
    {
        public Misc()
        {
            InitializeComponent();
        }

        private void lblRecoil_Click(object sender, EventArgs e)
        {
            lblRecoil.ForeColor = Color.FromArgb(230, 35, 69);
            lblChatspammer.ForeColor = Color.White;
            lblLagSwitch.ForeColor = Color.White;
            pnlSelection.Location = new Point(41, 96);
        }

        private void lblChatspammer_Click(object sender, EventArgs e)
        {
            lblRecoil.ForeColor = Color.White;
            lblChatspammer.ForeColor = Color.FromArgb(230, 35, 69);
            lblLagSwitch.ForeColor = Color.White;
            pnlSelection.Location = new Point(155, 96);
        }

        private void lblLagSwitch_Click(object sender, EventArgs e)
        {
            lblRecoil.ForeColor = Color.White;
            lblChatspammer.ForeColor = Color.White;
            lblLagSwitch.ForeColor = Color.FromArgb(230, 35, 69);
            pnlSelection.Location = new Point(279, 96);
        }

        private void checkChatSpammer_CheckedChanged(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\alexa\\Desktop\\LIGHTNINGWARE\\Bin\\Scripts\\Chat Spammer.ahk");
        }
    }
}
