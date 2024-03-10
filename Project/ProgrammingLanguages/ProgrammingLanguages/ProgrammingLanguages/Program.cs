namespace ProgrammingLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming SLanguages!\n");

            List<Language> languages = File.ReadAllLines("./languages.tsv")
                .Skip(1)
                .Select(line => Language.FromTsv(line))
                .ToList();

            //PRINT ALL LANGUAGES THROUGH PREITIFY METHOD
            
                        foreach (Language language in languages)
                        {
                            Console.WriteLine(language.Prettify());

                        }


             // LISTING EACH LANGUAGE EVERY
            foreach (var item in languages)
            {
                Console.WriteLine($"{item.Year}  {item.Name}  {item.ChiefDeveloper}  {item.Predecessors}");
            }



            Console.ReadLine();


            //METHOD VERIFY
            //public Language(int year, string name, string chiefDeveloper, string predecessors)
            //
            /*
            var languageYear = languages.Select(year => year);
            var languageName = languages.Select(name => name);
            var languageChiefDeveloper = languages.Select(chiefDeveloper => chiefDeveloper);
            var languagePredecessors = languages.Select(predecessors => predecessors);
            */

            /*
             * QUERY VERIFY
            var strLanguage = from year in languages
                              from name in languages
                              from chiefDeveloper in languages
                              from predecessors in languages
                              select (year,name,chiefDeveloper,predecessors);
           
           
            foreach (var language in strLanguage)
            {
                Console.WriteLine($"{language.year.Year} ");
                   // $"{ language.name.Name} {language.chiefDeveloper.ChiefDeveloper} {language.predecessors.Predecessors}");
            }

           */





        }
    }
}
