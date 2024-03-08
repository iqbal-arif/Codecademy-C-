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
        }
    }
}
