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

**4. Method and Query Syntax**
------------------------------


In LINQ, you can write queries in two ways: in query syntax and method syntax.

Query syntax looks like a multi-line sentence. If you’ve used SQL, you might see some similarities:
```
var longLoudHeroes = from h in heroes
  where h.Length > 6
  select h.ToUpper();
```
Method syntax looks like plain old C#. We make method calls on the collection we are querying:
```
var longHeroes = heroes.Where(h => h.Length > 6);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());
```
In LINQ, we see where/Where() and select/Select() show up as both keywords and method calls. To cover both cases, they’re generally called operators.

Every developer has a personal preference between syntaxes, but you should be able to read both. In this lesson we’ll start with query syntax then move on to method.

**5.Basic Query Syntax**
------------------------

A basic LINQ query, in query syntax, has three parts:
```
string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

var shortHeroes = from h in heroes
  where h.Length < 8
  select h;
```
  1. The from operator declares a variable to iterate through the sequence. In this case, h is used to iterate through heroes.
  2. The where operator picks elements from the sequence if they satisfy the given condition. The condition is normally written like the conditional expressions you would find in an if statement. In this case, the condition is h.Length < 8.
  3.  The select operator determines what is returned for each element in the sequence. In this case, it’s just the element itself.

The from and select operators are required, where is optional. In this next example, select is used to make a new string starting with “Hero: “ for each element:
```
var heroTitles = from hero in heroes
  select $"HERO: {hero.ToUpper()}";
```
Each element in heroTitles would look like "HERO: D. VA", "HERO: LUCIO", etc.

**6. Basic Method Syntax: Where**
---------------------------------

In method syntax, each query operator is written as a regular method call.

In the last exercise we selected every element with a length under 8. Here it is in method syntax:
```
string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
var shortHeroes = heroes.Where(h => h.Length < 8);
```
The where operator is written as the method Where(), which takes a lambda expression as an argument. Remember that lambda expressions are a quick way to write a method. In this case, the method returns true if h is less than 8 characters long.

Where() calls this lambda expression for every element in heroes. If it returns true, then the element is added to the resulting collection.

For example, the shortHeroes sequence from above would be:

```
[ D. Va, Lucio, Mercy, Pharah ]
```

**7. Basic Method Syntax: Select**
---------------------------------

To transform each element in a sequence — like writing them in uppercase — we can use the select operator. In method syntax it’s written as the method Select(), which takes a lambda expression:
```
string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
var loudHeroes = heroes.Select(h => h.ToUpper());
```
We can combine Select() with Where() in two ways:

  1.  Use separate statements:
```
var longHeroes = heroes.Where(h => h.Length > 6);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());
```
  2.  Chain the expressions:
```
var longLoudHeroes = heroes
  .Where(h => h.Length > 6)
  .Select(h => h.ToUpper());
```
As with most of LINQ, the choice is up to you!

In the first option, we use two variable names and two statements. You can tell there are two separate statements by counting the semi-colons.

In the second option, we use one variable name and one statement.

If we must use method-syntax, we prefer the second option (chaining) because it is easier to read and write. You can imagine each line like a step in a conveyor belt, filtering and transforming the sequence as it goes.

**8. When To Use Each Syntax**
------------------------------


So far you’ve seen query syntax and two flavors of method syntax.

```
// Query syntax
var longLoudheroes = from h in heroes
  where h.Length > 6
  select h.ToUpper();

// Method syntax - separate statements
var longHeroes = heroes.Where(h => h.Length > 6);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());

// Method syntax - chained expressions
var longLoudHeroes2 = heroes
  .Where(h => h.Length > 6)
  .Select(h => h.ToUpper());
```

As you get into more advanced LINQ queries and learn new operators, you’ll get a feel for what works best in each situation. For now, we generally follow these rules:

  1.  For single operator queries, use method syntax.
  2.  For everything else, use query syntax.

**