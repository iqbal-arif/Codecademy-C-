Q1: Fill in the code so that WorkerBee implements the IFlyable interface.

class WorkerBee : IFlyable

👏
You got it!

Q2: What is inheritance?
A2: The process by which one class inherits the members of another class. 👏 Correct!

Q3: Given that IMachine is an interface, what does the first line mean?

```
class Tractor : IMachine {}
```
A3: The **Tractor** Class implements the **IMachine** interface.
👏 Correct! The colon syntax indicates that the class on the left implements the interface(s) on the right.

Q4: Fill in the code so that Giganotosaurus.Warn() overrides the Dinosaur.Warn() method.

```
class Dinosaur
{
  public virtual void Warn()
  {
    Console.WriteLine("Wow, a dino!");
  }
}

class Giganotosaurus : Dinosaur
{
  public override void Warn()
  {
    Console.WriteLine("Wow, a GIANT dino!");
  }
}
```
👏 You got it!

Q5: Fill in the code so that Calculator extends the Computer class and implements the IClickable interface.

```
class Calculator  : Computer, IClickable 
```
👏 You got it!

Q6: Fill in the code so that WorkerBee implements the IFlyable interface.

class WorkerBee : IFlyable

👏 You got it!

Q7: Fill in the code so that the WorkerBee class inherits from the Bee class.

```
class WorkerBee : Bee {}
```
👏 You got it!

Q8: Why will this code cause an error?

```
interface IPersonable
{
  DateTime BirthDate { get; }
  string FullName { get; }
}

class Passport : IPersonable
{}
```

Q9: Why will this code cause an error?*?*?*?*?*?*?
```
interface IPersonable
{
  DateTime BirthDate { get; }
  string FullName { get; }
}

class Passport : IPersonable
{}
```
A9: The **Passport** class does not correctly implement the interface.
👏 Correct! Passport needs to implement the two properties.

Q10: Pick the true statement.
A10: A derived class inherits from a base class.

Q11: This code will throw errors. What change will fix those errors?

```
class Building
{
  private int x;
  private int y;
}

class Garage : Building
{
  public string ListValues()
  {
    return $"x: {this.x}, y: {this.y}";
  }
} 
```
A11: Change both **private** fields to **protected**
👏 Correct! Private members cannot be accessed by derived classes, but protected members can be.

Q12: What does it mean for a class member to be **abstract**?
A12: The member has a missing or incomplete implementation. It must be implemented by derived classes.
It is possible for an abstract member to override an inherited member. However, that is not the meaning of abstract