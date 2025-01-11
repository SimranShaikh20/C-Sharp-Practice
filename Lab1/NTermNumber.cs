using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class NTermNumber
    {
        public static int findterm(int a, int d, int n)
        {
            return a + (n - 1) * d;
        }
        public void PrintData()
        {
            Console.WriteLine("Task 1: Find Nth Term in Arithmetic Series");
            Console.Write("Enter first term (a): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter common difference (d): ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter term number (n): ");
            int n = int.Parse(Console.ReadLine());
            int nthTerm = findterm(a, d, n);
            Console.WriteLine($"The {n}th term is: {nthTerm}");
        }
    }
}
