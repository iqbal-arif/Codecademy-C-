**Comparing Loops**

You may have noticed that there are lots of similarities between different types of loops, and you’re right!

We just showed how we can use a foreach loop to iterate through an array. But we can also use a for loop to iterate through an array:
```
string[] items = { "potion", "dagger", "shield", "plant" };

for (int i = 0; i < items.Length; i++)
{
  Console.WriteLine(items[i]);
}
```
We could even write a complicated while loop that starts a counter at 0, then compares that counter to the length of the items array. If the counter is less than the array, the loop will continue. Otherwise, it will stop looping through the statements and the program will move on to the next line of code.
```
int i = 0;
while (i < items.Length)
{ 
  Console.WriteLine(items[i]); 
  i++; 
}
```
Since a foreach loop does the same thing as the other two but is more concise, it is less prone to errors and the better choice in this circumstance.
```
string[] items = { "potion", "dagger", "shield", "plant" };

foreach (string item in items)
{
  Console.WriteLine(item);
}
```
In general,

  1.   while loops are good when you know your stopping condition, but not when you know how many times you want a program to loop or if you have a specific collection to loop through.
  2.  do...while loops are only necessary if you definitely want something to run once, but then stop if a condition is met.
  3.  for loops are best if you want something to run a specific number of times, rather than given a certain condition.
  4.  foreach loops are the best way to loop over an array, or any other collection.

**Jump Statements**
***
There are a few keywords we can use to add further control flow to our loops. Typically, they work with a series of nested loops, where one loop is written entirely within the body of another loop. These keywords are often used to limit while loops and prevent them from creating infinite loops.

**BREAK**

At any point within a loop block, you can end it by using the break keyword.
```
while (playerIsAlive) 
{ 
// this code will keep running

  if (playerIsAlive == false) 
  { 
    // eventually if this stopping condition is true, 
    // it will break out of the while loop
    break; 
   } 
 } 

// rest of the program will continue
```
You’ve already seen the break keyword— it’s the same keyword that is used in switch statements.

**CONTINUE**

The continue keyword is used to bypass portions of code. It will ignore whatever comes after it in the loop and then will go back to the top and start the loop again.
```
int bats = 10;

for (int i = 0; i <= 10; i++)
{
  if (i < 9)
  {  
    continue;
  }
  // this will be skipped until i is no longer less than 9
  Console.WriteLine(i);
}
```
Here, the program starts in the for loop, then hits the if statement. Since there is a continue in the if statement, it will bypass the Console.WriteLine() statement until the condition in the if statement is no longer true. So while the loop starts at 0, nothing will print to the console until i is equal to 9.

**RETURN**

The return keyword is another way to exit a loop, specifically loops that are used within a method. When a return is used within such a loop, it breaks out of the loop and returns control to the point in the program where the method was called.
```
class MainClass {
 public static void Main (string[] args) {
   UnlockDoor();

  // after it hits the return statement, it will move on to this method
   PickUpSword();
 }

 static bool UnlockDoor()
 {
   bool doorIsLocked = true;

   // this code will keep running
   while (doorIsLocked)
   {
     bool keyFound = TryKey();

      // eventually if this stopping condition is true,
      // it will break out of the while loop
     if (keyFound)
     {
      // this return statement will break out of the entire method
      return true;
     }
   }
   return false;
 }
}
```
You should only use return if you need to exit a method because it will break out of all loops. If you only want to break out of one loop and not exit a method, use break.

Review

Well done! In C#, loops are commonly used because they save time, reduce errors, and are easy to read. Being comfortable with each type of loop will make you a better programmer. In review:

   1. A loop is a structure in programming where the instructions are written once, but a computer can execute them multiple times
   2. Each execution of those instructions is called an iteration
   3. while loops repeat until a condition changes
   4. do...while loops execute once, and then repeat until a condition changes
   5. for loops repeat for a specified number of times
   6. foreach loops repeat for each item in a collection
   7. jump statements, like break, continue, and return are used to add additional control flow to loops

Now that you know a few things about loops, try writing a program that:

   1. Loops through a piece of text and only prints words that start with the letter “a” to the console to create a poem.
   2. Loops through a list of numbers and if it is even, print even and if it’s odd, print odd.
   3. A Choose Your Own Adventure game that uses a while loop to make sure a user chooses a correct option.

