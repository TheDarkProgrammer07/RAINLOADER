namespace RAINLOADER.GUI.Games.Subpanels.CSGO
{
    partial class Visuals
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
            this.lblFeature = new System.Windows.Forms.Label();
            this.lblWorld = new System.Windows.Forms.Label();
            this.lblChams = new System.Windows.Forms.Label();
            this.lblESP = new System.Windows.Forms.Label();
            this.pnlSelection = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblFeature
            // 
            this.lblFeature.AutoSize = true;
            this.lblFeature.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeature.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFeature.Location = new System.Drawing.Point(34, 30);
            this.lblFeature.Name = "lblFeature";
            this.lblFeature.Size = new System.Drawing.Size(72, 24);
            this.lblFeature.TabIndex = 1;
            this.lblFeature.Text = "Visuals";
            // 
            // lblWorld
            // 
            this.lblWorld.AutoSize = true;
            this.lblWorld.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorld.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWorld.Location = new System.Drawing.Point(222, 74);
            this.lblWorld.Name = "lblWorld";
            this.lblWorld.Size = new System.Drawing.Size(49, 19);
            this.lblWorld.TabIndex = 6;
            this.lblWorld.Text = "World";
            this.lblWorld.Click += new System.EventHandler(this.lblWorld_Click);
            // 
            // lblChams
            // 
            this.lblChams.AutoSize = true;
            this.lblChams.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChams.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChams.Location = new System.Drawing.Point(126, 74);
            this.lblChams.Name = "lblChams";
            this.lblChams.Size = new System.Drawing.Size(55, 19);
            this.lblChams.TabIndex = 5;
            this.lblChams.Text = "Chams";
            this.lblChams.Click += new System.EventHandler(this.lblChams_Click);
            // 
            // lblESP
            // 
            this.lblESP.AutoSize = true;
            this.lblESP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblESP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.lblESP.Location = new System.Drawing.Point(52, 74);
            this.lblESP.Name = "lblESP";
            this.lblESP.Size = new System.Drawing.Size(37, 19);
            this.lblESP.TabIndex = 4;
            this.lblESP.Text = "ESP";
            this.lblESP.Click += new System.EventHandler(this.lblESP_Click);
            // 
            // pnlSelection
            // 
            this.pnlSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.pnlSelection.Location = new System.Drawing.Point(45, 96);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(54, 1);
            this.pnlSelection.TabIndex = 7;
            // 
            // Visuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(605, 594);
            this.Controls.Add(this.pnlSelection);
            this.Controls.Add(this.lblWorld);
            this.Controls.Add(this.lblChams);
            this.Controls.Add(this.lblESP);
            this.Controls.Add(this.lblFeature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Visuals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visuals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.Label lblWorld;
        private System.Windows.Forms.Label lblChams;
        private System.Windows.Forms.Label lblESP;
        private System.Windows.Forms.Panel pnlSelection;
    }
}