namespace TrueOrFalse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            var questions = new string[] { "Eggplants are type of berry?", "Eggplants are a species in the nightshade family." };

            var answers = new bool[] { true, false };

            var responses = new bool[answers.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning! ");
            }

            int askingIndex = 0;
            int scoringIndex = 0;
            int score = 0;
            foreach (var question in questions)
            {
                string input = "";
                bool isBool;
                bool inputBool;
                Console.WriteLine(question);
                Console.WriteLine("True or False");
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool); //True or False
                // int.TryParse(input , out inputInt); //True or False

                while (!isBool)
                { //false to stop
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
               
                responses[askingIndex] = inputBool;

                if (answers[scoringIndex] == responses[scoringIndex])
                {
                    score++;
                }
                Console.WriteLine("Input : " + responses[askingIndex] + "| Answer : " + answers[scoringIndex]);
                askingIndex++;
                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of {answers.Length} correct!");








        }
    }
}
