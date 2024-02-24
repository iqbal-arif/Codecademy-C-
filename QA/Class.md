Q1: What is an Object?
A1: An instance of a class.
👏
Correct! If a class is a blueprint, then an object is a house built from that blueprint.

Q2: Define encapsulation.
A2: Encapsulation measns bundiling related data and methods into one logical group.
👏
Correct! Classes are one way to implement encapsulation.

Q3: Given the SpaceInvader class, what is Speed?
```
class SpaceInvader 
{
  public SpaceInvader()
  {
    this.Speed = 5;
  }

  public bool IsMothership
  { get; set; }

  public int Speed
  { get; set; }
}
```
A3: A property.
👏
Correct!

Q4: Which of these is NOT a class member?(Property,Constructor,Method,Object)
A4: Object
👏
Correct! An object is an instance of a class, not a class member.

Q5: When Main() is run, what will be printed to the console?

```
class Program {
  public static void Main (string[] args) {
    Player p = new Player();
  }
}

class Player
{
  public Player(string name)
  {
    Console.WriteLine($"Player named: {name}");
  }

  public Player() : this("n/a")
  {}
}
```
A5: "Plyer named: n/a"
Correct! The second constructor calls the first constructor with “n/a” as an argument.

Q6: Given the SpaceInvader class, what is SpaceInvader()?
```
class SpaceInvader 
{
  public SpaceInvader()
  {
    this.Speed = 5;
  }

  public bool IsMothership
  { get; set; }

  public int Speed
  { get; set; }
}
```

A6: A constructor method
👏
Correct! A constructor is a method with the same name as its enclosing class.

Q7: Create an instance of the Chainsaw class, which has a parameterless constructor.

A7: Chainsaw cutter = new Chainsaw();

Q8: Given the Unicorn class, which line in Main() will cause an error?
```
class Program {
  public static void Main (string[] args) {
    Unicorn u = new Unicorn();
    Console.WriteLine(u.HornLength);
    u.HornLength = 5;
    int len = u.HornLength;
  }
}

class Unicorn
{
  public int HornLength
  { get; private set; }
}

```

A8: u.HornLenght = 5;
👏
Correct! The set method for HornLength is private, so it cannot be accessed by other classes.

Q9: Given the Breakfast class, what is ingredients?
```
class Breakfast 
{
  string[] ingredients;
}
```

A9: A field
👏
Correct!

Q10: An instance of the Random class is constructed below. Call the instance method Next(), which returns a random integer.

A10:
```
Random generator = new Random();
int guess = generator.Next();
```

Q11: What is a class?
A11: The definition of a custom type
👏
Correct! In C#, a class defines the kinds of information and methods included in a custom type.

