using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ApplicationRepository
    {
        public static ApplicationRepository Instance { get; } = new ApplicationRepository();

        private List<Product> products;
        private List<Warehouse> warehouses;

        private ApplicationRepository()
        {
            this.products = new List<Product>();
            this.warehouses = new List<Warehouse>
            {
                new Warehouse() { Name = "Deposito Central" },
                new Warehouse() { Name = "Deposito Zona Sur" }
            };
        }

        public List<Product> GetAllProducts()
        {
            return this.products;
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public List<Warehouse> GetAllWarehouses()
        {
            return this.warehouses;
        }
    }
}
