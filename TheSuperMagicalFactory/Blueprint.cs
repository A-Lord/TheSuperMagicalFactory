using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperMagicalFactory
{
    public class Blueprint
    {
        public Dictionary<string, int> ItemsToCheck {  get; private set; }

        public List<Inventory> ItemsToProduce { get; private set;  }

        public string Name {  get; protected set; }

        public Blueprint(List<Inventory> items,string name)
        {
            Name = name;

            ItemsToProduce = items;

            ItemsToCheck = new Dictionary<string, int>();

            foreach (Inventory item in items)
            {
                if (ItemsToCheck.ContainsKey(item.Name))  //cheks if we have the product in our dictionary list , if its in there we add 1 to it else we add it to the list.
                {
                    ItemsToCheck[item.Name] += 1;
                }
                else
                {
                    ItemsToCheck.Add(item.Name, 1);
                }
            }
        }

        public bool IsComponentsFit(List<Inventory> items)
        {
            bool isEnough = false;
            foreach (var entry in ItemsToCheck)
            {
                isEnough = entry.Value <= items.Count(m => m.Name.Contains(entry.Key));
            }
            return isEnough;
        }
    }
}
