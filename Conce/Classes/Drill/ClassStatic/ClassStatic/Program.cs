using System.Collections.Concurrent;

namespace ClassStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Types of Member STATIC!\n");

            Forest.PrintTreeFacts();

            Console.WriteLine(Math.PI);

            Console.WriteLine(Math.Abs(-32));

            if (args.Length > 0)
            {
                string mainPhrase = String.Join(" and ", args);
                Console.WriteLine($"My favorite fruits are {mainPhrase}!");
            }

            Console.WriteLine(Forest.ForestsCreated);

            Forest amazon = new Forest("Amazon");
            Forest amazon2 = new Forest("Austrail-Amazon");

            Console.WriteLine(Forest.ForestsCreated);

            foreach (var item in collection)
            {
                Console.WriteLine();
            }
        }
    }
}
