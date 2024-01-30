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

      var goldCoin = 10;
      var silverCoin = 5;

      double goldCoins = Math.Floor( userInput / goldCoin );

      double goldRemainder = userInput % goldCoin ;
      

      
      double silverCoins = Math.Floor( goldRemainder / silverCoin );

      double silverRemainder = goldRemainder % silverCoin ;

      
      Console.WriteLine($"{userInput} is equal to !");
      Console.WriteLine($"Gold coins : {goldCoins}");
      Console.WriteLine($"Silver coins : {silverCoins}");
      Console.WriteLine($"Bronze coins : {silverRemainder}");
     

    }
  }
}