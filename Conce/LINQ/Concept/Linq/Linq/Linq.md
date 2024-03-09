**Introduction to LINQ**
------------------------


Imagine you’re building a new game in C#, with dozens of characters to manage in your database. How would you access them all? What if you need to apply a filter? What if you needed to format each character name?

You might think of storing characters in a list and running through each element with a foreach loop. You’d have to write nested if statements, re-format each element, and store each result in a new list.

The result isn’t pretty.

Suppose that we want to find all the names in a list which are longer than 6 letters and return them in all uppercase letters. You can see what it would look like in Program.cs in the code editor.

And remember that this only works in a running C# file. What if the database was stored in a separate server somewhere and it was implemented with SQL instead of C#?

The solution is LINQ. It works for complex selections and transformations, and it works on local and remote data sources. Each selection/transformation is called a query, and LINQ gives us new syntax and methods to write them.

Imagine LINQ like an add-on to C# and .NET. Once you import the LINQ features, you can write new syntax, like:
```
string[] names = { "Tiana", "Dwayne", "Helena" };
var filteredNames = from n in names
  where n.Contains("a")
  select n;
  ```
And you can use new methods on collections, like Where():
```
var shortNames = names.Where(n => n.Length < 4);
```
In this lesson you’ll learn :

  1.  How to import the LINQ features to C#
  2.  How to run LINQ queries on datasets
  3.  How to identify method and query syntax
  4.  Basic operators, such as Select, Where, and from

**2. Importing LINQ**
--------------------

Before we jump into the syntax and methods, let’s import the features into our code. To use LINQ in a file, add this line to the top:
```
using System.Linq;
```
Often times we use LINQ with generic collections (like lists), so you may see both namespaces imported into a file:
```
using System.Collections.Generic;
using System.Linq;

```

**3.Var**
----------

Every LINQ query returns either a single value or an object of type IEnumerable<T>. For now, all you need to know about that second type is that:

  1.  It works with foreach loops, just like arrays and lists
  2.  You can check its length with Count()

Since the single value type and/or the parameter type T is not always known, it’s common to store a query’s returned value in a variable of type var.

var is just an implicitly typed variable — we let the C# compiler determine the actual type for us. Here’s one example:
```
string[] names = { "Tiana", "Dwayne", "Helena" };
var shortNames = names.Where(n => n.Length < 4);
```
In this case shortNames is actually of type IEnumerable<string>, but we don’t need to worry ourselves about that as long as we have var!
