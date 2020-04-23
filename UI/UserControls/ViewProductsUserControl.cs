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
    public partial class ViewProductsUserControl : UserControl
    {
        private MainWindow mainWindow;

        public ViewProductsUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;

            this.dataGridViewProductos.DataSource = ApplicationRepository.Instance.GetAllProducts();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.mainWindow.OnRefresh(ApplicationState.IS_ON_MAIN_MENU);
        }
    }
}
