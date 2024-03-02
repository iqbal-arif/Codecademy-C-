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

Q9: Why will this code cause an error?
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

