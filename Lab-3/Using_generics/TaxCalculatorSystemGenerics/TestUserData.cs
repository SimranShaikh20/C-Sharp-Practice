using TaxCalculatorSystemGenerics;

namespace TaxCalculatorSystem
{
    public class TestUserData : IGetUserData
    {
        public (string, string, double, double) GetData()
        {
            return ("Test User", "Software Engineer", 800000, 150000);
        }
    }
}
