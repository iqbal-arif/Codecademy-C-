// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Methods!\n");

// using System;

namespace IntroMethodOutput
{
  class Program
  {
    static void Main(string[] args)
    {
      // Call a method with multiple arguments
      NamePets("Laika", "Albert");
      // Call a method with named arguments
      VisitPlanets(numberOfPlanets: 8);
      // CALL A METHOD and RETURN / DISPLAY its value
      Console.WriteLine(DecoratePlanet("Jupiter"));

    //OUT PARSING
      
      string ageAsString = "102";
      string nameAsString = "Granny";
      int ageAsInt;
      bool outcome;

      outcome = Int32.TryParse(ageAsString, out ageAsInt);

      Console.WriteLine(ageAsInt);
      Console.WriteLine(outcome);

      int nameAsInt;
      bool outcome2;

      outcome2 = Int32.TryParse( nameAsString, out nameAsInt);

      Console.WriteLine(nameAsInt);
      Console.WriteLine(outcome2);



    }
    
    // Define a method with multiple parameters
    static void NamePets(string pet1, string pet2)
    {
      Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
    }  
 
    // Define a method with optional parameters
    static void VisitPlanets(
      string adjective = "brave",
      string name = "Cosmonaut", 
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
    //METHOD WITH RETURN
    static string DecoratePlanet(string planetName)
    {
      return ($"Welcome to {planetName}");
    }


    static string Whisper (string phrase, out bool)
    {
        return string;
    }


  }
}