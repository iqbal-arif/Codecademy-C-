using System.Security.Cryptography.X509Certificates;

namespace ProgrammingLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programming SLanguages!\n");
            
            List<Language> languages = File.ReadAllLines("./languages.tsv") // holds the list in database
                .Skip(1) // skips the header that is the first element in database
                .Select(line => Language.FromTsv(line)) // creating instance of each line in database from class Languge and stroing in the list languages
                .ToList();

            //PRINT ALL LANGUAGES THROUGH PREITIFY METHOD
            
                        foreach (Language language in languages)
                        {
                            Console.WriteLine(language.Prettify());

                        }


             // LISTING EACH LANGUAGE EVERY
            
            //QUERY EXPRESSION : Instructor
            var basicInfos = languages.Select(l => $"{l.Year}  {l.Name}  {l.ChiefDeveloper}  {l.Predecessors}");

            foreach (var item in languages)
            {
                Console.WriteLine($"{item.Year}  {item.Name}  {item.ChiefDeveloper}  {item.Predecessors}");
            }

            //C# RELEASED ON

            //QUERY EXPRESSION : Instructor
            
            var cSharplangs = languages.Where(x => x.Name =="C#");

            var cSharp = languages.Where(x => x.Name =="C#").Select(x => x.Prettify()).ToList();

            foreach (var cs in cSharp)
            {
                Console.WriteLine(cs);
            }

            //MICROSOFT DEVELOPED LANGUAGES

            //QUERY EXPRESSION : Instructor

            var microsoftLangs = languages.Where(name => name.ChiefDeveloper.Contains("Microsoft"));


            var msLanguages = languages.Where(name => name.ChiefDeveloper.Contains("Microsoft")).Select(x => x.Prettify()).ToList();
            foreach(var ms in msLanguages)
            {
                Console.WriteLine(ms);
            }

            // OTHER LAGUAGES BASED ON THIS LANGUAGE

            //QUERY EXPRESSION : Instructor
            
            var lispLang = languages.Where(name => name.Predecessors.Contains("Lisp"));

            //var lispLanguages = languages.Where(x => x.Predecessors == "Lisp").Select(x => x.Prettify()).ToList();
            var lispLanguages = languages.Where(name => name.Name.Contains("Lisp")).Select(x => x.Prettify()).ToList();

            foreach( var lisp in lispLanguages)
            {
                Console.WriteLine(lisp);
            }

            //LANGUAGES WITH "S" SCRIPT NAME

            //QUERY EXPRESSION : Instructor

            var scriptLang = languages.Where(script => script.Name.Contains("Script")).Select(languages => languages.Name);

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

            // NEAR-MILLENNIUM LANGUAGES
            //QUERY EXPRESSION : Instructor
            var nearMilleniumLanges = languages
                .Where(x => x.Year >= 1995 && x.Year <= 2005)
                .Select(x => $"{x.Name} was invented in {x.Year}");
            foreach (var lang in nearMilleniumLanges)
            {
               // Console.WriteLine(lang);
            }

            var nearMillenniumLanguages = languages.Where(language => language.Year <= 2000).Select(language => $"{language.Name.ToUpper()} was invented in {language.Year}");

            foreach (var millennium in nearMillenniumLanguages)
            {
                Console.WriteLine(millennium);
            }

            //PRETTYPRINTALL() METHOD WITH IEnumerable argument


            PrettyPrintAll(lispLang);

            //ORDER QUERY IN ALPHABETICAL ORDER

            var ordered = languages.OrderBy(language => language.Name);

            PrettyPrintAll(ordered);

            //OLDEST LANGUAGE QUERY

            var oldest = languages.Min(language => language.Year);

            Console.WriteLine(oldest);

            //PRINTALL() METHOD WITH IEnumerable argument

            PrintAll(nearMillenniumLanguages);

            

                      
       


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
            //PRETTYPRINTALL() METHOD WITH IEnumerable argument

          public  static void PrettyPrintAll(IEnumerable<Language> langs)
            {
                foreach (var language in langs)
                {
                    Console.WriteLine(language.Prettify());
                }
            }


        //PRINTALL() METHOD WITH IEnumerable argument

        public static void PrintAll(IEnumerable<Object> sequence)
        {
            foreach (Object obj in sequence)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
