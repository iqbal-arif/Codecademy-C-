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

/*********************************/
**5 References of Different Types**
***********************************
/*********************************/

Before going any further, let’s remind ourselves that Dissertation implements IFlippable, which has the CurrentPage property and Flip() method. You’ll need this info in a minute.

In our previous example both references to the Dissertation object were of type Dissertation:
```
Dissertation diss1 = new Dissertation();
Dissertation diss2 = diss1;
```
Whenever we use diss1 and diss2 we can handle the Dissertation object as if it were a Dissertation type. Since Dissertation also implements the IFlippable interface, we can reference it that way too:
```
Dissertation diss = new Dissertation(50);
IFlippable fdiss = diss;
```
Now diss and fdiss refer to the same object, but fdiss is an IFlippable reference, so it can ONLY use IFlippable functionality:
```
diss.Flip();
fdiss.Flip();
Console.WriteLine(diss.Define());
// This causes an error!
Console.WriteLine(fdiss.Define());
```
This last line causes an error because Define() is not a method in the IFlippable interface. The other lines do NOT cause errors because they use members that both IFlippable and Dissertation have.

This rule also applies to base classes too, so we can refer to a Dissertation object as Book.
```
Dissertation diss = new Dissertation(50);
Book bdiss = diss;
Console.WriteLine(diss.Title);
Console.WriteLine(bdiss.Title);
diss.Define();
// This causes an error!
bdiss.Define();
```
Title is defined for Book, so no error is thrown there. Define(), however, is not defined for the Book class, so we can’t use it with Book references.

/**************************/
**6. Arrays of References**
***************************
/**************************/

We know that we can use inherited classes and implemented interfaces to reference an object:
```
Dissertation diss = new Dissertation(50);
IFlippable fdiss = diss;
```
This allows us to work with many similar types at the same time. Imagine if we didn’t have this feature and we had to “flip” a group of Diary and Dissertation types:
```
Diary dy1 = new Diary(1);
Diary dy2 = new Diary(30);
Dissertation diss1 = new Dissertation(50);
Dissertation diss2 = new Dissertation(49);
dy1.Flip();
dy2.Flip();
diss1.Flip();
diss2.Flip();
```
Look at all that code! It would be faster and safer if we could store the references in an array and loop through it. But would it be an array of Diary[] or an array of Dissertation[] or something else? Since both dissertations and diaries are flippable (they both implement the IFlippable interface), we can create references to them as IFlippables:
```
IFlippable f1 = new Diary(1);
IFlippable f2 = new Diary(30);
IFlippable f3 = new Dissertation(50);
IFlippable f4 = new Dissertation(49);
```
Instead of dealing with individual variables, we can use an array of IFlippable references:
```
IFlippable[] classroom = new IFlippable[] { new Diary(1), new Diary(30), new Dissertation(50), new Dissertation(49) };
```
Then to “flip” each element, we can write a foreach loop:
```
foreach (IFlippable f in classroom) 
{
  f.Flip();
}
```
We can only access the functionality defined in the interface. For example, we couldn’t access f.Title because Title isn’t a property defined in IFlippable.
