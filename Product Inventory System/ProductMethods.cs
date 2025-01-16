using System;

namespace Product_Inventory_System
{
    public class ProductMethods
    {
        public class AddItem
        {
            public int price { get; set; }
            public string name { get; set; }

            public void GetData()
            {
                Console.Write("Enter item name to add: ");
                name = Console.ReadLine();
                Console.Write($"Enter price of {name} : ");
                price = int.Parse(Console.ReadLine());
                Console.WriteLine("Item Added");
                Console.WriteLine("---------------------");
            }
        }

        public class UpdateItem : AddItem
        {
            public int new_price { get; set; }

            public void UpdateData()
            {
                Console.WriteLine("Enter new price of item: ");
                new_price = int.Parse(Console.ReadLine());
                price = new_price;
                Console.WriteLine("Item price updated successfully");
            }
        }

        public class DisplayItem : UpdateItem
        {
            public void ShowData()
            {
                Console.WriteLine($"Item name: {name} ");
                Console.WriteLine($"Item Price: {price} ");
                Console.WriteLine("--------System has successfully completed-----");
            }
        }
    }
}
