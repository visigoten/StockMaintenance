using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public DateTime ShippingDate { get; set; }
        public bool SendEmailConfirmation { get; set; }
    }
}
