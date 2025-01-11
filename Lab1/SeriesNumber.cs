using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    
    internal class SeriesNumber
    {
        static bool IsArithmeticSeries(int x, int y, int z)
        {
            return (y - x) == (z - y);
        }

        public void GetData()
        {
            Console.WriteLine("\nTask 2: Check if 3 numbers are in Arithmetic Series");
            Console.Write("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int z = int.Parse(Console.ReadLine());
            if (IsArithmeticSeries(x, y, z))
                Console.WriteLine("The numbers are in an arithmetic series.");
            else
                Console.WriteLine("The numbers are NOT in an arithmetic series.");

        }

    }
}
