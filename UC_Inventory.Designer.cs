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
            btnDelete = new Button();
            txtDelete = new TextBox();
            btnSave = new Button();
            btnAddProduct = new Button();
            btnUpdateProduct = new Button();
            dgvInventory = new DataGridView();
            columnID = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnDescription = new DataGridViewTextBoxColumn();
            columnBrand = new DataGridViewTextBoxColumn();
            columnCategory = new DataGridViewTextBoxColumn();
            columnPrice = new DataGridViewTextBoxColumn();
            columnCurrency = new DataGridViewTextBoxColumn();
            columnQuantity = new DataGridViewTextBoxColumn();
            columnEAN = new DataGridViewTextBoxColumn();
            columnColor = new DataGridViewTextBoxColumn();
            columnSize = new DataGridViewTextBoxColumn();
            columnAvailability = new DataGridViewTextBoxColumn();
            gbProductDetails = new GroupBox();
            txtAvailability = new TextBox();
            txtSize = new TextBox();
            lblAvailability = new Label();
            lblSize = new Label();
            lblColor = new Label();
            lblEAN = new Label();
            txtColor = new TextBox();
            txtEAN = new TextBox();
            lblBrand = new Label();
            lblCurrency = new Label();
            lblID = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblDescription = new Label();
            txtID = new TextBox();
            txtCurrency = new TextBox();
            txtPrice = new TextBox();
            txtCategory = new TextBox();
            lblName = new Label();
            txtQuantity = new TextBox();
            txtName = new TextBox();
            txtBrand = new TextBox();
            btnClearProduct = new Button();
            txtDescription = new TextBox();
            lblQuantity = new Label();
            gbDeleteProduct = new GroupBox();
            lblInternalID = new Label();
            txtInternalID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            gbProductDetails.SuspendLayout();
            gbDeleteProduct.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(9, 46);
            btnDelete.Margin = new Padding(6, 7, 6, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(161, 57);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtDelete
            // 
            txtDelete.Location = new Point(183, 53);
            txtDelete.Margin = new Padding(6, 7, 6, 7);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(318, 43);
            txtDelete.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ControlText;
            btnSave.Location = new Point(131, 1048);
            btnSave.Margin = new Padding(6, 7, 6, 7);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(369, 69);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(43, 858);
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
            btnUpdateProduct.Location = new Point(399, 858);
            btnUpdateProduct.Margin = new Padding(6, 7, 6, 7);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(193, 57);
            btnUpdateProduct.TabIndex = 9;
            btnUpdateProduct.Text = "Update";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowDrop = true;
            dgvInventory.AllowUserToOrderColumns = true;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { columnID, columnName, columnDescription, columnBrand, columnCategory, columnPrice, columnCurrency, columnQuantity, columnEAN, columnColor, columnSize, columnAvailability });
            dgvInventory.Location = new Point(615, 10);
            dgvInventory.Margin = new Padding(6, 7, 6, 7);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersWidth = 92;
            dgvInventory.RowTemplate.Height = 25;
            dgvInventory.Size = new Size(1041, 1110);
            dgvInventory.TabIndex = 12;
            // 
            // columnID
            // 
            columnID.HeaderText = "ID";
            columnID.MinimumWidth = 11;
            columnID.Name = "columnID";
            columnID.ReadOnly = true;
            columnID.Width = 225;
            // 
            // columnName
            // 
            columnName.HeaderText = "Name";
            columnName.MinimumWidth = 11;
            columnName.Name = "columnName";
            columnName.ReadOnly = true;
            columnName.Width = 225;
            // 
            // columnDescription
            // 
            columnDescription.HeaderText = "Description";
            columnDescription.MinimumWidth = 11;
            columnDescription.Name = "columnDescription";
            columnDescription.ReadOnly = true;
            columnDescription.Width = 225;
            // 
            // columnBrand
            // 
            columnBrand.HeaderText = "Brand";
            columnBrand.MinimumWidth = 11;
            columnBrand.Name = "columnBrand";
            columnBrand.ReadOnly = true;
            columnBrand.Width = 225;
            // 
            // columnCategory
            // 
            columnCategory.HeaderText = "Category";
            columnCategory.MinimumWidth = 11;
            columnCategory.Name = "columnCategory";
            columnCategory.ReadOnly = true;
            columnCategory.Width = 225;
            // 
            // columnPrice
            // 
            columnPrice.HeaderText = "Price";
            columnPrice.MinimumWidth = 11;
            columnPrice.Name = "columnPrice";
            columnPrice.ReadOnly = true;
            columnPrice.Width = 225;
            // 
            // columnCurrency
            // 
            columnCurrency.HeaderText = "Currency";
            columnCurrency.MinimumWidth = 11;
            columnCurrency.Name = "columnCurrency";
            columnCurrency.ReadOnly = true;
            columnCurrency.Width = 225;
            // 
            // columnQuantity
            // 
            columnQuantity.HeaderText = "Quantity";
            columnQuantity.MinimumWidth = 11;
            columnQuantity.Name = "columnQuantity";
            columnQuantity.ReadOnly = true;
            columnQuantity.Width = 225;
            // 
            // columnEAN
            // 
            columnEAN.HeaderText = "EAN";
            columnEAN.MinimumWidth = 11;
            columnEAN.Name = "columnEAN";
            columnEAN.ReadOnly = true;
            columnEAN.Width = 225;
            // 
            // columnColor
            // 
            columnColor.HeaderText = "Color";
            columnColor.MinimumWidth = 11;
            columnColor.Name = "columnColor";
            columnColor.ReadOnly = true;
            columnColor.Width = 225;
            // 
            // columnSize
            // 
            columnSize.HeaderText = "Size";
            columnSize.MinimumWidth = 11;
            columnSize.Name = "columnSize";
            columnSize.ReadOnly = true;
            columnSize.Width = 225;
            // 
            // columnAvailability
            // 
            columnAvailability.HeaderText = "Availability";
            columnAvailability.MinimumWidth = 11;
            columnAvailability.Name = "columnAvailability";
            columnAvailability.ReadOnly = true;
            columnAvailability.Width = 225;
            // 
            // gbProductDetails
            // 
            gbProductDetails.Controls.Add(txtInternalID);
            gbProductDetails.Controls.Add(lblInternalID);
            gbProductDetails.Controls.Add(txtAvailability);
            gbProductDetails.Controls.Add(txtSize);
            gbProductDetails.Controls.Add(lblAvailability);
            gbProductDetails.Controls.Add(lblSize);
            gbProductDetails.Controls.Add(lblColor);
            gbProductDetails.Controls.Add(lblEAN);
            gbProductDetails.Controls.Add(txtColor);
            gbProductDetails.Controls.Add(txtEAN);
            gbProductDetails.Controls.Add(lblBrand);
            gbProductDetails.Controls.Add(lblCurrency);
            gbProductDetails.Controls.Add(lblID);
            gbProductDetails.Controls.Add(lblCategory);
            gbProductDetails.Controls.Add(lblPrice);
            gbProductDetails.Controls.Add(lblDescription);
            gbProductDetails.Controls.Add(txtID);
            gbProductDetails.Controls.Add(txtCurrency);
            gbProductDetails.Controls.Add(txtPrice);
            gbProductDetails.Controls.Add(txtCategory);
            gbProductDetails.Controls.Add(lblName);
            gbProductDetails.Controls.Add(txtQuantity);
            gbProductDetails.Controls.Add(txtName);
            gbProductDetails.Controls.Add(txtBrand);
            gbProductDetails.Controls.Add(btnClearProduct);
            gbProductDetails.Controls.Add(txtDescription);
            gbProductDetails.Controls.Add(lblQuantity);
            gbProductDetails.Location = new Point(43, 19);
            gbProductDetails.Name = "gbProductDetails";
            gbProductDetails.Size = new Size(563, 829);
            gbProductDetails.TabIndex = 13;
            gbProductDetails.TabStop = false;
            gbProductDetails.Text = "Product Details";
            // 
            // txtAvailability
            // 
            txtAvailability.Location = new Point(169, 655);
            txtAvailability.Name = "txtAvailability";
            txtAvailability.Size = new Size(332, 43);
            txtAvailability.TabIndex = 20;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(169, 598);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(332, 43);
            txtSize.TabIndex = 19;
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Location = new Point(19, 658);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(147, 37);
            lblAvailability.TabIndex = 18;
            lblAvailability.Text = "Availability";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(19, 601);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(64, 37);
            lblSize.TabIndex = 17;
            lblSize.Text = "Size";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(15, 548);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(82, 37);
            lblColor.TabIndex = 16;
            lblColor.Text = "Color";
            // 
            // lblEAN
            // 
            lblEAN.AutoSize = true;
            lblEAN.Location = new Point(19, 491);
            lblEAN.Name = "lblEAN";
            lblEAN.Size = new Size(68, 37);
            lblEAN.TabIndex = 15;
            lblEAN.Text = "EAN";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(169, 545);
            txtColor.Margin = new Padding(6, 7, 6, 7);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(332, 43);
            txtColor.TabIndex = 13;
            // 
            // txtEAN
            // 
            txtEAN.Location = new Point(169, 488);
            txtEAN.Margin = new Padding(6, 7, 6, 7);
            txtEAN.Name = "txtEAN";
            txtEAN.Size = new Size(332, 43);
            txtEAN.TabIndex = 14;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(19, 216);
            lblBrand.Margin = new Padding(6, 0, 6, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(86, 37);
            lblBrand.TabIndex = 5;
            lblBrand.Text = "Brand";
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(19, 381);
            lblCurrency.Margin = new Padding(2, 0, 2, 0);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(121, 37);
            lblCurrency.TabIndex = 13;
            lblCurrency.Text = "Currency";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(19, 44);
            lblID.Margin = new Padding(6, 0, 6, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(43, 37);
            lblID.TabIndex = 2;
            lblID.Text = "ID";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(19, 273);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(125, 37);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(19, 330);
            lblPrice.Margin = new Padding(6, 0, 6, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(74, 37);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(15, 157);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(152, 37);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description";
            // 
            // txtID
            // 
            txtID.Location = new Point(169, 41);
            txtID.Margin = new Padding(6, 7, 6, 7);
            txtID.Name = "txtID";
            txtID.Size = new Size(332, 43);
            txtID.TabIndex = 1;
            // 
            // txtCurrency
            // 
            txtCurrency.Location = new Point(169, 379);
            txtCurrency.Margin = new Padding(2);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.Size = new Size(332, 43);
            txtCurrency.TabIndex = 13;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(169, 327);
            txtPrice.Margin = new Padding(6, 7, 6, 7);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(332, 43);
            txtPrice.TabIndex = 4;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(169, 268);
            txtCategory.Margin = new Padding(6, 7, 6, 7);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(332, 43);
            txtCategory.TabIndex = 13;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 100);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(88, 37);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(169, 431);
            txtQuantity.Margin = new Padding(6, 7, 6, 7);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(332, 43);
            txtQuantity.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(169, 98);
            txtName.Margin = new Padding(6, 7, 6, 7);
            txtName.Name = "txtName";
            txtName.Size = new Size(332, 43);
            txtName.TabIndex = 4;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(169, 211);
            txtBrand.Margin = new Padding(6, 7, 6, 7);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(332, 43);
            txtBrand.TabIndex = 5;
            // 
            // btnClearProduct
            // 
            btnClearProduct.Location = new Point(36, 762);
            btnClearProduct.Margin = new Padding(6, 7, 6, 7);
            btnClearProduct.Name = "btnClearProduct";
            btnClearProduct.Size = new Size(465, 57);
            btnClearProduct.TabIndex = 8;
            btnClearProduct.Text = "Clear";
            btnClearProduct.UseVisualStyleBackColor = true;
            btnClearProduct.Click += btnClearProduct_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(169, 155);
            txtDescription.Margin = new Padding(6, 7, 6, 7);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(332, 43);
            txtDescription.TabIndex = 9;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(15, 436);
            lblQuantity.Margin = new Padding(6, 0, 6, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(119, 37);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            // 
            // gbDeleteProduct
            // 
            gbDeleteProduct.Controls.Add(btnDelete);
            gbDeleteProduct.Controls.Add(txtDelete);
            gbDeleteProduct.Location = new Point(43, 925);
            gbDeleteProduct.Name = "gbDeleteProduct";
            gbDeleteProduct.Size = new Size(563, 113);
            gbDeleteProduct.TabIndex = 14;
            gbDeleteProduct.TabStop = false;
            gbDeleteProduct.Text = "Delete Product with ID/Name";
            // 
            // lblInternalID
            // 
            lblInternalID.AutoSize = true;
            lblInternalID.Location = new Point(19, 711);
            lblInternalID.Name = "lblInternalID";
            lblInternalID.Size = new Size(140, 37);
            lblInternalID.TabIndex = 21;
            lblInternalID.Text = "Internal ID";
            // 
            // txtInternalID
            // 
            txtInternalID.Location = new Point(169, 708);
            txtInternalID.Name = "txtInternalID";
            txtInternalID.Size = new Size(332, 43);
            txtInternalID.TabIndex = 22;
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            Controls.Add(gbDeleteProduct);
            Controls.Add(gbProductDetails);
            Controls.Add(dgvInventory);
            Controls.Add(btnSave);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnAddProduct);
            Margin = new Padding(2);
            Name = "UC_Inventory";
            Size = new Size(1663, 1125);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            gbProductDetails.ResumeLayout(false);
            gbProductDetails.PerformLayout();
            gbDeleteProduct.ResumeLayout(false);
            gbDeleteProduct.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private Button btnDelete;
        private TextBox txtDelete;
        private Button btnAddProduct;
        private Button btnUpdateProduct;
        private Button btnSave;
        private DataGridView dgvInventory;
        private GroupBox gbProductDetails;
        private TextBox txtColor;
        private TextBox txtEAN;
        private Label lblBrand;
        private Label lblCurrency;
        private Label lblID;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblDescription;
        private TextBox txtID;
        private TextBox txtCurrency;
        private TextBox txtPrice;
        private TextBox txtCategory;
        private Label lblName;
        private TextBox txtQuantity;
        private TextBox txtName;
        private TextBox txtBrand;
        private Button btnClearProduct;
        private TextBox txtDescription;
        private Label lblQuantity;
        private GroupBox gbDeleteProduct;
        private DataGridViewTextBoxColumn columnID;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnDescription;
        private DataGridViewTextBoxColumn columnBrand;
        private DataGridViewTextBoxColumn columnCategory;
        private DataGridViewTextBoxColumn columnPrice;
        private DataGridViewTextBoxColumn columnCurrency;
        private DataGridViewTextBoxColumn columnQuantity;
        private DataGridViewTextBoxColumn columnEAN;
        private DataGridViewTextBoxColumn columnColor;
        private DataGridViewTextBoxColumn columnSize;
        private TextBox txtSize;
        private Label lblAvailability;
        private Label lblSize;
        private Label lblColor;
        private Label lblEAN;
        private TextBox txtAvailability;
        private DataGridViewTextBoxColumn columnAvailability;
        private TextBox txtInternalID;
        private Label lblInternalID;
    }
}
