**Building Arrays**

In C#, arrays are a collection of values that all share the same data type. You could have an array of type string that contains a list of your favorite songs, or an array of type int that stores a collection of user ids.

Similar to defining a variable for one piece of data, when we define a variable to hold an array we also have to specify the type:
```
// These arrays store ints, strings, and doubles, respectively
int[] x; 
string[] s; 
double[] d; 
```
To declare a variable that holds an array, we first write the type of data that will be stored in an array, then add the square brackets [] to signify that it is holding an array (rather than a single value), followed by the name of the array.

Like a variable, we can define and initialize an array at the same time, by specifying the values we want to store in it:
```
int[] plantHeights = { 3, 4, 6 };
```
To declare and initialize an array at the same time, after the array declaration we use the equal sign to denote we’re storing a value to the array, then write out the numbers we’re putting in the array, separated by commas , and enclosed in curly braces {}.

You may also see arrays defined and initialized using a new keyword:
```
int[] plantHeights = new int[] { 3, 4, 6 };
```
The new keyword signifies that we are instantiating a new array from the array class. We’ll cover classes and instantiation in another lesson, but for now you can just think of it as another way to create an array.

In fact, if you decide to define an array and then initialize it later (rather in one line like above) you must use the new keyword:
```
// Initial declaration
int[] plantHeights;

// This works
plantHeights = new int[] { 3, 4, 6 };   

// This will cause an error
// plantHeights = { 3, 4, 6 }; 
```

**Built-In Methods**

In C#, there are several built-in methods we can use with arrays. The full list can be found in the Microsoft documentation of the Array class, under methods.

**SORT**

The built-in method Array.Sort() (documentation), as its name suggests, sorts an array. This method is a quick way to further organize array data into a logical sequence:
```
int[] plantHeights = { 3, 6, 4, 1 };

// plantHeights will be { 1, 3, 4, 6 }
Array.Sort(plantHeights); 
```
Sort() takes an array as a parameter and edits the array so its values are sorted. If it is an array of integer values, it will sort them into ascending values (lowest to highest). If it’s an array of string values, they would be sorted alphabetically.

**INDEX OF**

The Array method Array.IndexOf()(documentation) takes a value and returns its index. IndexOf() works best when you have a specific value and need to know where it’s located in the array (or if it even exists!).
```
int[] plantHeights = { 3, 6, 4, 1, 6, 8 };

 // returns 1
Array.IndexOf(plantHeights, 6);
```
IndexOf() typically takes two parameters: the first is the array and the second is the value whose index we’re locating. IndexOf() also has several overloads that allow you to search for a specific range of the array. If the value appears more than once in an array, it returns only the first occurrence within the specified range. If it cannot find the value, it returns the lower bound of the array, minus 1 (since most arrays start at 0, it’s usually -1).

**FIND**

The Array method Array.Find()(documentation) searches a one-dimensional array for a specific value or set of values that match a certain condition and returns the first occurrence in the array.
```
int[] plantHeights = { 3, 6, 4, 1, 6, 8 };

// Find the first occurence of a plant height that is greater than 5 inches
int firstHeight = Array.Find(plantHeights, height => height > 5);
```
Find() takes two parameters: the first is the array and the second is a predicate that defines what we’re looking for. A predicate is a method that takes one input and outputs a boolean. Unlike IndexOf(), Find() returns the actual values that match the condition, instead of their index.

It’s customary to use a lambda function for the predicate to determine if the value meets the necessary criteria. If you need a refresher on lambda functions, check out our C# methods lesson.

For more information on using built-in methods, check out our lessons on C#: Methods.
