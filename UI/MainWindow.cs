using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.UserControls;

namespace UI
{
    public partial class MainWindow : Form
    {
        private ApplicationState applicationState;

        public MainWindow()
        {
            InitializeComponent();

            this.OnRefresh(ApplicationState.IS_ON_MAIN_MENU);
        }

        public void OnRefresh(ApplicationState applicationState)
        {
            this.applicationState = applicationState;
            this.mainPanel.Controls.Clear();

            switch (applicationState)
            {
                case ApplicationState.IS_ON_MAIN_MENU:
                    this.mainPanel.Controls.Add(new MainUserControl(this));
                    break;
                case ApplicationState.IS_CREATING_A_NEW_PRODUCT:
                    this.mainPanel.Controls.Add(new AddProductUserControl(this));
                    break;
                case ApplicationState.IS_VIEWING_PRODUCTS:
                    this.mainPanel.Controls.Add(new ViewProductsUserControl(this));
                    break;
                case ApplicationState.IS_CREATING_AN_ORDER:
                    this.mainPanel.Controls.Add(new CreateOrderUserControl(this));
                    break;
                case ApplicationState.IS_VIEWING_ORDERS:
                    this.mainPanel.Controls.Add(new ViewOrdersUserControl(this));
                    break;
                default:
                    this.Close();
                    break;
            }
        }
    }
}
