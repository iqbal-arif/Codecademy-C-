Q1: What is true about a static class?
A1: It cannot be instantiated.
👏
Correct! Static classes are just tools — they don’t need specific instances and they don’t store new information.

Q2: When Main() is run, what is printed FIRST to the console?
```
class MainClass 
{
  public static void Main (string[] args) {
    SpaceInvader.Beep();
    SpaceInvader enemy = new SpaceInvader();
  }
}

class SpaceInvader
{
  static SpaceInvader()
  {
    Console.WriteLine("Aliens detected!");
  }

  public SpaceInvader()
  {
    Console.WriteLine("SpaceInvader instantiated.");
  }

  public static void Beep()
  {
    Console.WriteLine("* beep beep *");
  }
}
```
A2: "Aliens detected!"
The static constructor is invoked before a static member is accessed or the type is instantiated.

Q3: Why will this class definition cause an error?
```
class DollHouse
{
  private int numberOfRooms;

  public static string Describe()
  {
    return $"Each dollhouse has {numberOfRooms} rooms.";
  } 
}
```

A3: The static method Describe() attempts to access the instance field numberOfRooms.
👏
Correct! A static method cannot access non-static members, so this will cause an error.

Q4: e
Quiz: C# Static Members Quiz

The Forest class has:

    a public static ForestsCreated property
    a public static Define() method
    no instance constructors explicitly defined

Which of these statements will cause an error?
```
class MainClass 
{
  public static void Main (string[] args) {
    Forest.Define();
    int count = Forest.ForestsCreated;
    Forest jungle = new Forest();
    jungle.Define();
  }
}
```

A4: jungle.Define();
👏
Correct! A static member is always accessed by the class name, rather than the instance name.

Q5: Given this definition of Main(), which of these statements is TRUE?
```
class MainClass 
{
  public static void Main (string[] args)
  {
  }
}
```

A5: Main() returns nothing.
👏
Correct! The return type is void, which means it returns nothing.

Q6: Call the static method ToBoolean(), which is defined in the Convert class. It should take the argument answer.
A6:
```
string answer = "true";
bool convertedAnswer = Convert.ToBoolean ( answer );