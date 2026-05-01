namespace Assignment3
{
    partial class form
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
            btnProducts = new Button();
            btnInventory = new Button();
            btnHome = new Button();
            btnExit = new Button();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.MintCream;
            pnlContent.Location = new Point(26, 225);
            pnlContent.Margin = new Padding(6, 7, 6, 7);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1663, 1124);
            pnlContent.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.DarkTurquoise;
            pnlMenu.Controls.Add(btnCheckout);
            pnlMenu.Controls.Add(btnBuildOrders);
            pnlMenu.Controls.Add(btnProducts);
            pnlMenu.Controls.Add(btnInventory);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Location = new Point(26, 48);
            pnlMenu.Margin = new Padding(6, 7, 6, 7);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1663, 163);
            pnlMenu.TabIndex = 1;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = SystemColors.Control;
            btnCheckout.Location = new Point(1086, 7);
            btnCheckout.Margin = new Padding(6, 7, 6, 7);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(257, 148);
            btnCheckout.TabIndex = 0;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            // 
            // btnBuildOrders
            // 
            btnBuildOrders.BackColor = SystemColors.Control;
            btnBuildOrders.Location = new Point(816, 7);
            btnBuildOrders.Margin = new Padding(6, 7, 6, 7);
            btnBuildOrders.Name = "btnBuildOrders";
            btnBuildOrders.Size = new Size(257, 148);
            btnBuildOrders.TabIndex = 3;
            btnBuildOrders.Text = "Build Orders";
            btnBuildOrders.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.Control;
            btnProducts.Location = new Point(546, 7);
            btnProducts.Margin = new Padding(6, 7, 6, 7);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(257, 148);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = SystemColors.Control;
            btnInventory.Location = new Point(276, 7);
            btnInventory.Margin = new Padding(6, 7, 6, 7);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(257, 148);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.Control;
            btnHome.Location = new Point(6, 7);
            btnHome.Margin = new Padding(6, 7, 6, 7);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(257, 148);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Location = new Point(1671, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(43, 43);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // form
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
            Name = "form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Panel pnlContent;
        private Panel pnlMenu;
        private Button btnBuildOrders;
        private Button btnProducts;
        private Button btnInventory;
        private Button btnHome;
        private Button btnCheckout;
        private Button btnExit;
    }
}