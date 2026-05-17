namespace Assignment3
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlContent = new Panel();
            pnlMenu = new Panel();
            btnCheckout = new Button();
            btnBuildOrders = new Button();
            btnInventory = new Button();
            btnHome = new Button();
            btnExit = new Button();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.MintCream;
            pnlContent.Location = new Point(26, 224);
            pnlContent.Margin = new Padding(6, 7, 6, 7);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1663, 1125);
            pnlContent.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.LightSeaGreen;
            pnlMenu.Controls.Add(btnCheckout);
            pnlMenu.Controls.Add(btnBuildOrders);
            pnlMenu.Controls.Add(btnInventory);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Location = new Point(26, 44);
            pnlMenu.Margin = new Padding(13, 17, 13, 17);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1663, 155);
            pnlMenu.TabIndex = 1;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = SystemColors.Control;
            btnCheckout.Dock = DockStyle.Left;
            btnCheckout.Location = new Point(1077, 0);
            btnCheckout.Margin = new Padding(6, 7, 6, 7);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(359, 155);
            btnCheckout.TabIndex = 0;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // btnBuildOrders
            // 
            btnBuildOrders.BackColor = SystemColors.Control;
            btnBuildOrders.Dock = DockStyle.Left;
            btnBuildOrders.Location = new Point(718, 0);
            btnBuildOrders.Margin = new Padding(6, 7, 6, 7);
            btnBuildOrders.Name = "btnBuildOrders";
            btnBuildOrders.Size = new Size(359, 155);
            btnBuildOrders.TabIndex = 3;
            btnBuildOrders.Text = "Build Orders";
            btnBuildOrders.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = SystemColors.Control;
            btnInventory.Dock = DockStyle.Left;
            btnInventory.Location = new Point(359, 0);
            btnInventory.Margin = new Padding(6, 7, 6, 7);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(359, 155);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.Control;
            btnHome.Dock = DockStyle.Left;
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(6, 7, 6, 7);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(359, 155);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Location = new Point(1671, 0);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(43, 42);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1714, 1379);
            Controls.Add(btnExit);
            Controls.Add(pnlMenu);
            Controls.Add(pnlContent);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 7, 6, 7);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Panel pnlContent;
        private Panel pnlMenu;
        private Button btnBuildOrders;
        private Button btnInventory;
        private Button btnHome;
        private Button btnCheckout;
        private Button btnExit;
    }
}