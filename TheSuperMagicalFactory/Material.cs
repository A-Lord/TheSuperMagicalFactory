using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperMagicalFactory
{
    public class Material : Inventory
    {
        public Material(string name) : base(name)
        {
            Name = name;
        }
    }
}
