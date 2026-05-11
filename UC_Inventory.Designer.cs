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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlProductDetails = new System.Windows.Forms.Panel();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnClearProduct = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.pnlDeleteProduct = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.lblDeleteProduct = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProductDetails.SuspendLayout();
            this.pnlDeleteProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(9, 130);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(9, 84);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 15);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Brand";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(7, 173);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 15);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(79, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(157, 23);
            this.txtID.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // pnlProductDetails
            // 
            this.pnlProductDetails.Controls.Add(this.txtColor);
            this.pnlProductDetails.Controls.Add(this.txtEAN);
            this.pnlProductDetails.Controls.Add(this.lblCurrency);
            this.pnlProductDetails.Controls.Add(this.lblCategory);
            this.pnlProductDetails.Controls.Add(this.lblDescription);
            this.pnlProductDetails.Controls.Add(this.txtCurrency);
            this.pnlProductDetails.Controls.Add(this.txtCategory);
            this.pnlProductDetails.Controls.Add(this.txtQuantity);
            this.pnlProductDetails.Controls.Add(this.txtBrand);
            this.pnlProductDetails.Controls.Add(this.txtDescription);
            this.pnlProductDetails.Controls.Add(this.lblQuantity);
            this.pnlProductDetails.Controls.Add(this.btnClearProduct);
            this.pnlProductDetails.Controls.Add(this.txtName);
            this.pnlProductDetails.Controls.Add(this.lblName);
            this.pnlProductDetails.Controls.Add(this.txtPrice);
            this.pnlProductDetails.Controls.Add(this.txtID);
            this.pnlProductDetails.Controls.Add(this.lblPrice);
            this.pnlProductDetails.Controls.Add(this.lblID);
            this.pnlProductDetails.Controls.Add(this.lblBrand);
            this.pnlProductDetails.Location = new System.Drawing.Point(20, 40);
            this.pnlProductDetails.Name = "pnlProductDetails";
            this.pnlProductDetails.Size = new System.Drawing.Size(256, 291);
            this.pnlProductDetails.TabIndex = 3;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(79, 229);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(157, 23);
            this.txtColor.TabIndex = 13;
            // 
            // txtEAN
            // 
            this.txtEAN.Location = new System.Drawing.Point(79, 200);
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.Size = new System.Drawing.Size(157, 23);
            this.txtEAN.TabIndex = 14;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(9, 151);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(55, 15);
            this.lblCurrency.TabIndex = 13;
            this.lblCurrency.Text = "Currency";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(9, 107);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 15);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(7, 60);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 15);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(79, 150);
            this.txtCurrency.Margin = new System.Windows.Forms.Padding(1);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(157, 23);
            this.txtCurrency.TabIndex = 13;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(79, 105);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(157, 23);
            this.txtCategory.TabIndex = 13;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(79, 171);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(157, 23);
            this.txtQuantity.TabIndex = 6;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(79, 82);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(157, 23);
            this.txtBrand.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(79, 59);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(157, 23);
            this.txtDescription.TabIndex = 9;
            // 
            // btnClearProduct
            // 
            this.btnClearProduct.Location = new System.Drawing.Point(17, 266);
            this.btnClearProduct.Name = "btnClearProduct";
            this.btnClearProduct.Size = new System.Drawing.Size(217, 23);
            this.btnClearProduct.TabIndex = 8;
            this.btnClearProduct.Text = "Clear";
            this.btnClearProduct.UseVisualStyleBackColor = true;
            this.btnClearProduct.Click += new System.EventHandler(this.btnClearProduct_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(79, 129);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(157, 23);
            this.txtPrice.TabIndex = 4;
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Location = new System.Drawing.Point(23, 25);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(87, 15);
            this.lblProductDetails.TabIndex = 4;
            this.lblProductDetails.Text = "Product Details";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(84, 3);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(152, 23);
            this.txtDelete.TabIndex = 6;
            // 
            // pnlDeleteProduct
            // 
            this.pnlDeleteProduct.Controls.Add(this.txtDelete);
            this.pnlDeleteProduct.Controls.Add(this.btnDelete);
            this.pnlDeleteProduct.Location = new System.Drawing.Point(20, 378);
            this.pnlDeleteProduct.Name = "pnlDeleteProduct";
            this.pnlDeleteProduct.Size = new System.Drawing.Size(256, 29);
            this.pnlDeleteProduct.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(61, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 28);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(20, 334);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(90, 23);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(186, 334);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(90, 23);
            this.btnUpdateProduct.TabIndex = 9;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // lblDeleteProduct
            // 
            this.lblDeleteProduct.AutoSize = true;
            this.lblDeleteProduct.Location = new System.Drawing.Point(20, 360);
            this.lblDeleteProduct.Name = "lblDeleteProduct";
            this.lblDeleteProduct.Size = new System.Drawing.Size(162, 15);
            this.lblDeleteProduct.TabIndex = 11;
            this.lblDeleteProduct.Text = "Delete Product with ID/Name";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowDrop = true;
            this.dgvInventory.AllowUserToOrderColumns = true;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnID,
            this.dgvColumnName,
            this.dgvColumnDescription,
            this.dgvColumnBrand,
            this.dgvColumnCategory,
            this.dgvColumnPrice,
            this.dgvColumnCurrency});
            this.dgvInventory.Location = new System.Drawing.Point(287, 4);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 92;
            this.dgvInventory.RowTemplate.Height = 25;
            this.dgvInventory.Size = new System.Drawing.Size(486, 450);
            this.dgvInventory.TabIndex = 12;
            // 
            // dgvColumnID
            // 
            this.dgvColumnID.HeaderText = "ID";
            this.dgvColumnID.MinimumWidth = 11;
            this.dgvColumnID.Name = "dgvColumnID";
            // 
            // dgvColumnName
            // 
            this.dgvColumnName.HeaderText = "Name";
            this.dgvColumnName.Name = "dgvColumnName";
            // 
            // dgvColumnDescription
            // 
            this.dgvColumnDescription.HeaderText = "Description";
            this.dgvColumnDescription.Name = "dgvColumnDescription";
            // 
            // dgvColumnBrand
            // 
            this.dgvColumnBrand.HeaderText = "Brand";
            this.dgvColumnBrand.Name = "dgvColumnBrand";
            // 
            // dgvColumnCategory
            // 
            this.dgvColumnCategory.HeaderText = "Category";
            this.dgvColumnCategory.Name = "dgvColumnCategory";
            // 
            // dgvColumnPrice
            // 
            this.dgvColumnPrice.HeaderText = "Price";
            this.dgvColumnPrice.Name = "dgvColumnPrice";
            // 
            // dgvColumnCurrency
            // 
            this.dgvColumnCurrency.HeaderText = "Currency";
            this.dgvColumnCurrency.Name = "dgvColumnCurrency";
            // 
            // UC_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.lblDeleteProduct);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.pnlDeleteProduct);
            this.Controls.Add(this.lblProductDetails);
            this.Controls.Add(this.pnlProductDetails);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UC_Inventory";
            this.Size = new System.Drawing.Size(776, 456);
            this.Load += new System.EventHandler(this.UC_Inventory_Load);
            this.pnlProductDetails.ResumeLayout(false);
            this.pnlProductDetails.PerformLayout();
            this.pnlDeleteProduct.ResumeLayout(false);
            this.pnlDeleteProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Button btnClearProduct;
        private Button btnDelete;
        private TextBox txtDelete;
        private Panel pnlDeleteProduct;
        private Button btnAddProduct;
        private Button btnUpdateProduct;
        private Button btnSave;
        private Label lblDeleteProduct;
        private DataGridView dgvInventory;
        private TextBox txtDescription;
        private TextBox txtCategory;
        private TextBox txtCurrency;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblCurrency;
        private DataGridViewTextBoxColumn dgvColumnID;
        private DataGridViewTextBoxColumn dgvColumnName;
        private DataGridViewTextBoxColumn dgvColumnDescription;
        private TextBox txtColor;
        private TextBox txtEAN;
        private DataGridViewTextBoxColumn dgvColumnBrand;
        private DataGridViewTextBoxColumn dgvColumnCategory;
        private DataGridViewTextBoxColumn dgvColumnPrice;
        private DataGridViewTextBoxColumn dgvColumnCurrency;
    }
}
