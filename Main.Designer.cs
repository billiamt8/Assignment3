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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnBuildOrders = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.MintCream;
            this.pnlContent.Location = new System.Drawing.Point(12, 91);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(776, 456);
            this.pnlContent.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlMenu.Controls.Add(this.btnCheckout);
            this.pnlMenu.Controls.Add(this.btnBuildOrders);
            this.pnlMenu.Controls.Add(this.btnProducts);
            this.pnlMenu.Controls.Add(this.btnInventory);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Location = new System.Drawing.Point(12, 18);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(776, 63);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.SystemColors.Control;
            this.btnCheckout.Location = new System.Drawing.Point(507, 3);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(120, 56);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // btnBuildOrders
            // 
            this.btnBuildOrders.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuildOrders.Location = new System.Drawing.Point(381, 3);
            this.btnBuildOrders.Name = "btnBuildOrders";
            this.btnBuildOrders.Size = new System.Drawing.Size(120, 56);
            this.btnBuildOrders.TabIndex = 3;
            this.btnBuildOrders.Text = "Build Orders";
            this.btnBuildOrders.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.SystemColors.Control;
            this.btnProducts.Location = new System.Drawing.Point(255, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(120, 56);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.Control;
            this.btnInventory.Location = new System.Drawing.Point(129, 3);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(120, 56);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 56);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(780, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 17);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

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