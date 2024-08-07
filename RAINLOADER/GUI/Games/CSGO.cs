using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RAINLOADER.GUI.Games
{
    public partial class CSGO : Form
    {
        // Rounded Edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );

        private Form activeForm = null;

        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(ChildForm);
            pnlMain.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        public CSGO()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            OpenChildForm(new GUI.Games.Subpanels.CSGO.Legitbot());
        }

        private void btnVisuals_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.Games.Subpanels.CSGO.Visuals());
        }

        private void btnLegitBot_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.Games.Subpanels.CSGO.Legitbot());
            
            
        }

        private void btnSkins_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.Games.Subpanels.CSGO.Skins());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMisc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.Games.Subpanels.CSGO.Misc());
        }
    }
}
