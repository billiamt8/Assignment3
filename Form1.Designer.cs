namespace Assignment3
{
    partial class MenuPage
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
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.NavigationMenu = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnBuildOrders = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.NavigationMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(12, 84);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(894, 477);
            this.ContentPanel.TabIndex = 0;
            // 
            // NavigationMenu
            // 
            this.NavigationMenu.Controls.Add(this.btnCheckout);
            this.NavigationMenu.Controls.Add(this.btnBuildOrders);
            this.NavigationMenu.Controls.Add(this.btnProducts);
            this.NavigationMenu.Controls.Add(this.btnInventory);
            this.NavigationMenu.Controls.Add(this.btnHome);
            this.NavigationMenu.Location = new System.Drawing.Point(12, 12);
            this.NavigationMenu.Name = "NavigationMenu";
            this.NavigationMenu.Size = new System.Drawing.Size(894, 66);
            this.NavigationMenu.TabIndex = 1;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(507, 3);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(120, 60);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "button5";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnBuildOrders
            // 
            this.btnBuildOrders.Location = new System.Drawing.Point(381, 3);
            this.btnBuildOrders.Name = "btnBuildOrders";
            this.btnBuildOrders.Size = new System.Drawing.Size(120, 60);
            this.btnBuildOrders.TabIndex = 3;
            this.btnBuildOrders.Text = "button4";
            this.btnBuildOrders.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(255, 3);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(120, 60);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "button3";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(129, 3);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(120, 60);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "button2";
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "button1";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 573);
            this.Controls.Add(this.NavigationMenu);
            this.Controls.Add(this.ContentPanel);
            this.Name = "MenuPage";
            this.Text = "Menu";
            this.NavigationMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ContentPanel;
        private Panel NavigationMenu;
        private Button btnBuildOrders;
        private Button btnProducts;
        private Button btnInventory;
        private Button btnHome;
        private Button btnCheckout;
    }
}