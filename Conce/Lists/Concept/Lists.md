**Introduction to Lists**
-------------------------

At this point, we assume that you’re familiar with arrays: they’re useful tools for managing large amounts of sequential data.

But arrays have their drawbacks:

  1.  They have a limited length
  2.  You have to keep track of the number of elements in the array using a separate index
  3.  You can only edit one element at a time

Lists resolve all of these issues! Like arrays, they are a sequential collection of values and they can hold references to any type. Unlike arrays, they have (effectively) unlimited length, they automatically track the number of actual elements in the list, and they have handy methods to work with multiple elements at a time.

**2. Creating and Adding**
--------------------------

A list is a sequential data structure that can hold any type. Like arrays, you can use them to store any sequential information, like the letters of the alphabet, comments on a blogpost, the finishing times for a horse race, or items on a restaurant menu.

You create a list using the new keyword, like you would create any other class. You specify the type of element inside angle brackets: < >. In this example, the list is named citiesList and it holds instances of the type string.

```
List<string> citiesList = new List<string>();
```

You can add elements to the list using the Add() method:

```
citiesList.Add("Delhi");
```

You can access elements using indices and square brackets:

```
string city = citiesList[0];
```

You can also re-assign elements using bracket notation:

```
citiesList[0] = "New Delhi";
```

In order to use lists, you’ll need to add this to the top of your file. We’ll explain this in detail later:

```
using System.Collections.Generic;
```


**3. Object Initialization**
----------------------------

Our first way to create lists and add items took multiple lines:

```
List<string> citiesList = new List<string>();
citiesList.Add("Delhi");
citiesList.Add("Los Angeles");
```
We can do it all in one line using object initialization:

```
List<string> citiesList2 = new List<string> { "Delhi", "Los Angeles" };
```
We won’t cover everything about object initialization in this lesson, but you do need to recognize and use it.

  1.  Basic construction uses parentheses ( ) and no values.
  2.  Object initialization uses curly braces { } and the actual values go in-between.

If we need to add elements to that second list later, we can still use Add():

```
citiesList2.Add("Kyiv");
```

**4. Count and Contains**
-------------------------

We can check on the status of our list in two ways.

We can find the number of elements in the list using the Count property:
```
List<string> citiesList = new List<string> { "Delhi", "Los Angeles" };
int numberCities = citiesList.Count;
// numberCities is 2
```
We can check if an element exists in a list using the Contains() method:
```
bool hasDelhi = citiesList.Contains("Delhi");
bool hasDubai = citiesList.Contains("Dubai");
// hasDelhi is true, hasDubai is false
```

**5.Removing**
--------------

To remove a specific item from a list we use the Remove() method. It expects the specific item as an argument and it returns true if it was successfully removed. This code removes "Delhi" from the list and returns true:
```
List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Kyiv" };
bool success = citiesList.Remove("Delhi");
// success is true
```
If the specific item does NOT exist in the list, the method call returns false. Since "Dubai" isn’t in the list, success will be false:
```
success = citiesList.Remove("Dubai");
// success is false
```
If you remove an element in the middle of the list, all of the elements will be “shifted” down one index. In the first example, the list was originally:
```
[ "Delhi", "Los Angeles", "Kyiv" ]
```
After the call to Remove("Delhi"), the list becomes
```
[ "Los Angeles", "Kyiv" ]
```