namespace Assignment3
{
    partial class Homepage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.HomePnl1 = new System.Windows.Forms.Panel();
            this.NameText = new System.Windows.Forms.Label();
            this.HomePnl2 = new System.Windows.Forms.Panel();
            this.DescriptionText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomePnl3 = new System.Windows.Forms.Panel();
            this.HomePnl1.SuspendLayout();
            this.HomePnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HomePnl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePnl1
            // 
            this.HomePnl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.HomePnl1.Controls.Add(this.NameText);
            this.HomePnl1.Location = new System.Drawing.Point(3, 3);
            this.HomePnl1.Name = "HomePnl1";
            this.HomePnl1.Size = new System.Drawing.Size(866, 49);
            this.HomePnl1.TabIndex = 0;
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.PaleGreen;
            this.NameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameText.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameText.Location = new System.Drawing.Point(0, 0);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(866, 49);
            this.NameText.TabIndex = 0;
            this.NameText.Text = "Name";
            this.NameText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameText.Click += new System.EventHandler(this.NameText_Click);
            // 
            // HomePnl2
            // 
            this.HomePnl2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.HomePnl2.Controls.Add(this.DescriptionText);
            this.HomePnl2.Location = new System.Drawing.Point(3, 55);
            this.HomePnl2.Name = "HomePnl2";
            this.HomePnl2.Size = new System.Drawing.Size(866, 119);
            this.HomePnl2.TabIndex = 1;
            // 
            // DescriptionText
            // 
            this.DescriptionText.BackColor = System.Drawing.Color.PaleGreen;
            this.DescriptionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionText.Location = new System.Drawing.Point(0, 0);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(866, 119);
            this.DescriptionText.TabIndex = 0;
            this.DescriptionText.Text = "Description bla bla bla";
            this.DescriptionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(866, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomePnl3
            // 
            this.HomePnl3.Controls.Add(this.pictureBox1);
            this.HomePnl3.Location = new System.Drawing.Point(3, 177);
            this.HomePnl3.Name = "HomePnl3";
            this.HomePnl3.Size = new System.Drawing.Size(866, 304);
            this.HomePnl3.TabIndex = 2;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.HomePnl3);
            this.Controls.Add(this.HomePnl2);
            this.Controls.Add(this.HomePnl1);
            this.Name = "Homepage";
            this.Size = new System.Drawing.Size(872, 484);
            this.HomePnl1.ResumeLayout(false);
            this.HomePnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HomePnl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel HomePnl1;
        private Label NameText;
        private Panel HomePnl2;
        private Label DescriptionText;
        private PictureBox pictureBox1;
        private Panel HomePnl3;
    }
}
