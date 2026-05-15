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
            this.dgvAvailable = new System.Windows.Forms.DataGridView();
            this.dgvCurrentOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvailable
            // 
            this.dgvAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailable.Location = new System.Drawing.Point(206, 140);
            this.dgvAvailable.Name = "dgvAvailable";
            this.dgvAvailable.RowTemplate.Height = 25;
            this.dgvAvailable.Size = new System.Drawing.Size(230, 272);
            this.dgvAvailable.TabIndex = 0;
            this.dgvAvailable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvAvailable_MouseDown);
            // 
            // dgvCurrentOrder
            // 
            this.dgvCurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentOrder.Location = new System.Drawing.Point(567, 95);
            this.dgvCurrentOrder.Name = "dgvCurrentOrder";
            this.dgvCurrentOrder.RowTemplate.Height = 25;
            this.dgvCurrentOrder.Size = new System.Drawing.Size(240, 150);
            this.dgvCurrentOrder.TabIndex = 1;
            // 
            // UC_BuildOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCurrentOrder);
            this.Controls.Add(this.dgvAvailable);
            this.Name = "UC_BuildOrders";
            this.Size = new System.Drawing.Size(869, 521);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvAvailable;
        private DataGridView dgvCurrentOrder;
    }
}
