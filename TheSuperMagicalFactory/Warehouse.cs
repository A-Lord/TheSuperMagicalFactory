using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperMagicalFactory
{
    public class Warehouse : PlayerStorage
    {
        public Warehouse()
        {
            Items = new List<Inventory>
            {
                new Material("Iron"),
                new Material("Iron"),
                new Material("Rubber")
            };
        }
    }
}
