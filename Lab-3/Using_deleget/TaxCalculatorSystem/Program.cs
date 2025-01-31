namespace TaxCalculatorSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter environment (test/real): ");
            string environment = Console.ReadLine()?.ToLower();

            // Correcting the delegate usage to refer to the Deleget class
            GetUserData userDataMethod = environment == "test" ? new GetUserData(Deleget.TestUserData) : new GetUserData(Deleget.RealUserData);
            var userDetails = userDataMethod();

            double tax = Calculation.CalculateTax(userDetails.Item3, userDetails.Item4);
            Console.WriteLine($"\n{userDetails.Item1}, your tax for the year is: {tax:C}");
        }
    }
}
