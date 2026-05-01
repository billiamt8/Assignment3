namespace Assignment3
{
    public partial class MenuPage : Form
    {
        public MenuPage()
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
            btnHome.BackColor = Color.AliceBlue;
            btnInventory.BackColor = Color.AliceBlue;
            btnProducts.BackColor = Color.AliceBlue;
            btnBuildOrders.BackColor = Color.AliceBlue;
            btnCheckout.BackColor = Color.AliceBlue;

            buttonToHighlight.BackColor = Color.AntiqueWhite;
        }
            
    }
}