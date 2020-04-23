using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Warehouse
    {
        public string Name { get; set; }

        private List<Order> orders;

        public Warehouse()
        {
            this.orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            this.orders.Add(order);
        }

        public List<Order> GetOrders()
        {
            return this.orders;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
