 **Strings Can Look Like Values**
 --------------------------------


String, or string, is a class that represents text. Technically its value is stored as a collection of char objects.

Since it is a class, it is a reference type. In some cases its behavior looks like a value type:

   1. A string reference will always point to the original object, so “modifying” one reference to a string will not affect other references
   2. Comparing strings with the equality operator (==) performs a value, not referential, comparison

Here are two examples of the first behavior (modifying one reference doesn’t affect the others):
```
// Example 1
string dog = "chihuahua";
string tinyDog = dog;
dog = "dalmation";
Console.WriteLine(dog);
// Output: "dalmation"
Console.WriteLine(tinyDog);
// Output: "chihuahua"

// Example 2
string s1 = "Hello ";
string s2 = s1;
s1 += "World";
System.Console.WriteLine(s1);
// Output: "Hello World"
System.Console.WriteLine(s2);
// Output: "Hello"
```
They can be explained by the fact that strings are immutable: they cannot be changed after they are created. Anything that appears to modify a string actually returns a new string object.

Here’s an example of the second behavior (value-like comparisons):
```
string s = "hello";
string t = "hello";
// b is true
bool b = (s == t);
```
Typically we want to compare strings by value, so this makes it easier to write in code and it also gives the C# compiler flexibility in how it implements the program (it doesn’t have to worry about where the actual string value is stored).


 **2. Strings can be Null or Empty or Unassigned**
 -------------------------------------------------

Like other reference types, string references can be null or unassigned. They can also have a third value: empty.
```
// Unassigned
string s;
// Null
string s2 = null;
// Empty string
string s3 = "";
// Also empty string
string s4 = String.Empty;
// This prints true
Console.WriteLine(s3 == s4);
```
All of these signify a lack of text, but they each mean something slightly different:

  1.  unassigned means that the programmer did not give the variable any value
  2.  null means that the programmer intentionally made the variable refer to no object
  3.  an empty string signifies a piece of text with zero characters. This is often used to represent a blank text field. It can be represented by "" or String.Empty

The Microsoft Programming Guide suggests using String.Empty or "" instead of null to avoid NullReferenceException errors.

We can check for null OR empty strings using the static String method IsNullOrEmpty(). It’s explained in more detail in the documentation.

**3.  String as Class**
-----------------------

We can prove that String is a class by looking up the String class documentation and trying some of the methods and properties listed there.

This example uses Length and Contains().
```
string s = "Hello World";
Console.WriteLine(s.Length);
Console.WriteLine(s.Contains("o"));
```
We’ve already seen one static property Empty and one static method, IsNullOrEmpty():
```
string s = String.Empty;
bool isEmpty = String.IsNullOrEmpty(s);
```

**4.Review**
------------

Well done, you’re a reference master now!

The concept of references, especially the nuances of the string type, can be difficult to understand when they aren’t clearly visible in the code. Let the information sink in and play with some code to check your understanding. Once you get it, this concept will save you dozens of hours of debugging.

Here’s what was covered in this lesson:

  1.  The String or string type is a reference type
  2.  Strings are immutable, which means they cannot be changed after they are created
  3.  Being immutable also means that a string reference will always point to the original object, so “modifying” one reference to a string will not affect other references to it
  4.  With the equality operator (==), strings are checked for value, not referential, equality
  5.  A string variable can be unassigned, null, or empty. Empty strings can be represented by String.Empty or "" — they’re equivalent

