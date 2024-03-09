
using System.Linq;


namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn LINQ!\n");

            List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

            // Approach 1: without LINQ
            List<string> longLoudHeroes = new List<string>();

            foreach (string hero in heroes)
            {
                if (hero.Length > 6)
                {
                    string formatted = hero.ToUpper();
                    longLoudHeroes.Add(formatted);
                }
            }

            // Approach 2: with LINQ
            var longLoudHeroes2 = from h in heroes
                                  where h.Length > 6
                                  select h.ToUpper();

            // Printing...
            Console.WriteLine("Your long loud heroes are...");

            foreach (string hero in longLoudHeroes2)
            {
                Console.WriteLine(hero);
            }


            var shortHeroes = from h in heroes where h.Length < 8 select h; 

            foreach (string hero in shortHeroes)
            {
                Console.WriteLine(hero);
            }

            var longHeroes = heroes.Where(n =>  n.Length > 8);

            Console.WriteLine(longHeroes.Count());

        }
    }
}
