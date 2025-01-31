using TaxCalculatorSystemGenerics;

namespace TaxCalculatorSystem
{
    public class RealUserData : IGetUserData
    {
        public (string, string, double, double) GetData()
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
