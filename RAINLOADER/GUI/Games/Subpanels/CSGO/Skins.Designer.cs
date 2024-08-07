namespace RAINLOADER.GUI.Games.Subpanels.CSGO
{
    partial class Skins
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
            this.lblSkins = new System.Windows.Forms.Label();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.lblGlowSettings = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblSkinchanger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSkins
            // 
            this.lblSkins.AutoSize = true;
            this.lblSkins.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSkins.Location = new System.Drawing.Point(34, 30);
            this.lblSkins.Name = "lblSkins";
            this.lblSkins.Size = new System.Drawing.Size(57, 24);
            this.lblSkins.TabIndex = 1;
            this.lblSkins.Text = "Skins";
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.pnlSelection.Location = new System.Drawing.Point(51, 96);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(54, 1);
            this.pnlSelection.TabIndex = 8;
            // 
            // lblGlowSettings
            // 
            this.lblGlowSettings.AutoSize = true;
            this.lblGlowSettings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlowSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGlowSettings.Location = new System.Drawing.Point(245, 74);
            this.lblGlowSettings.Name = "lblGlowSettings";
            this.lblGlowSettings.Size = new System.Drawing.Size(101, 19);
            this.lblGlowSettings.TabIndex = 7;
            this.lblGlowSettings.Text = "Glow Settings";
            this.lblGlowSettings.Click += new System.EventHandler(this.lblGlowSettings_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSettings.Location = new System.Drawing.Point(156, 74);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(63, 19);
            this.lblSettings.TabIndex = 6;
            this.lblSettings.Text = "Settings";
            this.lblSettings.Click += new System.EventHandler(this.lblSettings_Click);
            // 
            // lblSkinchanger
            // 
            this.lblSkinchanger.AutoSize = true;
            this.lblSkinchanger.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkinchanger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.lblSkinchanger.Location = new System.Drawing.Point(34, 74);
            this.lblSkinchanger.Name = "lblSkinchanger";
            this.lblSkinchanger.Size = new System.Drawing.Size(92, 19);
            this.lblSkinchanger.TabIndex = 5;
            this.lblSkinchanger.Text = "Skinchanger";
            this.lblSkinchanger.Click += new System.EventHandler(this.lblSkinchanger_Click);
            // 
            // Skins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(589, 555);
            this.Controls.Add(this.pnlSelection);
            this.Controls.Add(this.lblGlowSettings);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblSkinchanger);
            this.Controls.Add(this.lblSkins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Skins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSkins;
        private System.Windows.Forms.Panel pnlSelection;
        private System.Windows.Forms.Label lblGlowSettings;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblSkinchanger;
    }
}