// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

 /*
      This program .takes user inputs and fills in the story
      Author:Codecademy
      */


      // Let the user know that the program is starting:

Console.WriteLine("Mad Libs has started");

      // Give the Mad Lib a title:
      string title = "Guess The Story";

      Console.WriteLine(title);
      // Define user input and variables:

Console.Write("Enter a name:");
string name = Console.ReadLine();
// Console.Write("Enter a name of Super Hero:");
// string superHero = Console.ReadLine();
Console.Write("Enter first Adjective:");
string firstAdj = Console.ReadLine();
Console.Write("Enter Second Adjective:");
string secondAdj = Console.ReadLine();
Console.Write("Enter Third Adjective:");
string thirdAdj = Console.ReadLine();
Console.Write("Enter The Verb:");
string verb = Console.ReadLine();
Console.Write("Enter The Frist Noun:");
string firstNoun = Console.ReadLine();
Console.Write("Enter The Second Noun:");
string secondNoun = Console.ReadLine();

var animal = "An Animal";
var food = "A Food";
var fruit = "A Fruit";
var superHero = "A SuperHero";
var country = "A Country";
var dessert = "A Dessert";
var year = "A Year";

      // The template for the story:
      string story = $"This morning {name} woke up feeling {firstAdj}. 'It is going to be a {secondAdj} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdj}. Concerned, {name} texted {superHero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";


      // Print the story: