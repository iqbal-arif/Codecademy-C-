// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
1. Convert the method DaysToRotations() to an expression-bodied definition.
Checkpoint 2 Passed

2. Convert the method Welcome() to an expression-bodied definition.

*/

class Program
  {
    static void Main(string[] args)
    {
      Welcome("Earth");
      double days = 500;
      double rotations = DaysToRotations(days);
      Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s).");
    } 
    
    static double DaysToRotations(double days)=> days / 365;
    
    
    static void Welcome(string planet) => Console.WriteLine($"Welcome to {planet}!");
  }

  /*
1. Array.Find() is another method that takes an array and a method as arguments. Array.Find() calls the method on each element of the array and returns the first element for which the method returns true.

An array adjectives and method IsLong() are defined for you. Call Array.Find() with these two arguments to find the first element in adjectives that is “long”.

Store the returned string in a variable named firstLongAdjective.
*/

 class Program
  {
  	// Method to be used as second argument
   	public static bool IsLong(string word)
    {
      return word.Length > 8;
    }
      
    static void Main(string[] args)
    {
      // Array to be used as first argument
      string[] adjectives = {"rocky", "mountainous", "cosmic", "extraterrestrial"};
     
      // Call Array.Find() and 
      // Pass in the array and method as arguments
      string firstLongAdjective = 
      Array.Find(adjectives,IsLong);
      
      Console.WriteLine($"The first long word is: {firstLongAdjective}.");
    }
  }


  /*
1. Find the line where Array.Exists() is used.

Replace HitGround with a lambda expression that achieves the same result. It should return true if its input equals "meteorite".
  */

class Program
  {
    static void Main(string[] args)
    {
      string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      
      bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");
      
      if (makesContact)
      {
        Console.WriteLine("At least one space rock has reached the Earth's surface!");
      } 
    } 
    
    static bool HitGround(string s)
    {
      return s == "meteorite";
    }
  }

/*
1. Apply the first shortcut to the lambda expression (remove the parameter type).
Checkpoint 2 Passed

2. Apply the second shortcut to the lambda expression (remove the parentheses).

*/


class Program
  {
    static void Main(string[] args)
    {
      string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      bool makesContact = Array.Exists(spaceRocks, s => s == "meteorite");
      if (makesContact)
      {
        Console.WriteLine("At least one space rock has reached the Earth's surface!");
      } 
    } 
  }