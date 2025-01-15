using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_System
{
    public class ProductData

    {
        public void printdata()
        {
            Console.WriteLine("Welcome to Product Inventory System ");
        }
    }

    public class Product:ProductData
    {
        public void GetData()
        {
            Console.WriteLine("Enter what operation to be perform ");
            Console.WriteLine("1]Add Item");
            Console.WriteLine("2]Update Stock");
            Console.WriteLine("3]Display Stock based on your chioce");
            int chioce=int.Parse(Console.ReadLine());
           
        }
    }
}
