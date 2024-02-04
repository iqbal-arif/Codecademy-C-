**Method Output**
***

Q1: Which line is the method declaration on?

```
static int AddTwo(int num)
{
  int result = num + 2;
  return result;
}
```
A1: static int..
👏
Correct! The method declaration includes the input and output types and the method name.

Q2: Why will this code throw an error?

public static string CombineWords(string a, string b)
{
  return a + b;
}

Console.WriteLine(a + b);

Q2: Why will this code throw an error?
```
public static string CombineWords(string a, string b)
{
  return a + b;
}

Console.WriteLine(a + b);
```
A2: a and b are not defined outside of the method body.
👏
That’s right! You can only use a and b within the method.

Q3: Return an all-caps string, i.e. "HELLO".

"hello".ToUpper();

👏
You got it!

Q4: What will be printed to the console?

```
public static void Main(string[] args)
{
  Console.WriteLine(Sight("Dauna"));
}

static string Sight(string viewer, string spaceThing = "meteor")
{
  return $"{viewer} saw a {spaceThing}!";
}
```
A4: Dauna saw a meteor!

👏
Correct! The viewer parameter is set to "Dauna" and spaceThing is set to "meteor" by default.


Q5: What will be printed to the console?

```
public static void Main(string[] args)
{
  Console.WriteLine(SpaceSuit());
}

static string SpaceSuit(string animal)
{
  return $"This is a spacesuit for a(n) {animal}.";
}

static string SpaceSuit()
{
  return "Here's a spacesuit.";
}
```
A5: Here's a spacesuit.
👏
Correct! The second overload is used because SpaceSuit() was called with no arguments.

Q6: Why will this code throw an error?

```
public static void PercentDifference(double actual, double expected)
{
  return (actual - expected) / expected;
}
```
A6:  Ther return type is wrong.
👏
Yes! The return type should be double.

Q7: Find the minimum of int variables a and b. Assume that they are already defined in the code.

A7:
```
Math.Min(a, b);
```
👏
You got it!

Q8: In this code, what is the argument?

Convert.ToInt32(x);

A8: x
👏
Correct! x is the value passed to the method.

Q9: What will be printed to the console?
```
public static void Main(string[] args)
{
  Console.WriteLine(Launch(launchWord: "blast off"));
}

static string Launch(
  string countDown = "3, 2, 1", 
  string launchWord = "lift off")
{
  return $"{countDown}...{launchWord}!";
}
```
A9: 3,2,1...blast off!
The countDown parameter is set to "3, 2, 1" by default and launchWord is set to "blast off".
👏
Correct! The countDown parameter is set to "3, 2, 1" by default and launchWord is set to "blast off".


Q10: Write a method declaration that accepts one out parameter of type string. It should not return any value.
``
public static void HideMessage(out string message)
``
The method must have an out parameter.

Q11: The Main() method is executed when…
A11: The application is started.
👏
Correct!

Q12: Define method.
A12: A reusable set of instructions that perform a specific task.

Q13: Call the method Score() within the Main() method.
```
public static void Main(string[] args)
{
  Score();
}

public static void Score()
{
  Console.WriteLine("GOOOOAL!");
}
```
👏
You got it!
