namespace RAINLOADER.GUI.Descriptions
{
    partial class BRAWLHALLA_Description
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BRAWLHALLA_Description));
            this.lblGame = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.lblGame.Location = new System.Drawing.Point(168, 25);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(161, 24);
            this.lblGame.TabIndex = 6;
            this.lblGame.Text = "BRAWLHALLA";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(35)))), ((int)(((byte)(69)))));
            this.lblDescription.Location = new System.Drawing.Point(48, 75);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(464, 102);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // BRAWLHALLA_Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(517, 434);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BRAWLHALLA_Description";
            this.Text = "BRAWLHALLA_Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblDescription;
    }
}