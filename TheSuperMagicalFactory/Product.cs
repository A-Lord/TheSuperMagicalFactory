using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperMagicalFactory
{
    public class Product : Inventory
    {
        public string SerialNumber {  get; private set; }

        public Product(string name) : base(name)
        {
            SerialNumber = new Guid().ToString();
            //need to read up on Guid.
        }
    }
}
