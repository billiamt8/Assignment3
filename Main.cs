using System.ComponentModel;

namespace Assignment3
{
    public partial class Main : Form
    {
        private BindingList<Product> _inventoryList = new BindingList<Product>();
        private string filePath = "./products-100.csv";
        public Main()
        {
            InitializeComponent();
            SetupLayout();
            ShowScreen(new UC_Home());
        }


        private void SetupLayout()
        {
            btnHome.Click += (s, e) => ShowScreen(new UC_Home());
            btnInventory.Click += (s, e) => ShowScreen(new UC_Inventory());
            btnProducts.Click += (s, e) => ShowScreen(new UC_Products());
            btnBuildOrders.Click += (s, e) => ShowScreen(new UC_BuildOrders());
            btnCheckout.Click += (s, e) => ShowScreen(new UC_Checkout());
        }

        private void ShowScreen(UserControl newScreen)
        {
            foreach (Control ctrl in pnlContent.Controls)
            {
                ctrl.Dispose();
            }

            pnlContent.Controls.Clear(); // Clear the controls
            newScreen.Dock = DockStyle.Fill; // Set Dock to Fill
            pnlContent.Controls.Add(newScreen); // Add the UC to Pnl

            if (newScreen is UC_Home)
            {
                HighlightButton(btnHome);
            }
            else if (newScreen is UC_Inventory)
            {
                HighlightButton(btnInventory);
            }
            else if (newScreen is UC_BuildOrders)
            {
                HighlightButton(btnBuildOrders);
            }
            else if (newScreen is UC_Checkout)
            {
                HighlightButton(btnCheckout);
            }
            else if (newScreen is UC_Products)
            {
                HighlightButton(btnProducts);
            }
        }

        private void HighlightButton(Button buttonToHighlight)
        {
            btnHome.BackColor = Color.Turquoise;
            btnInventory.BackColor = Color.Turquoise;
            btnProducts.BackColor = Color.Turquoise;
            btnBuildOrders.BackColor = Color.Turquoise;
            btnCheckout.BackColor = Color.Turquoise;
            btnExit.BackColor = Color.Red;

            buttonToHighlight.BackColor = Color.Aquamarine;
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
            "Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                Close();
        }
    }
}