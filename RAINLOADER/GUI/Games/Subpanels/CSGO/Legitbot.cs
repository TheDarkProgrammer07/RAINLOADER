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
    public partial class Legitbot : Form
    {
        private Process autoshootProcess;

        public Legitbot()
        {
            InitializeComponent();
        }

        private void lblAimbot_Click(object sender, EventArgs e)
        {
            lblAimbot.ForeColor = Color.FromArgb(230, 35, 69);
            lblTriggerbot.ForeColor = Color.White;
            lblCrosshair.ForeColor = Color.White;
            pnlSelection.Location = new Point(45, 96);
        }

        private void lblTriggerbot_Click(object sender, EventArgs e)
        {
            lblAimbot.ForeColor = Color.White;
            lblTriggerbot.ForeColor = Color.FromArgb(230, 35, 69);
            lblCrosshair.ForeColor = Color.White;
            pnlSelection.Location = new Point(128, 96);
        }

        private void lblCrosshair_Click(object sender, EventArgs e)
        {
            lblAimbot.ForeColor = Color.White;
            lblTriggerbot.ForeColor = Color.White;
            lblCrosshair.ForeColor = Color.FromArgb(230, 35, 69);
            pnlSelection.Location = new Point(221, 96);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkAutoshoot_CheckedChanged(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\alexa\\Desktop\\LIGHTNINGWARE\\Bin\\Scripts\\Triggerbot by Secret_Ninkjeboi.ahk");
        }

        private void checkCustomcrosshair_CheckedChanged(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\alexa\\Desktop\\LIGHTNINGWARE\\Bin\\Scripts\\Crosshair Script.ahk");
        }
    }
}
