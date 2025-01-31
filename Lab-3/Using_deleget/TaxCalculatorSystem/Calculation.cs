using System;

namespace TaxCalculatorSystem
{
    public class Calculation
    {
        public static double CalculateTax(double earnings, double investments)
        {
            double taxableIncome = earnings - investments;
            if (taxableIncome <= 250000) return 0;
            else if (taxableIncome <= 500000) return taxableIncome * 0.05;
            else if (taxableIncome <= 1000000) return taxableIncome * 0.2;
            else return taxableIncome * 0.3;
        }
    }
}
