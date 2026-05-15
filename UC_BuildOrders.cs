using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace Assignment3
{
    public partial class UC_BuildOrders : UserControl
    {
        private BindingList<Product> _availableProducts;
        private BindingList<OrderItem> _currentOrderItems = new BindingList<OrderItem>();
        private string _csvPath = "./products-100.csv";

        public UC_BuildOrders()
        {
            InitializeComponent();
            SetupOrderSystem();
        }

        private void SetupOrderSystem()
        {
            // Apply these settings to the Inventory grid
            dgvAvailable.ReadOnly = true;
            dgvAvailable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailable.MultiSelect = false; // Prevents selecting multiple rows at once

            // Apply these settings to the Current Order grid
            dgvCurrentOrder.ReadOnly = true;
            dgvCurrentOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCurrentOrder.MultiSelect = false;

            // Configure Inventory Grid (Left)
            dgvAvailable.AutoGenerateColumns = false;
            dgvAvailable.Columns.Clear();
            dgvAvailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Name = "colID", Width = 50 });
            dgvAvailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product Name", Name = "colName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            // Configure Current Order Grid (Right)
            dgvCurrentOrder.AutoGenerateColumns = false;
            dgvCurrentOrder.Columns.Clear();
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Width = 50 });
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Price", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Qty", Width = 50 });
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Subtotal", HeaderText = "Subtotal", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });

            dgvCurrentOrder.DataSource = _currentOrderItems;
            dgvCurrentOrder.AllowDrop = true;
        }

        private void UC_Orders_Load(object sender, EventArgs e)
        {
            try
            {
                var products = InventoryService.LoadFromCSV(_csvPath);
                _availableProducts = new BindingList<Product>(products);
                dgvAvailable.DataSource = _availableProducts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load inventory: " + ex.Message);
            }
        }

        private void dgvAvailable_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvAvailable.SelectedRows.Count > 0)
            {
                var product = (Product)dgvAvailable.SelectedRows[0].DataBoundItem;
                dgvAvailable.DoDragDrop(product, DragDropEffects.Copy);
            }
        }
    }
}
