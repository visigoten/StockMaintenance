using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.UserControls
{
    public partial class MainUserControl : UserControl
    {
        private MainWindow mainWindow;

        public MainUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            this.mainWindow.OnRefresh(ApplicationState.IS_CREATING_A_NEW_PRODUCT);
        }

        private void buttonViewProducts_Click(object sender, EventArgs e)
        {
            this.mainWindow.OnRefresh(ApplicationState.IS_VIEWING_PRODUCTS);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.mainWindow.OnRefresh(ApplicationState.IS_CLOSING_APP);
        }

        private void buttonCrearOrden_Click(object sender, EventArgs e)
        {
            this.mainWindow.OnRefresh(ApplicationState.IS_CREATING_AN_ORDER);
        }

        private void buttonViewOrders_Click(object sender, EventArgs e)
        {
            this.mainWindow.OnRefresh(ApplicationState.IS_VIEWING_ORDERS);
        }
    }
}
