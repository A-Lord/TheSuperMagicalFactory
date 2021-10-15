using System;

namespace TheSuperMagicalFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Lets start!");

            bool programIsActive = true;
            var warehouse = new Warehouse();
            var factory = new Factory();

            while (programIsActive)
            {
                warehouse.ShowInventoryList();
            }

        }
    }
}
