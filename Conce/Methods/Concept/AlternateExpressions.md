**Expression-bodied Definitions**

Expression-bodied definitions are the first “shortcut” for writing methods. They’re great for writing one-line methods, like this one:
```
bool IsEven(int num)
{
  return num % 2 == 0;
}
```
We can rewrite this definition as an expression-bodied definition by:

   1. removing the curly braces and return keyword, and
   2. adding the “fat arrow”, or =>, which is composed of the equal sign, =, and greater than, >, symbols.

```
bool isEven(int num) => num % 2 == 0;
```
This also works for methods that return nothing, aka void:

```
void Shout(string x) => Console.WriteLine(x.ToUpper());
```
This type of definition can only be used when a method contains one expression. This helps us remember the name: expression-bodied definitions are method definitions with one expression.

Fun fact: some developers also call the fat arrow notation, =>, a squid! 🦑


**Methods as Arguments**

Before we get into the next shortcut, we need to understand how methods are passed to other methods as arguments. This is possible and sometimes necessary in C#.

For example, say we need to check if there are even values in an array (you don’t need to know much about arrays here, except that they are lists of values).

First you need an array of values and the IsEven() method that returns true if its argument is even:
```
int[] numbers = {1, 3, 5, 6, 7, 8};

public static bool IsEven(int num)
{
  return num % 2 == 0;
}
```
Pass both of these as arguments to the method Array.Exists(), which returns a boolean value:
```
bool hasEvenNumber = Array.Exists(numbers, IsEven);
```
You can see that IsEven, a method, is passed as the second argument to Array.Exists().

In the background, this is what Array.Exists() does:

   1. The IsEven() method is called with each value in the array. We can imagine each of these being called:
```
IsEven(1);
IsEven(3);
IsEven(5);
IsEven(6);
```
   2. If any of these return true, Array.Exists() returns true.

By the end, Array.Exists() returns true because isEven(6) returns true.

There are other methods that accept methods as arguments, which you will encounter later on. For now, you need to understand that we can use a method’s name like a variable, e.g. IsEven is a variable representing the method IsEven(). We pass this variable to another method, like Array.Exists(), which will probably invoke that method-argument at least once within its own body.

**Lambda Expressions**

The next shortcut, lambda expressions, are great for situations when you need to pass a method as an argument.

In the past exercise, we used IsEven() to check that an even value exists in the array numbers:
```
int[] numbers = {1, 3, 5, 6, 7, 8};

public static bool IsEven(int num)
{
  return num % 2 == 0;
}

bool hasEvenNumber = Array.Exists(numbers, IsEven);
```
When using the original definition (with curly braces and return), it takes multiple lines to define the IsEven() method and other developers will need to jump around our code to find the definition. With a lambda expression, we can define IsEven() directly in the method call. We don’t even need to give it a name:
```
bool hasEvenNumber = Array.Exists(numbers, (int num) => num % 2 == 0 );
```
This might look similar to an expression-bodied definition. It sort of is! What makes a lambda expression unique is that it is an anonymous method: it has no name.

Generally lambda expressions with one expression (like the above example) take this form. They use the fat arrow, no curly braces, and no semicolon (;):
```
(input-parameters) => expression
```
Lambda expressions with more than one expression use curly braces and semicolon:
```
(input-parameters) => { statement; }
```
Here’s an example of the second structure, which checks if any element in numbers is a multiple of 12 and greater than 20:
```
bool hasBigDozen = Array.Exists(numbers, (int num) => {
  bool isDozenMultiple = num % 12 == 0;
  bool greaterThan20 = num > 20;
  return isDozenMultiple && greaterThan20;
});
```
Since this lambda expression includes multiple expressions (3 in this case), then we must use curly braces and semicolons.

**Shorter Lambda Expressions**

Time to put on our detective caps: using deductive reasoning, we can make our lambda expression even shorter. Here’s what we have to start:
```
bool hasEvenNumbers = Array.Exists(numbers, (int num) => num % 2 == 0 );
```
The type of num is int. It’s great to be explicit like this to avoid errors, but some developers wouldn’t include int. To them, it’s obvious! Here’s their reasoning:

   1. The modulo operator (%) is only used with numbers, so num must be a number
   2. The result of the operation num % 2 is compared to the integer 0. We can only compare similar types, so num must also be an integer!

Therefore, we can remove int without causing any errors:
```
bool hasEvenNumbers = Array.Exists(numbers, (num) => num % 2 == 0 );
```
When there is just one parameter in a lambda expression, we don’t need the parentheses around the parameter either:
```
bool hasEvenNumbers = Array.Exists(numbers, num => num % 2 == 0 );
```
We just learned two new shortcuts “within” the lambda expression shortcut. Though we don’t need to use them all the time, we do need to recognize them in other developers’ code:

   1. We can remove the parameter type if it can be inferred
   2. We can remove the parentheses if there is one parameter

