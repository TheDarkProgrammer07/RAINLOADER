using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAINLOADER.GUI.Games.Subpanels.CSGO
{
    public partial class Skins : Form
    {
        public Skins()
        {
            InitializeComponent();
        }

        private void lblSkinchanger_Click(object sender, EventArgs e)
        {
            lblSkinchanger.ForeColor = Color.FromArgb(230, 35, 69);
            lblSettings.ForeColor = Color.White;
            lblGlowSettings.ForeColor = Color.White;
            pnlSelection.Location = new Point(51, 96);
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            lblSkinchanger.ForeColor = Color.White;
            lblSettings.ForeColor = Color.FromArgb(230, 35, 69);
            lblGlowSettings.ForeColor = Color.White;
            pnlSelection.Location = new Point(160, 96);
        }

        private void lblGlowSettings_Click(object sender, EventArgs e)
        {
            lblSkinchanger.ForeColor = Color.White;
            lblSettings.ForeColor = Color.White;
            lblGlowSettings.ForeColor = Color.FromArgb(230, 35, 69);
            pnlSelection.Location = new Point(267, 96);
        }
    }
}
