using System;

namespace TaxCalculatorSystem
{
    // Delegate definition is already correct here
    public delegate (string, string, double, double) GetUserData();

    public class Deleget
    {
        // Test Mode Data
        public static (string, string, double, double) TestUserData()
        {
            return ("Test User", "Software Engineer", 800000, 150000);
        }

        // Real Mode Data (User Input)
        public static (string, string, double, double) RealUserData()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Profession: ");
            string profession = Console.ReadLine();

            double earnings = 0;
            while (true)
            {
                Console.Write("Enter Earnings: ");
                if (double.TryParse(Console.ReadLine(), out earnings))
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number for earnings.");
            }

            double investments = 0;
            while (true)
            {
                Console.Write("Enter Investments: ");
                if (double.TryParse(Console.ReadLine(), out investments))
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid number for investments.");
            }

            return (name, profession, earnings, investments);
        }
    }
}
