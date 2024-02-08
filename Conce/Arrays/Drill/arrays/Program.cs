// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
1. Using an Array method, find the position for the first 3-star rated song and save it to a variable. Print a message to the console, like “Song number X is rated three stars”.
Checkpoint 2 Passed

2. Find the first song that has more than 10 characters in its title. Save it to a variable and print a message to the console, such as “The first song that has more than 10 characters in the title is X.”
Checkpoint 3 Passed

3. Organize the playlist alphabetically. To check that it worked, print the first and last song titles to the console.
*/
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      
  int number = Array.IndexOf(ratings, 3 );

  Console.WriteLine($"Song number 4 {number} is rated three stars");

string firstSong =  Array.Find(summerStrut,song => song.Length > 10);

  Console.WriteLine($"The first song that has more than 10 characters in the is {firstSong}");

Array.Sort(summerStrut);
 Console.WriteLine($"{summerStrut[0]}");
 Console.WriteLine($"{summerStrut[7]}");

    }
  }

  /*
Documentation Hunt

In addition to Sort(), IndexOf(), and Find(), there are several other built-in methods for arrays. You can find them (and you probably guessed it) in the Microsoft documentation.

Let’s put your documentation sleuthing to use and hunt down some built-in methods to write some code!
Instructions
Checkpoint 1 Passed

1. In the Microsoft documentation, find the method that allows you to copy your playlist to a new playlist called summerStrutCopy. Print the first value of summerStrutCopy to the playlist to see if it is the same as summerStrut.
Checkpoint 2 Passed

2. In the Microsoft documentation, find the method that reverses the order of the array elements. Use it to reverse the order of the summerStrut playlist. Check to see if it worked by printing the first and last songs to the console.
Checkpoint 3 Passed

3. In the Microsoft documentation, find the method that turns every rating in the ratings array to zero. Check to see if it worked by printing out the first value to the console (it should be to 0).
  */

  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
     string[] summerStrutCopy = new string[8];

     Array.Copy(summerStrut,summerStrutCopy,8);
     Console.WriteLine(summerStrutCopy[0]);

    Array.Reverse(summerStrut);
     Console.WriteLine(summerStrutCopy[0]);
     Console.WriteLine(summerStrutCopy[7]);

    Array.Clear(ratings,0,ratings.Length);
    Console.WriteLine(ratings[0]);
    
    }
  }