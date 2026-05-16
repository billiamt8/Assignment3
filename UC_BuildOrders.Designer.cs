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
            dgvAvailable.Size = new Size(493, 671);
            dgvAvailable.TabIndex = 0;
            dgvAvailable.MouseDown += dgvAvailable_MouseDown;
            // 
            // dgvCurrentOrder
            // 
            dgvCurrentOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrentOrder.Location = new Point(575, 7);
            dgvCurrentOrder.Margin = new Padding(6, 7, 6, 7);
            dgvCurrentOrder.Name = "dgvCurrentOrder";
            dgvCurrentOrder.RowHeadersWidth = 92;
            dgvCurrentOrder.RowTemplate.Height = 25;
            dgvCurrentOrder.Size = new Size(782, 671);
            dgvCurrentOrder.TabIndex = 1;
            // 
            // UC_BuildOrders
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvCurrentOrder);
            Controls.Add(dgvAvailable);
            Margin = new Padding(6, 7, 6, 7);
            Name = "UC_BuildOrders";
            Size = new Size(1862, 1285);
            ((System.ComponentModel.ISupportInitialize)dgvAvailable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentOrder).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvAvailable;
        private DataGridView dgvCurrentOrder;
    }
}
