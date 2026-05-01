namespace Assignment3
{
    partial class UC_Home
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
            pnlHeader = new Panel();
            lblName = new Label();
            pnlDescription = new Panel();
            lblDescription = new Label();
            pictureBoxHome = new PictureBox();
            pnlHeader.SuspendLayout();
            pnlDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblName);
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1562, 225);
            pnlHeader.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(1656, 225);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDescription
            // 
            pnlDescription.Controls.Add(lblDescription);
            pnlDescription.Location = new Point(3, 234);
            pnlDescription.Name = "pnlDescription";
            pnlDescription.Size = new Size(1656, 375);
            pnlDescription.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.BorderStyle = BorderStyle.FixedSingle;
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Location = new Point(0, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1656, 375);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description here";
            lblDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.InitialImage = null;
            pictureBoxHome.Location = new Point(3, 615);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(1656, 528);
            pictureBoxHome.TabIndex = 2;
            pictureBoxHome.TabStop = false;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.MintCream;
            Controls.Add(pictureBoxHome);
            Controls.Add(pnlDescription);
            Controls.Add(pnlHeader);
            Margin = new Padding(6, 7, 6, 7);
            Name = "UC_Home";
            Size = new Size(1662, 1146);
            pnlHeader.ResumeLayout(false);
            pnlDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel pnlHeader;
        private Label lblName;
        private Panel pnlDescription;
        private Label lblDescription;
        private PictureBox pictureBoxHome;
    }
}
