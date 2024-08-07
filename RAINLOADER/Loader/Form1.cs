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

namespace RAINLOADER
{
    public partial class Loader : Form
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

        // Draggable Panel
        bool mouseDown;
        private Point offset;

        private Form activeForm = null;

        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlDescription.Controls.Add(ChildForm);
            pnlDescription.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        public void startgame()
        {
            // Games
            GUI.Games.CSGO CSGOUI = new GUI.Games.CSGO();
            GUI.Games.ROBLOX ROBLOXUI = new GUI.Games.ROBLOX();
            GUI.Games.BRAWLHALLA BRAWLHALLAUI = new GUI.Games.BRAWLHALLA();

            // Check lblGame game status
            if (lblGameSelections.Text == "csgo")
            {
                CSGOUI.Show();
                this.Hide();
            }
            else if (lblGameSelections.Text == "roblox")
            {
                ROBLOXUI.Show();
                this.Hide();
            }
            else if (lblGameSelections.Text == "brawlhalla")
            {
                BRAWLHALLAUI.Show();
                this.Hide();
            }
        }

        public Loader()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            btnStart.BringToFront();
        }

        private void btnCSGO_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.Descriptions.CSGO());
            lblGameSelections.Text = "csgo";
            btnStart.BringToFront();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.Descriptions.ROBLOX_Description());
            lblGameSelections.Text = "roblox";
            btnStart.BringToFront();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.Descriptions.BRAWLHALLA_Description());
            lblGameSelections.Text = "brawlhalla";
            btnStart.BringToFront();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startgame();
        }

        private void pnlSelection_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - offset.X, currentPos.Y - offset.Y);
            }
        }

        private void pnlSelection_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void pnlSelection_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
