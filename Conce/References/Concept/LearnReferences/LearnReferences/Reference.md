/***************************/
**ntroduction to References**
*****************************
/***************************/

What do you think will be printed by this code?
```
Dissertation diss1 = new Dissertation();
Dissertation diss2 = diss1;
diss1.CurrentPage = 0;
diss2.CurrentPage = 16;
Console.WriteLine(diss1.CurrentPage);
Console.WriteLine(diss2.CurrentPage);
```
Did you guess 0 and 16? The answer is 16 and 16!

To understand what’s happening here, we need to understand references. They might not be obvious in this code, but learning how to use them unlocks a whole new set of superpowers in C#. This lesson explains:

    How references work in C#
    Why references are useful
    How to upcast a reference
    How to create a null reference

Instructions

This lesson uses the Book, Dissertation, and Diary classes and the IFlippable interface. Look through each file to get acquainted.

    IFlippable is the interface
    Book is the base class
    Dissertation and Diary are classes that extend the base class and implement the interface


/*********************************/
**2. References of the Same Type**
**********************************
/*********************************/

Classes are reference types. That means that when we create a new instance of a class and store it in a variable, the variable is a reference to the object.

Let’s see what’s happening behind the scenes. When this code is run:
```
Dissertation diss1 = new Dissertation();
```
A new Dissertation instance is constructed and stored in the computer’s memory. You can imagine a slot in your computer holding the instance’s type, property values, etc. diss1 is a reference to that location in memory.

diss1 refers to memory location

diss1 is not the actual object, it is a reference to the object. Thus an object can have multiple references:
```
Dissertation diss1 = new Dissertation();
Dissertation diss2 = diss1;
```
diss1 and diss2 refer to the same memory location

Now there are two references to the same location in memory: we can say that diss1 and diss2 refer to the same object. If changes are made to that object, then they will be reflected in both references to it:
```
Dissertation diss1 = new Dissertation();
Dissertation diss2 = diss1;
diss1.CurrentPage = 0;
diss2.CurrentPage = 16;
Console.WriteLine(diss1.CurrentPage);
Console.WriteLine(diss2.CurrentPage);
```

    The middle two lines of this code are setting the CurrentPage property of the same object (first setting it to 0, then 16)
    The last two lines will print the same value, 16

You can imagine references like directions to a house: they tell you where to find the house, but they are not the house itself!

/***************************/
**3. References vs. Values**
****************************
/***************************/

To better grasp the idea of reference types, let’s look at the other kind of type: value types. While reference-type variables refer to a place in memory, value-type variables hold the actual data.

int is a value type, so the variable num holds the value 6:
```
int num = 6;
```
Reference types, on the other hand, refer to a location in memory. Every class is a reference type, so the variable diss refers to a location in memory that has the Dissertation object:
```
Dissertation diss = new Dissertation(50);
```
Every “primitive” data type is a value type, including:

    int
    double
    bool
    char

Revisiting our metaphor: a reference is like directions to a house, which “points” to a house. It isn’t the actual house. A value type is the house itself!

You might have noticed that string is missing here. It works a bit differently, so it will be covered in a later lesson.

/***********************************/
**4 Reference vs. Value Comparison**
************************************
/***********************************/

When we compare value types with ==, the C# compiler performs a value comparison. For example, this prints true because the value 6 is equal to the value 6:
```
int int1 = 6;
int int2 = 6;
Console.WriteLine(int1 == int2);
// Output: true
```
int1 and int2 are the actual value 6. When we compare the value 6 with 6, they’re the same!

When we compare reference types with ==, the C# compiler performs a referential comparison, which means it checks if two variables refer to the same memory location. For example, this prints false because d1 and d2 refer to two different locations in memory (even though they contain objects with the same values):
```
Dissertation d1 = new Dissertation(50);
Dissertation d2 = new Dissertation(50);
Console.WriteLine(d1 == d2);
// Output: false
```
We constructed two different Dissertation objects which happened to have the same values. Each reference (d1 and d2) point to different objects, so they are not equal.
