**Introduction to Static**
**************************


At this point, you may recall:

  1.  A custom data type is defined by a class.
  2.  An instance of a class is called an object. Multiple, unique objects can be instantiated from one class.
  3.  This process of bundling related data and methods into a type is called encapsulation, and it makes code easier to organize and reuse.

What if we needed to do something related to the type itself, not instances of that type? For example, where do we store the count of all Forest objects, or an explanation of forests in general?

To keep with the rules of encapsulation, these shouldn’t be associated with one instance (because this information is related to the Forest class, not a single Forest instance).

These facts and behaviors should be associated with the class itself! We call these types of members static.

This lesson will cover the meaning of static, how to apply it to different types of class members, and its typical uses cases.
/***********************************************************************************************************/
*********************
**2. Static Methods**
*********************
/***********************************************************************************************************/

You already know how to create an instance method, like:
```
class Forest
{
  private string definition;
  public void Define()  
  {
    Console.WriteLine(definition);
  }
}
```
This behavior (printing a general definition) isn’t specific to any one instance — it applies to the class itself, so it should be made static.

To make a static method, just add static after the access modifier (public or private).
```
class Forest
{
  private static string definition;
  public static void Define()
  { 
    Console.WriteLine(definition); 
  }
}
```
Notice that we added static to both the field definition and method Define().

This is because a static method can only access other static members. It cannot access instance members:
```
class Forest
{
  private string definition;
  public static void Define()
  { 
    // Throws error because definition is not static
    Console.WriteLine(definition); 
  }
}
```
Otherwise, static methods work like any other method.


/***********************************************************************************************************/
**************************
**.3 Static Constructors**
**************************
/***********************************************************************************************************/

An instance constructor is run before an instance is used, and a static constructor is run once before a class is used:
```
class Forest 
{
  static Forest()
  { /* ... */ }
}
```
This constructor is run when either one of these events occurs:

  1.  Before an object is made from the type.
  2.  Before a static member is accessed.

In other words, if this was the first line in Main(), a static constructor for Forest would be run:
```
Forest f  = new Forest();
```
It would also be run if this was the first line in Main():
```
Forest.Define();
```
Typically we use static constructors to set values to static fields and properties.

A static constructor does not accept an access modifier.

/***********************************************************************************************************/
*********************
**4. Static Classes**
*********************
/***********************************************************************************************************/

We covered a few static members: field, property, method, and constructor. What if we made the whole class static?
```
static class Forest {}
```
A static class cannot be instantiated, so you only want to do this if you are making a utility or library, like Math or Console.

These two common classes are static because they are just tools — they don’t need specific instances and they don’t store new information.

Now when you see something like:
```
Math.Min(34, 54);
Console.WriteLine("yeehaw!");
```


/***********************************************************************************************************/
*************************
**5. Common Static Errors
*************************
/***********************************************************************************************************/
With great power comes great responsibility. If you plan on using static, you must be familiar with the errors you might cause! Here a few common ones:

This error usually means you labeled a static constructor as public or private, which is not allowed:
```
error CS0515: 'Forest.Forest()': static constructor cannot have an access modifier
```
This usually means you tried to reference a non-static member from a class, instead of from an instance:
```
error CS0120: An object reference is required to access non-static field, method, or property 'Forest.Grow()'
```
This usually means that you tried to reference a static member from an instance, instead of from the class:
```
error CS0176: Member 'Forest.TreeFacts' cannot be accessed with an instance reference; qualify it with a type name instead
```

/***********************************************************************************************************/
*************
**6 .Main()**
*************
/***********************************************************************************************************/
Now that you’re familiar with classes, you’re ready to tackle the Main() method, the entry point for any program. You’ve seen it many times, but now you can explain every part!
```
class Program
{
  public static void Main (string[] args) 
  {
  }
}
```
 1.   Main() is a method of the Program class.
 2.   public — The method can be called outside the Program class.
 3.   static — The method is called from the class name: Program.Main().
 4.   void — The method means returns nothing.
 5.   string[] args — The method has one parameter named args, which is an array of strings.

Main() is like any other method you’ve encountered. It has a special use for C#, but that doesn’t mean you can’t treat it like a plain old method!

/***********************************************************************************************************/
*************
**7. Review**
*************
/***********************************************************************************************************/

Congrats! You are now ready to use static throughout your classes:

   1. In general, static means “associated with the class, not an instance”.
   2. A static member is always accessed by the class name, rather than the instance name, like Forest.Area.
   3. A static method cannot access non-static members.
   4. A static constructor is run once per type, not per instance. It is invoked before the type is instantiated or a static member is accessed.
   5. Either of these would trigger the static constructor of Forest:
```
public static void Main() {
  Forest f  = new Forest(); 
}
```
or
```
public static void Main() {
  Forest.Define(); 
}
```

    A static class cannot be instantiated. Its members are accessed by the class name, like Math.PI.

