namespace Assignment3
{
    partial class UC_Inventory
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlProductDetails = new System.Windows.Forms.Panel();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.pnlProductDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(404, 167);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(8, 69);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(8, 127);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 15);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Brand";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(8, 98);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(8, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(79, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // pnlProductDetails
            // 
            this.pnlProductDetails.Controls.Add(this.txtBrand);
            this.pnlProductDetails.Controls.Add(this.txtQuantity);
            this.pnlProductDetails.Controls.Add(this.txtName);
            this.pnlProductDetails.Controls.Add(this.lblQuantity);
            this.pnlProductDetails.Controls.Add(this.txtPrice);
            this.pnlProductDetails.Controls.Add(this.lblName);
            this.pnlProductDetails.Controls.Add(this.lblBrand);
            this.pnlProductDetails.Controls.Add(this.txtID);
            this.pnlProductDetails.Controls.Add(this.lblPrice);
            this.pnlProductDetails.Controls.Add(this.lblID);
            this.pnlProductDetails.Location = new System.Drawing.Point(67, 49);
            this.pnlProductDetails.Name = "pnlProductDetails";
            this.pnlProductDetails.Size = new System.Drawing.Size(256, 285);
            this.pnlProductDetails.TabIndex = 3;
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Location = new System.Drawing.Point(70, 44);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(87, 15);
            this.lblProductDetails.TabIndex = 4;
            this.lblProductDetails.Text = "Product Details";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(79, 124);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 23);
            this.txtBrand.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(79, 95);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 23);
            this.txtQuantity.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(79, 66);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            this.txtPrice.TabIndex = 4;
            // 
            // UC_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.lblProductDetails);
            this.Controls.Add(this.pnlProductDetails);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UC_Inventory";
            this.Size = new System.Drawing.Size(1001, 596);
            this.pnlProductDetails.ResumeLayout(false);
            this.pnlProductDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlSearchBox;
        private Panel panel2;
        private ListView listView1;
        private Label lblPrice;
        private Label lblBrand;
        private Label lblQuantity;
        private Label lblID;
        private TextBox txtID;
        private Label lblName;
        private Panel pnlProductDetails;
        private TextBox txtName;
        private TextBox txtBrand;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label lblProductDetails;
    }
}
