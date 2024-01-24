// See https://aka.ms/new-console-template for more information

/*
1.

To practice creating variables, we’re going to write a program that prints information about a dog to the console. We’ll be working with the types string, int, double, and bool.

First, create two string variables. The first one is called name and has the value "Shadow".
The second one is called breed and has the value "Golden Retriever".
Checkpoint 2 Passed

2.

Next, create a variable to hold the age. Name the variable age and store the value 5.
Checkpoint 3 Passed

3.

Next, create a variable to hold the weight. Name the variable weight and store the value 65.22.
Checkpoint 4 Passed

4.

Next, create a variable that can be either true or false. Name the variable spayed and set it to true.
Checkpoint 5 Passed

5.

Use Console.WriteLine() to print each variable to the console.

*/

namespace CSharpFundamentals
{
   class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Data Types and Variables!\n");
      // Create Variables
        string name = "Shadow";
        string breed = "Golden Retriever";
        int age = 5;
        double weight = 65.22;
        bool spayed = true;

            // Print variables to the console
        Console.WriteLine(name);
        Console.WriteLine(breed);
        Console.WriteLine(age);
        Console.WriteLine(weight);
        Console.WriteLine(spayed);


    }
  }
}