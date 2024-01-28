// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

 /*
      This program .takes user inputs and fills in the story
      Author:Codecademy
      */


      // Let the user know that the program is starting:

Console.WriteLine("Mad Libs has started");

      // Give the Mad Lib a title:
      string title = "Chilling Story";

      Console.WriteLine(title);
      // Define user input and variables:

//string userInput = Console.ReadLine();
Console.Write("Enter a name:");
string name = Console.ReadLine();


      // The template for the story:
      string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


      // Print the story: