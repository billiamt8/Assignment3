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
            lblPrice = new Label();
            lblBrand = new Label();
            lblQuantity = new Label();
            lblID = new Label();
            txtID = new TextBox();
            lblName = new Label();
            pnlProductDetails = new Panel();
            lblCurrency = new Label();
            lblCategory = new Label();
            lblDescription = new Label();
            txtCurrency = new TextBox();
            txtCategory = new TextBox();
            txtQuantity = new TextBox();
            txtBrand = new TextBox();
            txtDescription = new TextBox();
            btnClearProduct = new Button();
            txtName = new TextBox();
            txtPrice = new TextBox();
            lblProductDetails = new Label();
            btnDelete = new Button();
            txtDelete = new TextBox();
            pnlDeleteProduct = new Panel();
            btnSave = new Button();
            btnAddProduct = new Button();
            btnUpdateProduct = new Button();
            lblDeleteProduct = new Label();
            dgvInventory = new DataGridView();
            dgvColumnID = new DataGridViewTextBoxColumn();
            pnlProductDetails.SuspendLayout();
            pnlDeleteProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(19, 320);
            lblPrice.Margin = new Padding(6, 0, 6, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(74, 37);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(19, 206);
            lblBrand.Margin = new Padding(6, 0, 6, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(86, 37);
            lblBrand.TabIndex = 5;
            lblBrand.Text = "Brand";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(15, 426);
            lblQuantity.Margin = new Padding(6, 0, 6, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(119, 37);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(19, 35);
            lblID.Margin = new Padding(6, 0, 6, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(43, 37);
            lblID.TabIndex = 2;
            lblID.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(169, 32);
            txtID.Margin = new Padding(6, 7, 6, 7);
            txtID.Name = "txtID";
            txtID.Size = new Size(332, 43);
            txtID.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 92);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(88, 37);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // pnlProductDetails
            // 
            pnlProductDetails.Controls.Add(lblCurrency);
            pnlProductDetails.Controls.Add(lblCategory);
            pnlProductDetails.Controls.Add(lblDescription);
            pnlProductDetails.Controls.Add(txtCurrency);
            pnlProductDetails.Controls.Add(txtCategory);
            pnlProductDetails.Controls.Add(txtQuantity);
            pnlProductDetails.Controls.Add(txtBrand);
            pnlProductDetails.Controls.Add(txtDescription);
            pnlProductDetails.Controls.Add(lblQuantity);
            pnlProductDetails.Controls.Add(btnClearProduct);
            pnlProductDetails.Controls.Add(txtName);
            pnlProductDetails.Controls.Add(lblName);
            pnlProductDetails.Controls.Add(txtPrice);
            pnlProductDetails.Controls.Add(txtID);
            pnlProductDetails.Controls.Add(lblPrice);
            pnlProductDetails.Controls.Add(lblID);
            pnlProductDetails.Controls.Add(lblBrand);
            pnlProductDetails.Location = new Point(43, 99);
            pnlProductDetails.Margin = new Padding(6, 7, 6, 7);
            pnlProductDetails.Name = "pnlProductDetails";
            pnlProductDetails.Size = new Size(549, 719);
            pnlProductDetails.TabIndex = 3;
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(19, 373);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(121, 37);
            lblCurrency.TabIndex = 13;
            lblCurrency.Text = "Currency";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(19, 263);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(125, 37);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(15, 149);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(152, 37);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description";
            // 
            // txtCurrency
            // 
            txtCurrency.Location = new Point(169, 370);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.Size = new Size(332, 43);
            txtCurrency.TabIndex = 13;
            txtCurrency.TextChanged += txtCurrency_TextChanged;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(169, 260);
            txtCategory.Margin = new Padding(6, 7, 6, 7);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(332, 43);
            txtCategory.TabIndex = 13;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(169, 423);
            txtQuantity.Margin = new Padding(6, 7, 6, 7);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(332, 43);
            txtQuantity.TabIndex = 6;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(169, 203);
            txtBrand.Margin = new Padding(6, 7, 6, 7);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(332, 43);
            txtBrand.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(169, 146);
            txtDescription.Margin = new Padding(6, 7, 6, 7);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(332, 43);
            txtDescription.TabIndex = 9;
            // 
            // btnClearProduct
            // 
            btnClearProduct.Location = new Point(36, 655);
            btnClearProduct.Margin = new Padding(6, 7, 6, 7);
            btnClearProduct.Name = "btnClearProduct";
            btnClearProduct.Size = new Size(465, 57);
            btnClearProduct.TabIndex = 8;
            btnClearProduct.Text = "Clear";
            btnClearProduct.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(169, 89);
            txtName.Margin = new Padding(6, 7, 6, 7);
            txtName.Name = "txtName";
            txtName.Size = new Size(332, 43);
            txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(169, 317);
            txtPrice.Margin = new Padding(6, 7, 6, 7);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(332, 43);
            txtPrice.TabIndex = 4;
            // 
            // lblProductDetails
            // 
            lblProductDetails.AutoSize = true;
            lblProductDetails.Location = new Point(49, 62);
            lblProductDetails.Margin = new Padding(6, 0, 6, 0);
            lblProductDetails.Name = "lblProductDetails";
            lblProductDetails.Size = new Size(197, 37);
            lblProductDetails.TabIndex = 4;
            lblProductDetails.Text = "Product Details";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(6, 5);
            btnDelete.Margin = new Padding(6, 7, 6, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(161, 45);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtDelete
            // 
            txtDelete.Location = new Point(180, 7);
            txtDelete.Margin = new Padding(6, 7, 6, 7);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(210, 43);
            txtDelete.TabIndex = 6;
            // 
            // pnlDeleteProduct
            // 
            pnlDeleteProduct.Controls.Add(txtDelete);
            pnlDeleteProduct.Controls.Add(btnDelete);
            pnlDeleteProduct.Location = new Point(43, 991);
            pnlDeleteProduct.Margin = new Padding(6, 7, 6, 7);
            pnlDeleteProduct.Name = "pnlDeleteProduct";
            pnlDeleteProduct.Size = new Size(549, 56);
            pnlDeleteProduct.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ControlText;
            btnSave.Location = new Point(131, 1061);
            btnSave.Margin = new Padding(6, 7, 6, 7);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(369, 57);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(43, 825);
            btnAddProduct.Margin = new Padding(6, 7, 6, 7);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(193, 57);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(399, 825);
            btnUpdateProduct.Margin = new Padding(6, 7, 6, 7);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(193, 57);
            btnUpdateProduct.TabIndex = 9;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // lblDeleteProduct
            // 
            lblDeleteProduct.AutoSize = true;
            lblDeleteProduct.Location = new Point(43, 946);
            lblDeleteProduct.Margin = new Padding(6, 0, 6, 0);
            lblDeleteProduct.Name = "lblDeleteProduct";
            lblDeleteProduct.Size = new Size(366, 37);
            lblDeleteProduct.TabIndex = 11;
            lblDeleteProduct.Text = "Delete Product with ID/Name";
            // 
            // dgvInventory
            // 
            dgvInventory.AllowDrop = true;
            dgvInventory.AllowUserToOrderColumns = true;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { dgvColumnID });
            dgvInventory.Location = new Point(616, 9);
            dgvInventory.Margin = new Padding(6, 7, 6, 7);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 92;
            dgvInventory.RowTemplate.Height = 25;
            dgvInventory.Size = new Size(1041, 1109);
            dgvInventory.TabIndex = 12;
            // 
            // dgvColumnID
            // 
            dgvColumnID.HeaderText = "ID";
            dgvColumnID.MinimumWidth = 11;
            dgvColumnID.Name = "dgvColumnID";
            dgvColumnID.Width = 225;
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            Controls.Add(dgvInventory);
            Controls.Add(lblDeleteProduct);
            Controls.Add(btnSave);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(pnlDeleteProduct);
            Controls.Add(lblProductDetails);
            Controls.Add(pnlProductDetails);
            Margin = new Padding(2);
            Name = "UC_Inventory";
            Size = new Size(1663, 1125);
            pnlProductDetails.ResumeLayout(false);
            pnlProductDetails.PerformLayout();
            pnlDeleteProduct.ResumeLayout(false);
            pnlDeleteProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private DataGridViewTextBoxColumn dgvColumnID;
        private TextBox txtDescription;
        private TextBox txtCategory;
        private TextBox txtCurrency;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblCurrency;
    }
}
