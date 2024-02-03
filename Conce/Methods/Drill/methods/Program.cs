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
    
    // USING OUT

    string statement = Whisper("YELLING", out bool wasYelled);

    Console.WriteLine(statement);

     Console.WriteLine (wasYelled);

     string statement2 = "GARRRR";
      bool marker;
			string murmur = Whisper2(statement2, out marker);
      Console.WriteLine(murmur);


            // Define variables
      string destination = "Neptune";
      string galaxyString = "8";
      int galaxyInt;
      string welcomeMessage;
      bool outcome3;
      
      // Call DecoratePlanet() and TryParse() here
      welcomeMessage = DecoratePlanet (destination);

      outcome3 = Int32.TryParse(galaxyString, out galaxyInt);
      // Print results
      Console.WriteLine(welcomeMessage);
      Console.WriteLine($"Parsed to int? {outcome}: {galaxyInt}");

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

    //USE OF OUT
    static string Whisper (string phrase, out bool wasYelled)
    {
        wasYelled = true;
        return phrase.ToLower();
    } 

    static string Whisper2(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }

    // Define a method that returns a string
  	static string DecoratePlanet3(string planet)
    {
       return $"*..*..* Welcome to {planet} *..*..*";
    }
    
    // Define a method with out
    static string Whisper3(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }
  }
}