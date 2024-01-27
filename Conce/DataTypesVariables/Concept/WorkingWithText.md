**Introduction to Working with Text**
***
Working with text is a fundamental part of writing programs. Whether it’s to provide instructions to a user, gathering data like a name or address, or writing a new form of poetry, text enables us to bring human language into computational form.

In this lesson, we’ll look at the two commonly used text data types in C#: **char** and **string**. By the end of this lesson, you will be able to manipulate textual data and write programs that take in user inputs and output customizable messages using variables, operators, and built-in methods.


**Get Info About Strings**
****
In addition to containing the value of a piece of text, strings also contain information about themselves. It can be useful to know these properties when working with strings. There are several built-in .NET methods that we can use to get more information about strings.

**Length**
***
Since strings are composed of a set of characters, we can find out how many characters exist in a string with the .Length method. A common example is if we’re building a form and need to make sure a user submission doesn’t exceed a certain character length.
```
string userTweet = Console.ReadLine();
userTweet.Length; // returns the length of the tweet
```


We append the .Length property to a string that we have, such as a user’s tweet.

**IndexOf**
***
We can also find the position of a specific character or substring using .IndexOf(). This method is useful for searching to see if something exists in a string.

If it does exist within a string, the method will return the position of the search term in the larger string. Each character in a string has a unique position, like an address. Positions starts at 0 and increment by 1.
```
string word = "radio";
word.IndexOf("a"); // returns 1
```


Since positioning starts at 0, the second thing in the string will return a 1. If it doesn’t exist in the string the method will return a -1. If we pass it an empty string, it will return 0. If it occurs more than once, it will return the first instance.



**Get Parts of Strings**
***
We can also use built-in .NET methods to grab parts of strings or specific characters in a string.

**Substring**
***
.Substring() grabs part of a string using the specified character position, continues until the end of the string, and returns a new string. .IndexOf() is usually used first to get the specific character position.
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

***Bracket Notation***
***
Bracket notation is a style of syntax that uses brackets [] and an integer value to identify a particular value in a collection. In this case, we can use it to find a specific character in a string.
```
string plantName = "Cactaceae, Cactus";
int charPosition = plantName.IndexOf("u"); // returns 15
char u = plantName[charPosition]; // returns u
```

Similar to the example above, we first use .IndexOf() to grab the character position, which in this case is 15. We then take the string value and append it with a set of brackets [] and place the charPosition value inside the brackets.
