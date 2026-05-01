namespace Assignment3
{
    public partial class MenuPage : Form
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Home());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Inventory());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Products());
        }

        private void btnBuildOrders_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_BuildOrders());
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Checkout());
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
        }

        private void HighlightButton(Button buttonToHighlight)
        {
            btnHome.BackColor = Color.AliceBlue;
            btnInventory.BackColor = Color.AliceBlue;
            btnProducts.BackColor = Color.AliceBlue;
            btnBuildOrders.BackColor = Color.AliceBlue;
            btnCheckout.BackColor = Color.AliceBlue;

            buttonToHighlight.BackColor = Color.AntiqueWhite;
        }
            
    }
}