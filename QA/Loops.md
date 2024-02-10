Q1: Define breeds as an array of strings.
A1:
```
string[] breeds = new string[] {"Dalmatian", "Shiba Inu", "Chihuahua"};
```
👏
You got it!

Q2: Create a do…while loop that makes the player Dance() until keyPressed is true.
A2:
```
do
  {
    Player.Dance();
  } 

while (

keyPressed != true);
```
👏
You got it!

Q3: Why will this code throw an error?
```
public static void Main (string[] args) 
{
  bool[] answers = {false, false, true};
  for (i = 0; i < answers.Length; i++)
  {
    Console.WriteLine(answers[i]);
  }
}
```
A3: The type for variable i is undefined.
👏
Correct! This would be fixed by adding int before i = 0.


Q4: Define an array of doubles without using new.

double[] temperatures =  {8.6, 9.9};

👏
You got it!

Q5: In this code, what is an element?

char[] letters = { 'z' };

A5: "z"
👏
Correct! The array has one element: the character z.

Q6: What is a data structure?
A6: An organized way to manage adn access information.

👏
Correct! An array is one example of a data structure.

Q7: What will be printed to the console?
```
public static void Main (string[] args) 
{
  string[] names = {"Ursula", "K.", "Le", "Guin"};
  foreach (string name in names)
  {
    Console.Write(name + " ");
  }
}
```
A7: Ursula K. Le Guin

Q8: What is an array?
A8: A list of ordered data.

Q9: What is the index of "give"?
```
string[] lyrics = {"Never", "gonna", "give", "you", "up"};
```
A9: 2

Q10: When this code is run, how many times will "bzzt" be written to the console?
```
public static void Main (string[] args) 
{
  for (int z = 2; z < 3; z++)
  {
    Console.WriteLine("bzzt");
  }
}
```
A10: 1
👏
Correct! In the first time through the loop, z is 2. Then z is incremented to 3. The loop exits because this no longer satisfies the condition z < 3.

Q11: Define an empty array of integers with a length of 10.

int[] empty = new int[10];

👏
You got it!

Q12: Create a while loop that prints out every number in the array.
```
double[] lapTimes = {4.00, 5.32, 4.68, 3.95};
int j = 0;
while (j <lapTimes.Length)
{
  Console.WriteLine(lapTimes[j]);
  j++;
}
```