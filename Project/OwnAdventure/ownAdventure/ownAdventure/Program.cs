// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

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

            Console.Write("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?\n");
            Console.Write("Type YES ro NO : \t");

            string noiseChoice = Console.ReadLine().ToUpper() ?? "";
            Console.WriteLine($"{name} entered {noiseChoice}");

            if (noiseChoice == "NO")
            {

                    Console.WriteLine("Not much of an adventure if we don't leave our room!\n THE END");
            }
            else if (noiseChoice == "YES")
            {
                    Console.WriteLine("You walk into the hallway and see alight coming from under a door down the hall. Yo walk towards it. Do you open it or knock?\n");

                    Console.WriteLine("Type OPEN or KNOCK : ");
                    string doorChoice = Console.ReadLine().ToUpper();

                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind teh door speaks. It says, \"Answer this riddle:\"\n \"Poor people have it . Rich people need it. If you eat it you die. What is it?\n");
                    string riddleAnswer = Console.ReadLine().ToUpper();
                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine($"The door opens and {riddleAnswer} is there.\n You turn off the light and run back to our room and lock the door.\n THE END.");
                    }
                    else if (riddleAnswer != "NOTHING") {
                        Console.WriteLine("You answered incorrectly. The door doesn't open. THE END");
                    }
                                
                }else if (doorChoice == "OPEN")
                    {
                        Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                        Console.WriteLine("Enter a number (1-3) :\n");
                        string keyChoice = Console.ReadLine();

                        switch (keyChoice)  
                        {
                            case "1":
                                Console.WriteLine("You choose the first key.\n Lucky choice!\n The door opens and NOTHING is ther. Strange...\n THE END.");
                                break;

                                case "2":
                                Console.WriteLine("You choose the second key. \n The door doesn't open.\n THE END.\n");
                                break;
                                case "3":
                                Console.WriteLine("You choose the third key.\n The dor doesn't open.\n THE END.\n");
                                break;
                            default:
                                break;
                        }
                    }
            }
           






        }
    }
}