namespace ScottishGlen
{
    partial class LandingScreen
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
            this.landingScreenP1 = new System.Windows.Forms.Panel();
            this.landingScreenP2 = new System.Windows.Forms.Panel();
            this.loggedAssestsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // landingScreenP1
            // 
            this.landingScreenP1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.landingScreenP1.Dock = System.Windows.Forms.DockStyle.Left;
            this.landingScreenP1.Location = new System.Drawing.Point(0, 0);
            this.landingScreenP1.Name = "landingScreenP1";
            this.landingScreenP1.Size = new System.Drawing.Size(337, 822);
            this.landingScreenP1.TabIndex = 0;
            // 
            // landingScreenP2
            // 
            this.landingScreenP2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.landingScreenP2.Location = new System.Drawing.Point(336, 0);
            this.landingScreenP2.Name = "landingScreenP2";
            this.landingScreenP2.Size = new System.Drawing.Size(934, 104);
            this.landingScreenP2.TabIndex = 1;
            // 
            // loggedAssestsLabel
            // 
            this.loggedAssestsLabel.AutoSize = true;
            this.loggedAssestsLabel.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedAssestsLabel.Location = new System.Drawing.Point(622, 116);
            this.loggedAssestsLabel.Name = "loggedAssestsLabel";
            this.loggedAssestsLabel.Size = new System.Drawing.Size(366, 36);
            this.loggedAssestsLabel.TabIndex = 2;
            this.loggedAssestsLabel.Text = "Current Logged Assets";
            // 
            // LandingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 822);
            this.Controls.Add(this.loggedAssestsLabel);
            this.Controls.Add(this.landingScreenP2);
            this.Controls.Add(this.landingScreenP1);
            this.Name = "LandingScreen";
            this.Text = "LandingScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel landingScreenP1;
        private System.Windows.Forms.Panel landingScreenP2;
        private System.Windows.Forms.Label loggedAssestsLabel;
    }
}