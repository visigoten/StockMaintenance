using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Product
    {
        public string Id
        {
            get { return this._id; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidProductException("ProductId", "No puede ser vacio");
                }
                this._id = value;
            }
        }

        public string Description { get; set; }

        public int Quantity { get; set; }

        private string _id;

        public override string ToString()
        {
            return this.Id;
        }
    }
}
