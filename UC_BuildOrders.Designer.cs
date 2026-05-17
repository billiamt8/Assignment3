namespace Assignment3
{
    partial class UC_BuildOrders
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
            dgvAvailable = new DataGridView();
            dgvCurrentOrder = new DataGridView();
            lblTotal = new Label();
            lblOrderName = new Label();
            lblOrderDescription = new Label();
            btnAddToOrder = new Button();
            btnRemove = new Button();
            btnCheckout = new Button();
            btnSaveOrder = new Button();
            btnLoadOrder = new Button();
            txtOrderName = new TextBox();
            txtOrderDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAvailable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvAvailable
            // 
            dgvAvailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailable.Location = new Point(6, 7);
            dgvAvailable.Margin = new Padding(6, 7, 6, 7);
            dgvAvailable.Name = "dgvAvailable";
            dgvAvailable.RowHeadersWidth = 92;
            dgvAvailable.RowTemplate.Height = 25;
            dgvAvailable.Size = new Size(398, 879);
            dgvAvailable.TabIndex = 0;
            dgvAvailable.MouseDown += dgvAvailable_MouseDown;
            // 
            // dgvCurrentOrder
            // 
            dgvCurrentOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrentOrder.Location = new Point(457, 7);
            dgvCurrentOrder.Margin = new Padding(6, 7, 6, 7);
            dgvCurrentOrder.Name = "dgvCurrentOrder";
            dgvCurrentOrder.RowHeadersWidth = 92;
            dgvCurrentOrder.RowTemplate.Height = 25;
            dgvCurrentOrder.Size = new Size(947, 879);
            dgvCurrentOrder.TabIndex = 1;
            dgvCurrentOrder.DragDrop += dgvCurrentOrder_DragDrop;
            dgvCurrentOrder.DragEnter += dgvCurrentOrder_DragEnter;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(1449, 7);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(122, 61);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // lblOrderName
            // 
            lblOrderName.AutoSize = true;
            lblOrderName.Location = new Point(1414, 143);
            lblOrderName.Name = "lblOrderName";
            lblOrderName.Size = new Size(163, 37);
            lblOrderName.TabIndex = 3;
            lblOrderName.Text = "Order Name";
            // 
            // lblOrderDescription
            // 
            lblOrderDescription.AutoSize = true;
            lblOrderDescription.Location = new Point(1414, 310);
            lblOrderDescription.Name = "lblOrderDescription";
            lblOrderDescription.Size = new Size(227, 37);
            lblOrderDescription.TabIndex = 4;
            lblOrderDescription.Text = "Order Description";
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.Location = new Point(123, 896);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(169, 52);
            btnAddToOrder.TabIndex = 5;
            btnAddToOrder.Text = "Add to Order";
            btnAddToOrder.UseVisualStyleBackColor = true;
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(457, 896);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(287, 52);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove from Order";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(911, 896);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(169, 52);
            btnCheckout.TabIndex = 7;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(1235, 896);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(169, 52);
            btnSaveOrder.TabIndex = 8;
            btnSaveOrder.Text = "Save Order";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // btnLoadOrder
            // 
            btnLoadOrder.Location = new Point(1414, 896);
            btnLoadOrder.Name = "btnLoadOrder";
            btnLoadOrder.Size = new Size(169, 52);
            btnLoadOrder.TabIndex = 9;
            btnLoadOrder.Text = "Load Order";
            btnLoadOrder.UseVisualStyleBackColor = true;
            btnLoadOrder.Click += btnLoadOrder_Click;
            // 
            // txtOrderName
            // 
            txtOrderName.Location = new Point(1414, 183);
            txtOrderName.Name = "txtOrderName";
            txtOrderName.Size = new Size(225, 43);
            txtOrderName.TabIndex = 10;
            // 
            // txtOrderDescription
            // 
            txtOrderDescription.Location = new Point(1414, 350);
            txtOrderDescription.Name = "txtOrderDescription";
            txtOrderDescription.Size = new Size(225, 43);
            txtOrderDescription.TabIndex = 11;
            // 
            // UC_BuildOrders
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtOrderDescription);
            Controls.Add(txtOrderName);
            Controls.Add(btnLoadOrder);
            Controls.Add(btnSaveOrder);
            Controls.Add(btnCheckout);
            Controls.Add(btnRemove);
            Controls.Add(btnAddToOrder);
            Controls.Add(lblOrderDescription);
            Controls.Add(lblOrderName);
            Controls.Add(lblTotal);
            Controls.Add(dgvCurrentOrder);
            Controls.Add(dgvAvailable);
            Margin = new Padding(6, 7, 6, 7);
            Name = "UC_BuildOrders";
            Size = new Size(1663, 1125);
            ((System.ComponentModel.ISupportInitialize)dgvAvailable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DataGridView dgvAvailable;
        private DataGridView dgvCurrentOrder;
        private Label lblTotal;
        private Label lblOrderName;
        private Label lblOrderDescription;
        private Button btnAddToOrder;
        private Button btnRemove;
        private Button btnCheckout;
        private Button btnSaveOrder;
        private Button btnLoadOrder;
        private TextBox txtOrderName;
        private TextBox txtOrderDescription;
    }
}
