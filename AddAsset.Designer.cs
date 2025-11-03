namespace ScottishGlen
{
    partial class AddAsset
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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.assetNameTxtBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.employeeIdTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.notesTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmAssetBtn = new System.Windows.Forms.Button();
            this.purchaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.assetNameTxtBox);
            this.panel4.Location = new System.Drawing.Point(15, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(784, 75);
            this.panel4.TabIndex = 10;
            // 
            // assetNameTxtBox
            // 
            this.assetNameTxtBox.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetNameTxtBox.Location = new System.Drawing.Point(19, 17);
            this.assetNameTxtBox.Name = "assetNameTxtBox";
            this.assetNameTxtBox.Size = new System.Drawing.Size(754, 45);
            this.assetNameTxtBox.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Controls.Add(this.employeeIdTxtBox);
            this.panel6.Location = new System.Drawing.Point(15, 323);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(784, 75);
            this.panel6.TabIndex = 13;
            // 
            // employeeIdTxtBox
            // 
            this.employeeIdTxtBox.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdTxtBox.Location = new System.Drawing.Point(19, 17);
            this.employeeIdTxtBox.Name = "employeeIdTxtBox";
            this.employeeIdTxtBox.Size = new System.Drawing.Size(754, 45);
            this.employeeIdTxtBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // notesTxtBox
            // 
            this.notesTxtBox.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTxtBox.Location = new System.Drawing.Point(15, 453);
            this.notesTxtBox.Multiline = true;
            this.notesTxtBox.Name = "notesTxtBox";
            this.notesTxtBox.Size = new System.Drawing.Size(784, 241);
            this.notesTxtBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // confirmAssetBtn
            // 
            this.confirmAssetBtn.Location = new System.Drawing.Point(929, 502);
            this.confirmAssetBtn.Name = "confirmAssetBtn";
            this.confirmAssetBtn.Size = new System.Drawing.Size(239, 141);
            this.confirmAssetBtn.TabIndex = 18;
            this.confirmAssetBtn.Text = "Confirm";
            this.confirmAssetBtn.UseVisualStyleBackColor = true;
            this.confirmAssetBtn.Click += new System.EventHandler(this.confirmAssetBtn_Click);
            // 
            // purchaseDatePicker
            // 
            this.purchaseDatePicker.Location = new System.Drawing.Point(303, 205);
            this.purchaseDatePicker.Name = "purchaseDatePicker";
            this.purchaseDatePicker.Size = new System.Drawing.Size(197, 26);
            this.purchaseDatePicker.TabIndex = 19;
            // 
            // AddAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 935);
            this.Controls.Add(this.purchaseDatePicker);
            this.Controls.Add(this.confirmAssetBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.notesTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Name = "AddAsset";
            this.Text = "AddAsset";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox assetNameTxtBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox employeeIdTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox notesTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confirmAssetBtn;
        private System.Windows.Forms.DateTimePicker purchaseDatePicker;
    }
}