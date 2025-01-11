namespace Lab1
{
    public class Program
    {
        
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to First Lab Assignment");
            Console.WriteLine("------------------------------------");
            Console.Write("Enter which program do you want perform 1]Nth term 2]Find Series 3]Triangle : ");
            int chioce = int.Parse(Console.ReadLine());
            if (chioce == 1)
            {
                NTermNumber nth = new NTermNumber();
                nth.PrintData();
            }
            else if (chioce == 2)
            {
                SeriesNumber s = new SeriesNumber();
                s.GetData();
            }
            else if (chioce == 3)
            {
                Triangle t = new Triangle();
                t.GetData();

            }
            
        }
    }
}
