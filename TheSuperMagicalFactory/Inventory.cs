using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperMagicalFactory
{
    public abstract class Inventory
    {
        public string Name {  get; protected set; }
        protected Inventory(string name)
        {
            Name = name;
        }

    }
}
