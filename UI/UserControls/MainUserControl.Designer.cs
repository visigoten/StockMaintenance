namespace UI.UserControls
{
    partial class MainUserControl
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
            this.title = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonViewProducts = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCrearOrden = new System.Windows.Forms.Button();
            this.buttonViewOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(588, 68);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(279, 42);
            this.title.TabIndex = 0;
            this.title.Text = "Menu Principal";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.Location = new System.Drawing.Point(544, 158);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(343, 103);
            this.buttonAddProduct.TabIndex = 1;
            this.buttonAddProduct.Text = "Agregar Producto";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonViewProducts
            // 
            this.buttonViewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewProducts.Location = new System.Drawing.Point(544, 344);
            this.buttonViewProducts.Name = "buttonViewProducts";
            this.buttonViewProducts.Size = new System.Drawing.Size(343, 80);
            this.buttonViewProducts.TabIndex = 2;
            this.buttonViewProducts.Text = "Ver productos";
            this.buttonViewProducts.UseVisualStyleBackColor = true;
            this.buttonViewProducts.Click += new System.EventHandler(this.buttonViewProducts_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(544, 800);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(343, 86);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCrearOrden
            // 
            this.buttonCrearOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearOrden.Location = new System.Drawing.Point(544, 500);
            this.buttonCrearOrden.Name = "buttonCrearOrden";
            this.buttonCrearOrden.Size = new System.Drawing.Size(343, 88);
            this.buttonCrearOrden.TabIndex = 4;
            this.buttonCrearOrden.Text = "Crear una orden";
            this.buttonCrearOrden.UseVisualStyleBackColor = true;
            this.buttonCrearOrden.Click += new System.EventHandler(this.buttonCrearOrden_Click);
            // 
            // buttonViewOrders
            // 
            this.buttonViewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewOrders.Location = new System.Drawing.Point(544, 642);
            this.buttonViewOrders.Name = "buttonViewOrders";
            this.buttonViewOrders.Size = new System.Drawing.Size(343, 82);
            this.buttonViewOrders.TabIndex = 5;
            this.buttonViewOrders.Text = "Ver Ordenes";
            this.buttonViewOrders.UseVisualStyleBackColor = true;
            this.buttonViewOrders.Click += new System.EventHandler(this.buttonViewOrders_Click);
            // 
            // MainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonViewOrders);
            this.Controls.Add(this.buttonCrearOrden);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonViewProducts);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.title);
            this.Name = "MainUserControl";
            this.Size = new System.Drawing.Size(1450, 1055);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonViewProducts;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCrearOrden;
        private System.Windows.Forms.Button buttonViewOrders;
    }
}
