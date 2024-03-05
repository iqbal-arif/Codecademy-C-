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

