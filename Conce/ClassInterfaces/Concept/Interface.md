/*********************/
**Build an Interface**
**********************
/********************* / 

For this lesson we will be designing a new set of transportation machines that satisfy the requirements of BOTH car designers and the highway patrol. First the highway patrol tells us: “Every automobile on the road must have these properties and methods accessible to us:”

   1. speed
   2. license plate number
   3. number of wheels
   4. ability to honk

The patrol needs this information to write speeding tickets and prevent bad behavior on the highway.

In other words, the patrol makes these requirements so that it can interact with automobiles in a certain way. In C#, this group of interactions is called an interface. The interface is a set of properties, methods, and other members. They are declared with a signature but their behaviors are not defined. A class implements an interface if it defines those properties, methods, and other members.

For example, if the patrol requires automobiles to have a license plate, then the IAutomobile interface contains a LicensePlate property. A class implements this interface if it defines a LicensePlate property.

The skeleton of an interface looks a bit like a class:

```
interface IAutomobile
{
}
```
Every interface should have a name starting with “I”. This is a useful reminder to other developers and our future selves that this is an interface, not a class. We can add members, like properties and methods, to the interface. Here’s an example of a fake property and method:
```
interface IAutomobile
{
  string Id { get; }
  void Vroom();
}
```
Notice that the property and method bodies are not defined. An interface is a set of actions and values, but it doesn’t specify how they work.

In our highway example, the highway patrol doesn’t care HOW the license plate property and honk method work, they just care whether every automobile has it.


/******************************/ 
**2. What Interface Cannot Do**
*******************************
/******************************/ 

The Sedan needs to satisfy more than the highway patrol’s rules (the IAutomobile interface). The car designers have asked that sedans are built and move in certain ways — it must have constructors and methods that aren’t required by the IAutomobile interface. This is okay in C#! The interface says what a class MUST have. It does not say what a class MUST NOT have.

In fact, interfaces cannot specify two types of members that are commonly found in classes:

  1.  Constructors
  2.  Fields

/************/ 
**3. Review**
*************
/************/ 

Well done! In this lesson, you:

   1. Learned that interfaces are useful to guarantee certain functionality across multiple classes
   2. Built an interface using the interface keyword
   3. Defined properties and methods (but not constructors or fields) in the interface
   4. Built classes that implemented the interface
   5. Added members to the classes that weren’t specified in the interface

As a last note: a class can implement multiple interfaces. For example, Sedan could implement IAutomobile and a new IRecyclable interface. It would be useful to separate interfaces if they aren’t related, i.e. not all automobiles are recyclable.

With this lesson you completed, you might be asking yourself this question:

We have duplicated code, like SpeedUp() and SlowDown(), in two classes, and we know that duplicated code is hard to maintain. Is there a way to avoid duplication?

The answer has to do with inheritance. The concept won’t be covered in this lesson, but now you have one good reason to learn it.


