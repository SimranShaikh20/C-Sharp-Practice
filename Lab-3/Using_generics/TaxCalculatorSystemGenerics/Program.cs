using TaxCalculatorSystem;  // Add this line

namespace TaxCalculatorSystemGenerics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter environment (test/real): ");
            string environment = Console.ReadLine()?.ToLower();

            // Using a generic method to get user data
            var userDetails = environment == "test" ? GetUserData<TestUserData>() : GetUserData<RealUserData>();

            double tax = Calculation.CalculateTax(userDetails.Item3, userDetails.Item4);
            Console.WriteLine($"\n{userDetails.Item1}, your tax for the year is: {tax:C}");
        }

        // Generic method that can handle both Test and Real user data
        public static (string, string, double, double) GetUserData<T>() where T : IGetUserData, new()
        {
            T instance = new T();
            return instance.GetData();
        }
    }
}
