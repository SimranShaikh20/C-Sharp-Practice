using System;

namespace FruitSelectionApp
{
  
    public class FruitDetail
    {
        public string f_name { get; set; }
    }

    
    public class UserInput : FruitDetail
    {
        public void PrintData()
        {
            Console.WriteLine($"You have selected {f_name}");
        }
    }

  
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInput userInput = new UserInput();

            Console.WriteLine("Enter the name of the fruit:");
            userInput.f_name = Console.ReadLine();

            userInput.PrintData();
        }
    }
}
