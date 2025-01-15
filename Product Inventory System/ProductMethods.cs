using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_System
{
    public class ProductMethods
    {
        public class AddItem
        {
            public void GetData()
            {
                Console.Write("Enter item name to add : ");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter price of{name} : ");
                int price=int.Parse( Console.ReadLine() );
                Console.WriteLine("Item Added");
                Console.WriteLine("---------------------");
            }
        }
        public class UpdateItem:AddItem
        {
            
        }
    }
}
