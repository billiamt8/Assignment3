namespace Assignment3
{
    public partial class form : Form
    {
        public form()
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
            btnExit.Click += (s, e) => this.Close();
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
            
    }
}