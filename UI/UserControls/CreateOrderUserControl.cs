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
    public partial class CreateOrderUserControl : UserControl
    {
        private MainWindow mainWindow;
        private Warehouse selectedWarehouse;
        private Product selectedProduct;

        public CreateOrderUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.listBoxProductos.Items.AddRange(ApplicationRepository.Instance.GetAllProducts().ToArray());
            this.comboBoxWarehouses.Items.AddRange(ApplicationRepository.Instance.GetAllWarehouses().ToArray());

            this.mainWindow = mainWindow;
        }

        private void listBoxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedProduct = (Product) this.listBoxProductos.SelectedItem;
            this.ShowProductDetails(this.selectedProduct);
        }

        private void ShowProductDetails(Product product)
        {
            this.textBoxSelectedProduct.Text = $@"Id de producto: {product.Id}
Descripcion: {product.Description}
Cantidad disponible: {product.Quantity}
";
        }

        private void comboBoxWarehouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedWarehouse = (Warehouse) this.comboBoxWarehouses.SelectedItem;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.mainWindow.OnRefresh(ApplicationState.IS_ON_MAIN_MENU);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                Product = this.selectedProduct,
                Quantity = (int) this.numericUpDownOrderQuantity.Value,
                SendEmailConfirmation = this.checkBoxEmailNotification.Checked,
                ShippingDate = this.dateTimePickerShippingDate.Value
            };

            this.selectedWarehouse.AddOrder(order);
            MessageBox.Show("La orden se creo con exito", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
