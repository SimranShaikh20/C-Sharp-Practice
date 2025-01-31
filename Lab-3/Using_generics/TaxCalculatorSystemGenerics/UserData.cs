namespace TaxCalculatorSystem
{
    public interface IGetUserData
    {
        (string, string, double, double) GetData();
    }
}
