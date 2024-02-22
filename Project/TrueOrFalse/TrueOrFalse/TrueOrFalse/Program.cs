namespace TrueOrFalse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("True Or False!\n");

            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below

            var questions = new string[] {"Eggplants are type of berry?", "Eggplants are a species in the nightshade family." };

            var answers = new bool[] {true,false };

            var responses = new bool[answers.Length];   

            if (questions.Length != answers.Length) 
            {
                Console.WriteLine("Warning! ");
            }


            foreach (var question in questions)
            {
                int aksingIndex = 0;
                string input = "";
                bool isBool ;
                bool inputBool ;
                Console.WriteLine(question);
                Console.WriteLine("True or False");
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input , out inputBool);

                


                while (isBool) //false to stop
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine(); 
                    Boolean.TryParse(input , out isBool);
                }
                   Console.WriteLine("Inside While: " + isBool);
                responses[aksingIndex] = isBool;
                aksingIndex ++;
            }
            foreach (var response in responses)
            {

            Console.WriteLine(response);
            }
        }
    }
}
