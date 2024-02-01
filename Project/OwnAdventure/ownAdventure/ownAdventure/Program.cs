// See https://aka.ms/new-console-template for more information

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            Console.Write("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
            Console.Write("Type YES ro NO");

            string noiseChoice = Console.ReadLine().ToUpper() ?? "";
            Console.WriteLine($"{name} entered {noiseChoice}");

        }
    }
}