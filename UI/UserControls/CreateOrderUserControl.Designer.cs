namespace UI.UserControls
{
    partial class CreateOrderUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxProductos = new System.Windows.Forms.ListBox();
            this.textBoxSelectedProduct = new System.Windows.Forms.TextBox();
            this.comboBoxWarehouses = new System.Windows.Forms.ComboBox();
            this.dateTimePickerShippingDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxEmailNotification = new System.Windows.Forms.CheckBox();
            this.numericUpDownOrderQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(574, 70);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(188, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Crear Orden";
            // 
            // listBoxProductos
            // 
            this.listBoxProductos.FormattingEnabled = true;
            this.listBoxProductos.ItemHeight = 25;
            this.listBoxProductos.Location = new System.Drawing.Point(104, 168);
            this.listBoxProductos.Name = "listBoxProductos";
            this.listBoxProductos.Size = new System.Drawing.Size(474, 204);
            this.listBoxProductos.TabIndex = 1;
            this.listBoxProductos.SelectedIndexChanged += new System.EventHandler(this.listBoxProductos_SelectedIndexChanged);
            // 
            // textBoxSelectedProduct
            // 
            this.textBoxSelectedProduct.Location = new System.Drawing.Point(698, 168);
            this.textBoxSelectedProduct.Multiline = true;
            this.textBoxSelectedProduct.Name = "textBoxSelectedProduct";
            this.textBoxSelectedProduct.ReadOnly = true;
            this.textBoxSelectedProduct.Size = new System.Drawing.Size(586, 204);
            this.textBoxSelectedProduct.TabIndex = 2;
            // 
            // comboBoxWarehouses
            // 
            this.comboBoxWarehouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWarehouses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWarehouses.FormattingEnabled = true;
            this.comboBoxWarehouses.Location = new System.Drawing.Point(104, 478);
            this.comboBoxWarehouses.Name = "comboBoxWarehouses";
            this.comboBoxWarehouses.Size = new System.Drawing.Size(474, 45);
            this.comboBoxWarehouses.TabIndex = 3;
            this.comboBoxWarehouses.SelectedIndexChanged += new System.EventHandler(this.comboBoxWarehouses_SelectedIndexChanged);
            // 
            // dateTimePickerShippingDate
            // 
            this.dateTimePickerShippingDate.Location = new System.Drawing.Point(698, 478);
            this.dateTimePickerShippingDate.Name = "dateTimePickerShippingDate";
            this.dateTimePickerShippingDate.Size = new System.Drawing.Size(586, 31);
            this.dateTimePickerShippingDate.TabIndex = 4;
            // 
            // checkBoxEmailNotification
            // 
            this.checkBoxEmailNotification.AutoSize = true;
            this.checkBoxEmailNotification.Location = new System.Drawing.Point(698, 560);
            this.checkBoxEmailNotification.Name = "checkBoxEmailNotification";
            this.checkBoxEmailNotification.Size = new System.Drawing.Size(324, 29);
            this.checkBoxEmailNotification.TabIndex = 5;
            this.checkBoxEmailNotification.Text = "Enviar notificacion por correo";
            this.checkBoxEmailNotification.UseVisualStyleBackColor = true;
            // 
            // numericUpDownOrderQuantity
            // 
            this.numericUpDownOrderQuantity.Location = new System.Drawing.Point(698, 640);
            this.numericUpDownOrderQuantity.Name = "numericUpDownOrderQuantity";
            this.numericUpDownOrderQuantity.ReadOnly = true;
            this.numericUpDownOrderQuantity.Size = new System.Drawing.Size(586, 31);
            this.numericUpDownOrderQuantity.TabIndex = 6;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(698, 766);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(586, 70);
            this.buttonConfirm.TabIndex = 7;
            this.buttonConfirm.Text = "Confirmar";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(104, 766);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(474, 70);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // CreateOrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.numericUpDownOrderQuantity);
            this.Controls.Add(this.checkBoxEmailNotification);
            this.Controls.Add(this.dateTimePickerShippingDate);
            this.Controls.Add(this.comboBoxWarehouses);
            this.Controls.Add(this.textBoxSelectedProduct);
            this.Controls.Add(this.listBoxProductos);
            this.Controls.Add(this.labelTitle);
            this.Name = "CreateOrderUserControl";
            this.Size = new System.Drawing.Size(1450, 1055);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxProductos;
        private System.Windows.Forms.TextBox textBoxSelectedProduct;
        private System.Windows.Forms.ComboBox comboBoxWarehouses;
        private System.Windows.Forms.DateTimePicker dateTimePickerShippingDate;
        private System.Windows.Forms.CheckBox checkBoxEmailNotification;
        private System.Windows.Forms.NumericUpDown numericUpDownOrderQuantity;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
    }
}
