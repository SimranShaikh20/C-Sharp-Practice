namespace SimpleCalculator
{
    internal class Program
    {
        public static void sum(int n1, int n2)
        {
            Console.WriteLine($"Addition of {n1} and {n2} is {n1 + n2}");
        }
        public static void sub(int n1, int n2)
        {
            Console.WriteLine($"Subtraction of {n1} and {n2} is {n1 - n2}");
        }
        public static void mul(int n1, int n2)
        {
            Console.WriteLine($"Multiplication of {n1} and {n2} is {n1 * n2}");
        }
        public static void div(int n1, int n2)
        {
            if (n2 != 0)
                Console.WriteLine($"Division of {n1} and {n2} is {n1 / n2}");
            else
                Console.WriteLine("Division by zero is not allowed.");
        }
        public static void modu(int n1, int n2)
        {
            Console.WriteLine($"Modulus of {n1} and {n2} is {n1 % n2}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Users!");

            Console.WriteLine("Enter number1:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2 :");
            int n2 = Convert.ToInt32(Console.ReadLine());

            string continueCalculation;

            do
            {
                Console.WriteLine("Which operation do you want to perform?");
                Console.WriteLine("1- Addition\n2- Subtraction\n3- Multiplication\n4- Division\n5- Modulus");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        sum(n1, n2);
                        break;
                    case 2:
                        sub(n1, n2);
                        break;
                    case 3:
                        mul(n1, n2);
                        break;
                    case 4:
                        div(n1, n2);
                        break;
                    case 5:
                        modu(n1, n2);
                        break;
                    default:
                        Console.WriteLine("....Select a Proper Option...");
                        break;
                }

                Console.WriteLine("Do you want to perform another operation? (yes/no):");
                continueCalculation = Console.ReadLine().ToLower();

            } while (continueCalculation == "yes");

            Console.WriteLine("Thank you for using the calculator!");
        }
    }
}
