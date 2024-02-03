**Introduction to Method Output**
****
What’s the outcome of calling a method?

Sometimes a message is printed to the console:
```
Console.WriteLine("Hello World!");
```

Sometimes a value is returned:
```
Math.Floor(15.6); // Returns 15
```

Sometimes a variable is altered:
```
int number;
bool success = Int32.TryParse("10602", out number); 
// number is 10602 and success is True
```

If you don’t understand all of the code examples, that’s okay! By the end of this lesson you will be able to:

   1. Define methods with output using the return and out keywords
   2.  Recognize and resolve errors related to method output

Let’s get started!
Instructions

To remind yourself of some earlier concepts about method input, review the code on the right. We assume you are comfortable with these concepts before taking this lesson.


Return

The basic way to return values from a method is to use a return statement! (A well-constructed programming language shouldn’t have a lot of surprises.)

Let’s start with an example in the below code. It contains a definition of the Yell() method, which returns a string, and it calls that method in Main().

When we execute this program, the code in Main() runs first:

  1.  Yell() is called.
  2.  In Yell(), the uppercase version of "who's there?" is created and returned.
  3.  Back in Main(), that returned value is stored in the variable output and then printed to the console:
```
static string Yell(string phrase) 
{
  return phrase.ToUpper();
}

public static void Main()
{
  string output = Yell("who's there?");
  Console.WriteLine(output); // Prints WHO'S THERE?
}
```

Here’s a more generic definition: the keyword return tells the computer to exit the method and return a value to wherever the method was called.

When a method is declared, it must announce the type of value it will return. In this case, Yell() returns a string, so it has the string modifier (right before the name Yell).

That first line of the method is called a method declaration, so we can say that the method declaration must contain the type of the return value.

Generally, the method declaration is a combination of details including: the access modifiers, return type, method name, and parameter types. This lesson will not cover access modifiers, like static, so that we can focus on the return type, like string.


**Out**
****
A method can only return one value, but sometimes you need to output two pieces of information. Calling a method that uses an out parameter is one way to return multiple values.

For example, the Int32.TryParse() method tries to parse its input as an integer. If it can properly parse the input, the method returns true and sets its out variable to the new value. If it cannot properly parse the input, the method returns false and sets the out variable to 0.

This is what the method’s signature looks like:
```
public static bool TryParse (string s, out int result);
```

The method returns a boolean and accepts a string and a variable that has been declared of type int as input.

Here’s how Int32.TryParse() and the out parameter are used:
```
int number;
bool success = Int32.TryParse("10602", out number); 
// number is 10602 and success is true
int number2;
bool success2 = Int32.TryParse(" !!! ", out number2);
// number2 is 0 and success2 is false
```

The second parameter is labeled out, which means that it must be assigned a value within the method.

For a shortcut, you can declare the int variable within the method call:
```
bool success = Int32.TryParse("10602", out int number);
```

**Using Out**
***
We can use out parameters in our own methods as well. In this example, Yell() converts phrase to uppercase and sets a boolean variable to true:
```
static string Yell(string phrase, out bool wasYellCalled)
{
  wasYellCalled = true;
  return phrase.ToUpper();
}
```

   1. The out parameter must have the out keyword and its expected type
   2. The out parameter must be set to a value before the method ends

When calling the method, don’t forget to use the out keyword as well:
```
string message = "garrrr";
Yell(message, out bool flag);
// returns "GARRRR" and flag is true
```