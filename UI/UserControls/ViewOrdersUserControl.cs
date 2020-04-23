using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace UI.UserControls
{
    public partial class ViewOrdersUserControl : UserControl
    {
        private MainWindow mainWindow;

        public ViewOrdersUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            this.dataGridViewOrders.DataSource = ApplicationRepository.Instance.GetAllWarehouses().SelectMany(w => w.GetOrders()).ToList();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.mainWindow.OnRefresh(ApplicationState.IS_ON_MAIN_MENU);
        }
    }
}
