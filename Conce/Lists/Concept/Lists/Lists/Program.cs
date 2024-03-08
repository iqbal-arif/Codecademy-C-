namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn Lists!\n");

            List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };

            citiesList.Add("New York City");

            citiesList.Remove("Delhi");

            citiesList.AddRange(new string[] { "Cairo", "Johannesburg" });

            bool hasNewDelhi = citiesList.Contains("New Delhi");

            foreach (string city in citiesList)
            {
                Console.WriteLine(city);
            }

            List<double> marathons = new List<double>();

            marathons.Add(144.07);
            marathons.Add(143.12);

            Console.WriteLine(marathons[1]);

            //LIST DECLARTION AND INITIALIZATION

            var marathon = new List<double> { 144.07, 143.12, 146.73, 146.33 };

            double time = marathon[1];

            Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");

            Console.WriteLine(marathons.Count);

            marathons.Add(143.23);

            Console.WriteLine(marathons.Contains(143.23));

            Console.WriteLine(marathons.Count);

            Console.WriteLine(marathons[1]);

            bool removed = marathons.Remove(143.12);

            Console.WriteLine(marathons[1]);
            Console.WriteLine(removed);

            marathons.Clear();
            Console.WriteLine($"Count: {marathons.Count}");

            //LIST RANGE

            List<double> marathonRange = new List<double>
            {
                144.07,
                143.12,
                146.73,
                146.33
            };

            Console.WriteLine();

            List<double> newRange = marathonRange.GetRange(0, 3);

            foreach (double value in newRange)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();


            //LOOPING THROUGH LISTS

            List<string> runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
            Random rand = new Random();

            Console.WriteLine("In reverse chronological order, the gold medalists are...");

            // First loop
            for (int i = 0; i < runners.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {runners[i]}");
            }

            Console.WriteLine("\nPrinting runner bibs...");

            // Second loop

            foreach (var list in runners)
            {

                string name = list.ToUpper();
                int id = rand.Next(100, 1000);
                Console.WriteLine($"{id} - {name}");

            }

            //GENERIC COLLECTIONS

           List<bool> isList = new List<bool>();
           List<Random> random = new List<Random>();
           List< IServiceProvider >  listType = new List<IServiceProvider >();

            // Adding an item

            List<string> cityList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };

            cityList.Add("Chicago");

            foreach(var city in cityList) { Console.WriteLine(city); }


            Console.ReadLine ();

        }
    }
}
