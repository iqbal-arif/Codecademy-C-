**Introduction to Classes**
******

With data types like int, string, and bool we can represent basic data and perform basic operations:
```
int count = 32;
count++;
```
What if we want to represent something more complex — something in the real world?

Say we are writing a program to manage nature reserves and we need to track forests. A forest has a certain number of trees, it has a name, it can grow, it can burn. Representing many forests with basic data types would mean tracking tons of separate variables and methods.

Instead, we can define our own custom Forest data type and use it like any other data type in our program. This process of bundling related data and methods into a type is called ***encapsulation***, and it makes code easier to organize and reuse.

In C#, a custom data type is defined with a class, and each instance of this type is an object. This lesson will teach you how to:

   1. Define a class
   2. Add members, like properties and methods, to a class
   3. Customize access to those members using public and private
   4. Create objects from a class

In your coding adventures you may come across the term struct. While similar to a class it has a few differences, but we won’t be covering those in this lesson. 


**2. Making Classes**
**********************

C# provides built-in data types, like string: each instance of the string type has its own values and functionality.
```
string phrase = "zoinks!";
Console.WriteLine(phrase.Length);
Console.WriteLine(phrase.IndexOf("k"));
```
In this case phrase is an instance of the string type. Every string has a Length property and IndexOf() method, but the resulting values are different for each instance.

A class represents a custom data type. In C#, the class defines the kinds of information and methods included in a custom type.

You can then make instances of that class (above, phrase was an instance of string). There may be many instances of the same class, all with unique values.

To begin defining a class, C# uses this structure:
```
class Forest {
}
```
The code for a class is usually put into a file of its own, named with the name of the class. In this case it’s Forest.cs. This keeps our code organized and easy to debug.

In other parts of code, like Main() in Program.cs, we can use the class. We make instances, or objects, of the Forest class with the new keyword:
```
Forest f = new Forest();
```
We could say f is an instance of the Forest class, or f is of type Forest.

The process of creating an instance is called instantiation. Today we instantiate a class; yesterday they instantiated a class, and so on.
