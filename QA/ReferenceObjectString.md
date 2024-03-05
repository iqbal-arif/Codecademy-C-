Q1: Fill in the code so that it prints True.
```
Object o1 = new Object();
Object o2 = o1;
Console.WriteLine(o1 == o2);
```
👏 You got it!

Q2: Which line will throw an error? Next() is a method defined only in the Random class.
```
Random rand = new Random();
Object orand = rand;
rand.Next(0, 1);
orand.Next(0, 1);
```
A2: orand.Next(0,1);
👏 Correct! An Object reference cannot access the Next() method because it is not defined in the Object class.

Q3: Which of these is a method defined in the Object class?
A3: GetType()
👏 Correct! GetType() is an Object method. 

Q4: What will be printed by the code when Main() is invoked?
```
class Animal
{
  public virtual string Describe()
  { return "Here's an animal"; }
}

class Amphibian : Animal
{
  public override string Describe()
  { return "Here's an amphibian"; }
}

class Program {
  public static void Main (string[] args) {
    Animal ani = new Amphibian();
    Console.WriteLine(ani.Describe());
  }
}
```
A4: Here's an amphibian
👏 Correct! The Animal reference has access to the override version of Describe() defined in Amphibian.

Q5: Fill in the code so that it prints True.

string s = "";
Console.WriteLine(s == String.Empty);
A5: 👏 You got it!

Q6: What will be printed by the code when Main() is invoked?
```
class Animal
{
  public virtual string Describe()
  { return "Here's an animal"; }
}

class Amphibian : Animal
{
  public override string Describe()
  { return "Here's an amphibian"; }
}

class Program {
  public static void Main (string[] args) {
    Amphibian amp = new Animal();
    Console.WriteLine(amp.Describe());
  }
}
```
A6: An error will be thrown
An error is thrown because any downcast must be explicit. In this case it should be: (Amphibian) new Animal();.

Q7: Select the true statement about the Object class.
A7: All types include Object at the top of theri inheritance hierarchy.

Q8: Which of these is NOT a value type?
A8: Object 👏 Correct! Classes are reference types.

Q9: Select the true statement about reference types.
A9: A reference type variable refers to a location in memory. 
👏 Correct! Instead of an actual value, references point to a location in memory.

Q10: There are two classes, Dress and Jeans, that implement the IZippable interface and inherit from Object. Dress and Jeans don’t inherit from each other. Which of these statements throws an error?
A10: 
```
Dress d = new Dress();
Jeans j = d;
```
👏 Yes! This throws an error because a Dress object cannot be implicitly cast to Jeans. They aren’t in each other’s inheritance hierarchy.

Q11: Fill in the code so that it prints True.
A11:
```
SomeClass sc = null;
OtherClass oc;
Console.WriteLine(sc == null);
```

Q12: Pick the correct definition of polymorphism.
A12: A concept in which one interface can be applied to different data types.

Q13: If Television inherits from Device and implements the IClickable interface, which of these is an explicit downcast?
A14: Television t = (Television) new Device();
👏 Correct! A Device object is explicitly downcast to the Television subclass.

Q13: Say that Chair and Bench implement the ISittable interface, which includes one method Sit(). Select the correct type so the code throws no errors.
```
ISittable[] seats = new ISittable[] { new Chair(), new Bench() };

foreach (ISittable seat in seats)
{
  seat.Sit()
}
```

Q14: What will be printed by the code when Main() is invoked?
```
class Program
{
  public static void Main() 
  {
    Book b = new Book();
    Console.WriteLine(b);
  }
}

class Book 
{
  public override string ToString() 
  {
    return "I'm a book!";
  }
}
```
A14: I'm a book!
👏 Correct! When a non-string object is printed with Console.WriteLine(), its ToString() method is called.

Q15: Diary and Dissertation inherit from the Book class, which inherits from Object. Which of these is an implicit upcast?
A15: Object o = new Book();

Q15: What will be printed by the code when Main() is invoked?
```
public static void Main (string[] args) {
  string angry = "SIT DOWN NOW!";
  string announcement = angry;
  announcement = "Please take your seat.";
  Console.WriteLine(angry);
}
```
A15: SIT DOWN NOW!
👏 Correct! Strings are immutable, so angry is not modified when announcement is modified.