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
    public partial class AddProductUserControl : UserControl
    {
        private MainWindow mainWindow;

        private const string PRODUCT_ID_PLACEHOLDER = "Product Id Ex: 1234";
        private const string PRODUCT_DESCRIPTION_PLACEHOLDER = "Agregue una descripcion...";

        public AddProductUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            this.ResetControls();
        }

        private void textBoxProductId_Enter(object sender, EventArgs e)
        {
            this.RemovePlaceholder(this.textBoxProductId, PRODUCT_ID_PLACEHOLDER);
        }

        private void textBoxProductId_Leave(object sender, EventArgs e)
        {
            this.AddPlaceholder(this.textBoxProductId, PRODUCT_ID_PLACEHOLDER);
        }

        private void textBoxProductDescription_Enter(object sender, EventArgs e)
        {
            this.RemovePlaceholder(this.textBoxProductDescription, PRODUCT_DESCRIPTION_PLACEHOLDER);
        }

        private void textBoxProductDescription_Leave(object sender, EventArgs e)
        {
            this.AddPlaceholder(this.textBoxProductDescription, PRODUCT_DESCRIPTION_PLACEHOLDER);
        }

        private void AddPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
            }
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
            }
        }

        private void ResetControls()
        {
            this.textBoxProductId.Text = PRODUCT_ID_PLACEHOLDER;
            this.textBoxProductDescription.Text = PRODUCT_DESCRIPTION_PLACEHOLDER;
            this.numericUpDownQuantity.Value = 0;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string productId = this.textBoxProductId.Text == PRODUCT_ID_PLACEHOLDER ? "" : this.textBoxProductId.Text;
            string productDescription = this.textBoxProductDescription.Text == PRODUCT_DESCRIPTION_PLACEHOLDER ? "" : this.textBoxProductDescription.Text;

            try
            {
                Product product = new Product()
                {
                    Id = productId,
                    Description = productDescription,
                    Quantity = (int)this.numericUpDownQuantity.Value
                };
                ApplicationRepository.Instance.AddProduct(product);
                MessageBox.Show("El producto se agrego con exito", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ResetControls();

            } catch (InvalidProductException invalidProductException)
            {
                MessageBox.Show($"{invalidProductException.Attribute} {invalidProductException.Error}", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.mainWindow.OnRefresh(ApplicationState.IS_ON_MAIN_MENU);
        }
    }
}
