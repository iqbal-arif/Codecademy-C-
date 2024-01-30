using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins:");
      var userInput = Convert.ToDouble(Console.ReadLine());


      
      Console.WriteLine($"{userInput} is equal to !");
    }
  }
}