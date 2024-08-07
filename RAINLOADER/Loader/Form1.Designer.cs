namespace RAINLOADER
{
    partial class Loader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.lblGameSelections = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnCSGO = new FontAwesome.Sharp.IconButton();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new FontAwesome.Sharp.IconButton();
            this.ptbProfile = new RAINLOADER.Classes.roundedPicturebox();
            this.pnlSelection.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlSelection.Controls.Add(this.lblGameSelections);
            this.pnlSelection.Controls.Add(this.lblStatus);
            this.pnlSelection.Controls.Add(this.lblName);
            this.pnlSelection.Controls.Add(this.ptbProfile);
            this.pnlSelection.Controls.Add(this.lblLogo);
            this.pnlSelection.Controls.Add(this.iconButton2);
            this.pnlSelection.Controls.Add(this.iconButton1);
            this.pnlSelection.Controls.Add(this.btnCSGO);
            this.pnlSelection.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlSelection.Location = new System.Drawing.Point(0, 0);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(155, 473);
            this.pnlSelection.TabIndex = 0;
            this.pnlSelection.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSelection_MouseDown);
            this.pnlSelection.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSelection_MouseMove);
            this.pnlSelection.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlSelection_MouseUp);
            // 
            // lblGameSelections
            // 
            this.lblGameSelections.AutoSize = true;
            this.lblGameSelections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblGameSelections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblGameSelections.Location = new System.Drawing.Point(21, 393);
            this.lblGameSelections.Name = "lblGameSelections";
            this.lblGameSelections.Size = new System.Drawing.Size(33, 13);
            this.lblGameSelections.TabIndex = 9;
            this.lblGameSelections.Text = "game";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblStatus.Location = new System.Drawing.Point(68, 443);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 17);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Undetected";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.lblName.Location = new System.Drawing.Point(78, 423);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Lightning";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.lblLogo.Location = new System.Drawing.Point(4, 42);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(147, 24);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "RAINLO4DER";
            // 
            // iconButton2
            // 
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Worm;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(3, 209);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(152, 58);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "     BRAWLHALLA";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 151);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(152, 58);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "ROBLOX";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnCSGO
            // 
            this.btnCSGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSGO.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSGO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.btnCSGO.IconChar = FontAwesome.Sharp.IconChar.Gun;
            this.btnCSGO.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.btnCSGO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCSGO.IconSize = 35;
            this.btnCSGO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCSGO.Location = new System.Drawing.Point(3, 93);
            this.btnCSGO.Name = "btnCSGO";
            this.btnCSGO.Size = new System.Drawing.Size(152, 58);
            this.btnCSGO.TabIndex = 0;
            this.btnCSGO.Text = "CS:GO";
            this.btnCSGO.UseVisualStyleBackColor = true;
            this.btnCSGO.Click += new System.EventHandler(this.btnCSGO_Click);
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.pnlDescription.Controls.Add(this.pictureBox1);
            this.pnlDescription.Controls.Add(this.btnStart);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDescription.Location = new System.Drawing.Point(155, 0);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(533, 473);
            this.pnlDescription.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.btnStart.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnStart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.btnStart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStart.IconSize = 30;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(190, 415);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 45);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "LOAD";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ptbProfile
            // 
            this.ptbProfile.Image = ((System.Drawing.Image)(resources.GetObject("ptbProfile.Image")));
            this.ptbProfile.Location = new System.Drawing.Point(12, 409);
            this.ptbProfile.Name = "ptbProfile";
            this.ptbProfile.Size = new System.Drawing.Size(52, 52);
            this.ptbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProfile.TabIndex = 4;
            this.ptbProfile.TabStop = false;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(688, 473);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.pnlSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOADER";
            this.pnlSelection.ResumeLayout(false);
            this.pnlSelection.PerformLayout();
            this.pnlDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSelection;
        private FontAwesome.Sharp.IconButton btnCSGO;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lblLogo;
        private Classes.roundedPicturebox ptbProfile;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlDescription;
        private FontAwesome.Sharp.IconButton btnStart;
        private System.Windows.Forms.Label lblGameSelections;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

