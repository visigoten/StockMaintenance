using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class InvalidProductException : Exception
    {
        public string Attribute { get; private set; }
        public string Error { get; private set; }

        public InvalidProductException(string attribute, string error)
        {
            this.Attribute = attribute;
            this.Error = error;
        }
    }
}
