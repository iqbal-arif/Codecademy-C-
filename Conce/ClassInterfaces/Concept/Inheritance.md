/******************************/
**Introduction to Inheritance**
*******************************
/******************************/

Duplicated code leads to errors. Say you have two classes Sedan and Truck. They’re different types, but they share a few properties and methods, like SpeedUp() and SlowDown(). If one of those members (say it’s SpeedUp()) has to change, then we would have to change the code in every location where SpeedUp() is defined.

In this case it’s two classes, but in other programs it may be many more! There are two reasons we don’t want to make the same change on code across multiple files:

  1.  It’s a waste of time
  2.  More importantly, it is a big risk for making mistakes

In this lesson you’ll learn about a solution to this problem: inheritance. With inheritance, you can define one superclass that contains the shared members (like SpeedUp() and SlowDown()). All classes that need those members can inherit them from the superclass.

/******************************/
**2. Superclass and Subclass**
******************************
/******************************/

In inheritance, one class inherits the members of another class. The class that inherits is called a ***subclass*** or derived class. The other class is called a ***superclass*** or ***base*** class.

In our car example, Sedan and Truck are subclasses (or derived classes). They will inherit members from a new class called **Vehicle**, which is the **superclass** (or base class).

Before using inheritance, both classes had:

  1.  Wheels, LicensePlate, and Speed properties
  2.  Honk(), SpeedUp(), and SlowDown() methods
  3.  Similar constructors

We can pull these out of both classes and put it in a Vehicle class. Sedan and Truck will still have access to those members, but we only need to write them in one place.

By the way, this inheritance hierarchy can extend either way: a new PickupTruck class could inherit from Truck, which inherits from Vehicle, which inherits from a new Machine class. The only rule is that a class can only inherit from one base class, e.g. Vehicle can’t inherit from Machine and Contraption.

/*******************************************/
**3. Access Inherited Members with Protected**
********************************************
/*******************************************/

While working on Vehicle and Sedan, you may have seen this error:

```
Sedan.cs(11,13): error CS0200: Property or indexer 'Vehicle.Wheels' cannot be assigned to -- it is read only
```

Remember **public** and **private**? A public member can be accessed by any code outside of the enclosing class. A private member can only be accessed by code within the same class.

The above error comes up because either:

    There is no setter for Vehicle.Wheels, or
    The setter is private

How do we fix this problem? Making the setter public is not secure. Making it private is too restrictive – we only want the subclass Sedan to access the property. C# has another access modifier to solved that: protected!

A protected member can be accessed by the current class and any class that inherits from it. In this case, if the setter for Vehicle.Wheels is protected, then any Vehicle, Truck, and Sedan instance can call it.


/**************************************/
**4. Access Inherited Members with Base**
***************************************
/**************************************/
To construct a Sedan, we must first construct an instance of its superclass Vehicle.

We can refer to a superclass inside a subclass with the base keyword.

For example, in Sedan:

```
base.SpeedUp();
```

refers to the SpeedUp() method in Vehicle.

There’s special syntax for calling the superclass constructor:

```
class Sedan : Vehicle
{
  public Sedan (double speed) : base(speed)
  {
  }
}
```

The above code shows a Sedan that inherits from Vehicle. The Sedan constructor calls the Vehicle constructor with one argument, speed. This works as long as Vehicle has a constructor with one argument of type double.

Even if we don’t use base() in Sedan, it will call a Vehicle constructor. Without an explicit call to base(), any subclass constructor will implicitly call the default parameterless constructor for its superclass. For example, this code implicitly calls Vehicle():

```
class Sedan : Vehicle
{
  // Implicitly calls base(), aka Vehicle()
  public Sedan (double speed)
  {
  }
}
```
The above code is equivalent to this:
```
{
  public Sedan (double speed) : base()
  {
  }
}
```
This code will ONLY work if the constructor Vehicle() exists. If it doesn’t, then an error will be thrown.


/********************************/
**5. Override Inherited Members**
*********************************
/********************************/

Say that we wanted to make one more vehicle that operates a bit differently than a sedan or truck. We want to use most of the members in Vehicle, but we need to write new versions of SpeedUp() and SlowDown().

What we want is to override an inherited method. To do that, we use the override and virtual modifiers.

In the superclass, we mark the method in question as virtual, which tells the computer “this member might be overridden in subclasses”:

```
public virtual void SpeedUp()
```

In the subclass, we mark the method as override, which tells the computer “I know this member is defined in the superclass, but I’d like to override it with this method”:

```
public override void SpeedUp()
```

As an aside: there’s another way to solve this problem. Instead of using virtual and override to override a member, we can define a new member with the same name. Essentially, the inherited member still exists, but it is “hidden” by the member in the subclass. If this sounds confusing, that’s okay! We also think it leads to unnecessary confusion, and that leads to errors. We’re going to stick with the virtual - override approach in this lesson.

/*************************************/
**6. Make Inherited Members Abstract**
**************************************
/*************************************/

Now we want to add one more method to Vehicle called Describe(). It will be different for every subclass, so there’s no point in defining a default one in Vehicle. Regardless, we want to make sure that it is implemented in each subclass.

This might sound similar to an interface. Why not add this method to the IAutomobile interface? We want Describe() to be available to all vehicles, not just automobiles.

To do this we need one more modifier: abstract. This line would go into the Vehicle class:

```
public abstract string Describe();
```

This is like the Vehicle class telling its subclasses: “If you inherit from me, you must define a Describe() method because I won’t be giving you any default functionality to inherit.” In other words, abstract members have no implementation in the superclass, but they must be implemented in all subclasses.

If one member of a class is abstract, then the class itself can’t really exist as an instance. Imagine calling Vehicle.Describe(). It doesn’t make sense because it doesn’t exist! This means that the entire Vehicle class must be abstract. Label it with abstract as well:

```
abstract class Vehicle
```

If you don’t do this, you’ll get an error message like this:

```
error CS0513: 'Vehicle.Describe()' is abstract but it is contained in non-abstract class 'Vehicle'
```

Once we write the abstract method and mark the class as abstract, we’ll need to actually implement it in each subclass. For example in Sedan:

```
public override string Describe()
{
  return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
}
```

To make it clear that this Describe() method in Sedan is overriding the Describe() method in Vehicle, we will need to label it override.
