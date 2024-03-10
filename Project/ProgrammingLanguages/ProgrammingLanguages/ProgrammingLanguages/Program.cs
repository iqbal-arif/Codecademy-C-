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

            //C# RELEASED ON

            var cSharp = languages.Where(x => x.Name =="C#").Select(x => x.Prettify()).ToList();

            foreach (var cs in cSharp)
            {
                Console.WriteLine(cs);
            }

            //MICROSOFT DEVELOPED LANGUAGES

           // var msLanguages = languages.Where(x => x.ChiefDeveloper == "Microsoft").Select(x => x.Prettify()).ToList();

            var msLanguages = languages.Where(name => name.ChiefDeveloper.Contains("Microsoft")).Select(x => x.Prettify()).ToList();
            foreach(var ms in msLanguages)
            {
                Console.WriteLine(ms);
            }

            // OTHER LAGUAGES BASED ON THIS LANGUAGE

            //var lispLanguages = languages.Where(x => x.Predecessors == "Lisp").Select(x => x.Prettify()).ToList();
            var lispLanguages = languages.Where(name => name.Name.Contains("Lisp")).Select(x => x.Prettify()).ToList();

            foreach( var lisp in lispLanguages)
            {
                Console.WriteLine(lisp);
            }

            //LANGUAGES WITH "S" SCRIPT NAME

            var scriptLanguages = languages.Where(name => name.Name.Contains("Script")).Select(name => name.Name);

            foreach (var script in scriptLanguages)
            {
                Console.WriteLine(script);
            }


            //TOTAL NUMBER OF LANGUAGES

            var totalLanguages = languages.Count;

            Console.WriteLine(totalLanguages);

            //TOTAL NUMBER OF LANGUAGES BETWEEN 1995-2005

            var from1995To2005Languages = languages.Where(year => year.Year >= 1995 && year.Year <= 2005).Count();

            Console.WriteLine(from1995To2005Languages);






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
