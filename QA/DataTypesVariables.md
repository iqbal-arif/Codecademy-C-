Q1: In C#, a computer checks for type errors: 
A1: Before a program runs.
👏
Correct! C# is a statically-typed language, so it checks data types before the program is run. 

Q2: Given this variable definition, which statement would throw an error?
```
double num = 3;
```
A2: num.ToUpper();
👏
Correct! This statement would throw an error because it only works with char and string.

Q3: What will the output of this program be?
```
int num = 1;
string population = "all";

Console.WriteLine(num + " ring to rule them " + population);
```
A3: 1 ring to rule them all
👏
Correct! This program uses string concatenation, so it combines different strings together.

Q4: Set the variable gallery equal to "Gagosian" and the variable price to 12.3
```
string gallery = "Gagosian";

double price = 12.3;
```

Q5: Which line of code can we use to convert the int variable speed to a double variable named specificSpeed?
```
int speed = 65;
```
double specifiedSpeed = speed;
👏
Correct! This line of code can implicitly convert an int value to a double, since there would be no loss of data. 

Q6: Set the variable toy equal to 1. Increase the value of toy by 4 so that toy now equals 5.
```
toy = 1;

toy += 4;
```

Q7: Set the variable hours equal to 10. Decrease the value of hours by 2 so that hours now equals 8.
```
hours = 10;

hours -= 2;
```
👏
You got it!

Q8: Which of these will run without errors: 
A8: username.ToLower();

Q9: If the output of this code is 2, which operator would appear between the operands 20 and 6?
```
A9: Console.WriteLine(20 % 6);
```
Q10: Access the first letter of the string initials
```
A10: initials[0];
```
👏
You got it!

Q11: Write a program that uses string interpolation and the variables treeName and treefamily to print: “The maple tree is part of the deciduous family.”
```
string treeName = "maple";
string treeFamily = "deciduous";

Console.WriteLine($"The {treeName} tree is part of the {treeFamily} family");
```

Q12: In C#, what type of conversion would you use to change a double into an int?

A12: Explicit
👏
Correct! Since a double contains more information than an int, we need to use explicit casting methods.
