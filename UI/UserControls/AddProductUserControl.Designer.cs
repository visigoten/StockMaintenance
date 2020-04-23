namespace UI.UserControls
{
    partial class AddProductUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.textBoxProductDescription = new System.Windows.Forms.TextBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Producto";
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(408, 196);
            this.textBoxProductId.Multiline = true;
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(648, 53);
            this.textBoxProductId.TabIndex = 1;
            this.textBoxProductId.Enter += new System.EventHandler(this.textBoxProductId_Enter);
            this.textBoxProductId.Leave += new System.EventHandler(this.textBoxProductId_Leave);
            // 
            // textBoxProductDescription
            // 
            this.textBoxProductDescription.Location = new System.Drawing.Point(408, 326);
            this.textBoxProductDescription.Multiline = true;
            this.textBoxProductDescription.Name = "textBoxProductDescription";
            this.textBoxProductDescription.Size = new System.Drawing.Size(648, 54);
            this.textBoxProductDescription.TabIndex = 2;
            this.textBoxProductDescription.Enter += new System.EventHandler(this.textBoxProductDescription_Enter);
            this.textBoxProductDescription.Leave += new System.EventHandler(this.textBoxProductDescription_Leave);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(408, 484);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.ReadOnly = true;
            this.numericUpDownQuantity.Size = new System.Drawing.Size(648, 31);
            this.numericUpDownQuantity.TabIndex = 3;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.Location = new System.Drawing.Point(396, 586);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(660, 67);
            this.buttonAddProduct.TabIndex = 4;
            this.buttonAddProduct.Text = "Agregar";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(396, 736);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(660, 74);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.textBoxProductDescription);
            this.Controls.Add(this.textBoxProductId);
            this.Controls.Add(this.label1);
            this.Name = "AddProductUserControl";
            this.Size = new System.Drawing.Size(1450, 1055);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.TextBox textBoxProductDescription;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonCancel;
    }
}
