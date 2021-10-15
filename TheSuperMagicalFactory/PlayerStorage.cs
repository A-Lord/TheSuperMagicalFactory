using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperMagicalFactory
{
    public abstract class PlayerStorage
    {
        protected List<Inventory> Items;

        protected PlayerStorage()
        {
            Items = new List<Inventory>();
        }

        public void AddItems(List<Inventory> items)
        {
            Items.AddRange(items);
        }
        
        public void RemoveItem(Inventory item)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name == item.Name)
                {
                    Items.RemoveAt(i);
                    return;   //when we find the item to remove we want the remove the return will stop the loop as we got our item already

                }
            }
        }

        public void RemoveItems(List<Inventory> items)  //if you want to remove more then 1 item u send a list and it will use the function that removes
        {                                                   //one item for every item in the list you want to remove.
        foreach (Inventory item in items)
            {
                RemoveItem(item);
            }
        }

        public List<Inventory> MoveAll()
        {
            List<Inventory> itemsToMove = Items.ToList();
            Items.Clear(); //copies to list from here to a new list then clears the items list and sends the copied list in return

            return itemsToMove;
        }

        public int CountCurrentInventory() 
        {
            return Items.Count;
        }

        public void ShowInventoryList()
        {
            Console.WriteLine($"--- Current {this.GetType().Name} inventory ---");
            int indexNr = 1;
            foreach (Inventory item in Items)
            {
                Console.WriteLine($"{indexNr} - {item.Name}");
                indexNr++;
            }
            Console.WriteLine("$--- End ---");
        }
    }
}
