// See https://aka.ms/new-console-template for more information

using System;
using System.Xml.Linq;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nPassword Checker!\n");

            int minLength = 8;
            var uppercase = new List<string> { "ABCDEFGHIJKLMNOPQRSTUVWXYZ"};
            var lowercase = new List<string> { "abcdefghijklmopqrstuvwxyz"};
            var specialChars = new List<string> { "~!@#$%^&*)(_+|}{][?><`-" };
            var digits = new List<int> { 1,2,3,4,5,6,7,8,9,10};
           
           
            int score = 0;

            Console.WriteLine("Enter Password!\n");
            string userInput = Console.ReadLine();



            //string.IsNullOREmpty(console.readLine()) ? "Password1":
            //ISNullOREmpty

         
            if(userInput.Length >= minLength) {
                score++;

            }

            
            if (Tools.Contains(userInput,uppercase.ToString())) { 
                score++;
            }
            

            if (Tools.Contains(userInput,lowercase.ToString())) { 
                score++;
            }
            
            if (Tools.Contains(userInput,digits.ToString())) { 
                score++;
            }
            
            if(Tools.Contains(userInput,specialChars.ToString())) { 
                score++;
            }

            Console.WriteLine($"You Entered : {userInput}");
            //Console.WriteLine($"Your Password Score is : {score}");

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Password is EXTERMELY STRONG!!!");
                    break;
                case 3:
                    Console.WriteLine("Password is STRONG!!");
                    break;
                case 2:
                    Console.WriteLine("Password is MEDIUM!");
                    break;
                case 1:
                    Console.WriteLine("Password is WEAK?");
                    break;
                default:
                    Console.WriteLine("Password DOES NOT meet the Standards??");
                    break;
            }


        }
    }
}