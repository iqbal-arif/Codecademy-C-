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

/*
Converting DataType
*******
One example of when we have to use conversions is when we ask a user to input a numerical value. Even if that value is an integer or a decimal, Console.ReadLine() will always return a string.

Let’s write a program that asks a learner for their favorite number and see if we can implicitly convert their response to an int.

To start, below the Console.Write() statement, create an int variable named faveNumber and set it equal to Console.ReadLine().

To run the program, press the Run button to save your work, then type dotnet run into the console.
Program: How old are you? User: 16 Program: You are 16 years old!
Checkpoint 2 Passed

2.

Hmm. That didn’t work. Instead, we got the error message:
error: cannot implicitly convert type 'string' to 'int'. The build failed. Please fix the build errors and run again.

Looks like we’re going to have to cast their response as an int some other way!

Try explicitly casting the value of faveNumber as an int and rerun the program. What happens this time?

To explicitly cast a value as an int:

int variableName = (int)value;

Checkpoint 3 Passed

3.

If you tried dotnet run again, you’ll see that (int) didn’t work either. That’s because it is not possible to explicitly convert a string into an int (or vice versa) in C#. This time, let’s try using a built-in method to do the conversion.

Look at this article on converting strings to int. It lists a few of the methods in the Convert class, including: Convert.ToInt32(). This method takes a string and outputs an integer. Let’s try it!

Delete the explicit casting (int) from the code editor. Add the Convert.ToInt32() method so that it takes the user input as a string.

Run the code again. Did you run into any errors?

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

        //Data Type Conversion

         // Ask user for fave number
        Console.Write("Enter your favorite number!: ");
        int faveNumber = Convert.ToInt32(Console.ReadLine());

        //Char and String DataType
        string drink = "wine";
      string madTeaParty = $"\"Have some {drink},\" the March Hare said in an encouraging tone. \nAlice looked all round the table, but there was nothing on it but tea.\n\"I don't see any {drink},\" she remarked.\n\"There isn't any,\" said the March Hare.";

      int storyLength = madTeaParty.Length;
      string toFind = "March Hare";

      string findLowerCase = toFind.ToLower(); 
      int findMarchHare = madTeaParty.IndexOf(toFind);

      Console.WriteLine(madTeaParty.Substring(findMarchHare));
      Console.WriteLine($"This scene is {storyLength} long.\n");
      Console.WriteLine($"The term we're looking for is {toFind} and is located at index {findMarchHare}.");


      // Parts of Strings
      // dna strand
      string startStrand = "ATGCGATGAGCTTAC";

           // find location of "tga"
      int tga = startStrand.IndexOf("TGA");
      Console.WriteLine(tga);
      // start point and stop point variables

    int startPoint = 0;
    int length = tga + 3;

      // define final strand

    string dna = startStrand.Substring(startPoint, length);

      Console.WriteLine(dna);

      // DNA mutation search

      int charPosition = dna.IndexOf("C"); 
      char C = dna[charPosition];
      Console.WriteLine(C);

      // Manipulate Strings

       // Script line
      string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

      // Get camera directions
      int charPosition2 = script.IndexOf("Close");
      int length2 = "Close on".Length;
      string cameraDirections = script.Substring(charPosition2, length2);

      // Get scene description
      charPosition = script.IndexOf("a portrait");
      string sceneDescription = script.Substring(charPosition);

      // Make camera directions uppercase

      cameraDirections = cameraDirections.ToUpper();


      // Make scene description lowercase

      sceneDescription = sceneDescription.ToLower();
      // Print results

      Console.WriteLine(cameraDirections);
      Console.WriteLine(sceneDescription);

    int speed = 65;
    double specified = speed;



            //STRING EXCEPTION

            string firstString = "immutable";
            string secondString = "immutable";

            //With ==, strings are tested for value equality, not referential equality.

            Console.WriteLine(firstString == secondString); //True


            Console.WriteLine(String.Compare(firstString, secondString));

            Object firstObject = new Object();
            Object secondObject = new Object();

            Console.WriteLine(firstObject == secondObject);

            //STRING CAN BE NULL OR EMPTY OR UNASSIGNED

            Console.WriteLine("Enter something");
            string userInput = Console.ReadLine();

            if (!String.IsNullOrEmpty(userInput))
            {
                Console.WriteLine(userInput);
            }
            else
            {
                Console.WriteLine("You didn't enter anything!");
            }


            //STRING AS CLASS

            string lyrics =
        "Dollie, Dollie, bo-bollie,\n" +
        "Banana-fana fo-follie\n" +
        "Fee-fi-mo-mollie\n" +
        "Dollie!";

            // Call `Replace()` here

            lyrics.Replace("ollie", "ana");


            Console.WriteLine(lyrics);

            Random rand = new Random();
            Object orand = rand;
            rand.Next(0, 1);
            //orand.Next(0, 1);

            Object sc = null;
            Object oc;
            Console.WriteLine(sc == null);

            Console.ReadLine();
        }
  }
}