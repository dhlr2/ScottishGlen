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
            this.headingLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mySystemMenuBtn = new System.Windows.Forms.Button();
            this.employeeMenuBtn = new System.Windows.Forms.Button();
            this.assetMenuBtn = new System.Windows.Forms.Button();
            this.addAssetBtn = new System.Windows.Forms.Button();
            this.listViewAssets = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headingLbl
            // 
            this.headingLbl.AutoSize = true;
            this.headingLbl.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLbl.Location = new System.Drawing.Point(706, 25);
            this.headingLbl.Name = "headingLbl";
            this.headingLbl.Size = new System.Drawing.Size(120, 36);
            this.headingLbl.TabIndex = 2;
            this.headingLbl.Text = "Assets";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.mySystemMenuBtn);
            this.panel2.Controls.Add(this.employeeMenuBtn);
            this.panel2.Controls.Add(this.assetMenuBtn);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 940);
            this.panel2.TabIndex = 3;
            // 
            // mySystemMenuBtn
            // 
            this.mySystemMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.mySystemMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.mySystemMenuBtn.FlatAppearance.BorderSize = 0;
            this.mySystemMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mySystemMenuBtn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mySystemMenuBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mySystemMenuBtn.Location = new System.Drawing.Point(0, 184);
            this.mySystemMenuBtn.Name = "mySystemMenuBtn";
            this.mySystemMenuBtn.Size = new System.Drawing.Size(260, 92);
            this.mySystemMenuBtn.TabIndex = 6;
            this.mySystemMenuBtn.Text = "My System";
            this.mySystemMenuBtn.UseVisualStyleBackColor = false;
            this.mySystemMenuBtn.Click += new System.EventHandler(this.mySystemMenuBtn_Click);
            this.mySystemMenuBtn.MouseEnter += new System.EventHandler(this.mySystemMenuBtn_MouseEnter);
            this.mySystemMenuBtn.MouseLeave += new System.EventHandler(this.mySystemMenuBtn_MouseLeave);
            // 
            // employeeMenuBtn
            // 
            this.employeeMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.employeeMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeMenuBtn.FlatAppearance.BorderSize = 0;
            this.employeeMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeMenuBtn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeMenuBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeMenuBtn.Location = new System.Drawing.Point(0, 92);
            this.employeeMenuBtn.Name = "employeeMenuBtn";
            this.employeeMenuBtn.Size = new System.Drawing.Size(260, 92);
            this.employeeMenuBtn.TabIndex = 5;
            this.employeeMenuBtn.Text = "Employees";
            this.employeeMenuBtn.UseVisualStyleBackColor = false;
            this.employeeMenuBtn.Click += new System.EventHandler(this.employeeMenuBtn_Click);
            this.employeeMenuBtn.MouseEnter += new System.EventHandler(this.employeeMenuBtn_MouseEnter);
            this.employeeMenuBtn.MouseLeave += new System.EventHandler(this.employeeMenuBtn_MouseLeave);
            // 
            // assetMenuBtn
            // 
            this.assetMenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.assetMenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.assetMenuBtn.FlatAppearance.BorderSize = 0;
            this.assetMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assetMenuBtn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetMenuBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.assetMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.assetMenuBtn.Name = "assetMenuBtn";
            this.assetMenuBtn.Size = new System.Drawing.Size(260, 92);
            this.assetMenuBtn.TabIndex = 4;
            this.assetMenuBtn.Text = "Assets";
            this.assetMenuBtn.UseVisualStyleBackColor = false;
            this.assetMenuBtn.Click += new System.EventHandler(this.assetMenuBtn_Click);
            this.assetMenuBtn.MouseEnter += new System.EventHandler(this.assetMenuBtn_MouseEnter);
            this.assetMenuBtn.MouseLeave += new System.EventHandler(this.assetMenuBtn_MouseLeave);
            // 
            // addAssetBtn
            // 
            this.addAssetBtn.Location = new System.Drawing.Point(640, 424);
            this.addAssetBtn.Name = "addAssetBtn";
            this.addAssetBtn.Size = new System.Drawing.Size(228, 73);
            this.addAssetBtn.TabIndex = 5;
            this.addAssetBtn.Text = "Add Asset";
            this.addAssetBtn.UseVisualStyleBackColor = true;
            this.addAssetBtn.Click += new System.EventHandler(this.addAssetBtn_Click);
            // 
            // listViewAssets
            // 
            this.listViewAssets.HideSelection = false;
            this.listViewAssets.Location = new System.Drawing.Point(285, 92);
            this.listViewAssets.Name = "listViewAssets";
            this.listViewAssets.Size = new System.Drawing.Size(957, 326);
            this.listViewAssets.TabIndex = 4;
            this.listViewAssets.UseCompatibleStateImageBehavior = false;
            this.listViewAssets.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // LandingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 935);
            this.Controls.Add(this.addAssetBtn);
            this.Controls.Add(this.listViewAssets);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.headingLbl);
            this.Name = "LandingScreen";
            this.Text = "LandingScreen";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label headingLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mySystemMenuBtn;
        private System.Windows.Forms.Button employeeMenuBtn;
        private System.Windows.Forms.Button assetMenuBtn;
        private System.Windows.Forms.Button addAssetBtn;
        private System.Windows.Forms.ListView listViewAssets;
    }
}