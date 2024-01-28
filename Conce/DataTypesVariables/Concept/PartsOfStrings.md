**Parts of Strings**
***
We can also use built-in .NET methods to grab parts of strings or specific characters in a string.

**Substring**
****
***.Substring()*** grabs part of a string using the specified character position, continues until the end of the string, and returns a new string. .IndexOf() is usually used first to get the specific character position.
```
string plantName = "Cactaceae, Cactus"; 
int charPosition = plantName.IndexOf("Cactus"); // returns 11
string commonName = plantName.Substring(charPosition); // returns Cactus
```

.Substring() is useful if we only want to use part of a string but keep the original data intact. So in this instance, we want to keep the string plantName, but just grab the "Cactus" portion of the string. We use .IndexOf() to find where "Cactus" starts, then use .Substring() with the position information to save "Cactus" to the new variable commonName.

We can also pass .Substring() a second argument, which will determine the number of characters in the resulting substring. For example, the following code shows how we can use .Substring() with two arguments to specify the length of our substring:

```
string name = "Codecademy"; 
int start = 2;
int length = 6;
string substringName = name.Substring(start, length); // returns 'decade'
```

**Bracket Notation**
***
Bracket notation is a style of syntax that uses brackets [] and an integer value to identify a particular value in a collection. In this case, we can use it to find a specific character in a string.

```
string plantName = "Cactaceae, Cactus";
int charPosition = plantName.IndexOf("u"); // returns 15
char u = plantName[charPosition]; // returns u
```

Similar to the example above, we first use .IndexOf() to grab the character position, which in this case is 15. We then take the string value and append it with a set of brackets [] and place the charPosition value inside the brackets.

**Manipulate Strings**
****
There are also built-in .NET methods that we can use to manipulate text data. Using these methods on a string doesn’t change the string itself, but creates an entirely new one.

**ToUpper, ToLower**
***
We can quickly change the case of our strings using the methods .ToUpper() and .ToLower(). These methods are useful if we want to make our text look like an e.e. cumming’s poem or make it appear like we forgot to turn off our caps lock key.

```
string shouting = "I'm not shouting, you're shouting".ToUpper();
Console.WriteLine(shouting);
// prints I'M NOT SHOUTING, YOU'RE SHOUTING.
```
Review
***
Great job! You just learned about how to work with textual data in a few different ways:

   1.  How to save char and string values to a variable.
   2.  Use the addition symbol (+) to concatenate strings.
   3.  Interpolate strings for easier string construction.
   4.  Find information about a string using .Length and .IndexOf().
   5.  Grab characters and parts of strings using bracket notation and .Substring().
   6.  Use built-in methods such as .ToUpper() and .ToLower() to manipulate strings.

Now use what you’ve learned to write a short program! Some ideas:

   1.  Write a program that randomly converts part of a text to uppercase and lowercase to look like randomcase.
   2.  Write a program that takes in a series of random words to construct an automated poem, in the style of e.e. cummings.

