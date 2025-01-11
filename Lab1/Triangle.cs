using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Triangle
    {
        public  void GetData()
        {
            Console.WriteLine("Enter the three sides of the triangle:");

            Console.Write("Side 1: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Side 2: ");
            double side2 = double.Parse(Console.ReadLine());

            Console.Write("Side 3: ");
            double side3 = double.Parse(Console.ReadLine());
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides); 

            double a = sides[0], b = sides[1], c = sides[2];
            if (a + b > c)
            {
                Console.WriteLine("The sides form a valid triangle.");

                double aSquared = Math.Pow(a, 2);
                double bSquared = Math.Pow(b, 2);
                double cSquared = Math.Pow(c, 2);

                if (Math.Abs(aSquared + bSquared - cSquared) < 1e-9) 
                {
                    Console.WriteLine("It is a Right-Angled Triangle.");
                }
                else if (aSquared + bSquared > cSquared) 
                {
                    Console.WriteLine("It is an Acute-Angled Triangle.");
                }
                else 
                {
                    Console.WriteLine("It is an Obtuse-Angled Triangle.");
                }

               
                if (a == b && b == c)
                {
                    Console.WriteLine("It is an Equilateral Triangle.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("It is an Isosceles Triangle.");
                }
                else
                {
                    Console.WriteLine("It is a Scalene Triangle.");
                }
            }
            else
            {
                Console.WriteLine("The sides do not form a valid triangle.");
            }
        }
    }
}
