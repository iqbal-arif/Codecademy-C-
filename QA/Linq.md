Q1: What will be printed to the console?
```
List<int> integers = new List<int>();
integers.Add(5);
integers.Add(3);
Console.WriteLine(integers.Remove(3));

```
A1: TRUE Remove() returns true if the argument is successfully removed from the list.


Q2: Which namespaces should be added so that the references to List<T> and Where() don’t cause errors?
```
// Missing "using" statements

var ocean = new List<string>();
ocean.Add("sea otter");
ocean.Add("dolphin");
ocean.Add("shark");

var scary = ocean.Where(x => x == "shark");
```

A2: using System.Collection.Generic;
	using System.Linq;

👏 Correct! System.Linq enables the Where operator and System.Collections.Generic enables the List<T> class.

Q3: Fill in the query so that it returns every element in savannah in uppercase.

string[] savannah = new string[] { "lion", "rhino", "giraffe" };

var result = savannah.Select(x => x.ToUpper());

👏 You got it!

Q4: How many elements does the savannah list contain?

```
List<string> savannah = new List<string>();
savannah.Add("cheetah");
savannah.AddRange(new string[] { "lion", "rhino", "giraffe" });
```

A4: 4

Q5: Why do we store the result of LINQ queries in a variable of type var?
A5: The returned type is not always known.

var is not an actual class. var is a keyword used for implicitly typing variables, meaning that the compiler, not the programmer, determines the type.
👏 Correct! LINQ queries return either a single value or a generic type IEnumerable<T>, but the actual type is not always easy to determine.

Q6: What value will be printed to the console?
```
List<Dog> dogs = new List<Dog>();
Console.WriteLine(dogs.Count);
```
A6: 0 👏 Correct! No items have been added to the list.

Q7: Use object initialization to construct a list containing the characters 'a', 'b', and 'c'.
```
A7: List<char> characters = new  List<char> { 'a', 'b', 'c' };  👏 you got it!
```
Q8: Instantiate a list that contains char objects.
```
A8: var characters = new  List<char>(); 👏 You got it!
```
Q9: What is LINQ?
A9: A set of language adn framework features for querying collections. 👏 Correct!

Q10: Print "giraffe" to the console.
```
List<string> savannah = new List<string>();
savannah.Add("lion");
savannah.Add("rhino");
savannah.Add("giraffe");

A10:

Console.WriteLine(savannah[2]);
```
👏 You got it!

Q11: Which of these data types is a generic collection?

A11: List<T> 👏 Correct! A generic collection has a generic type parameter T.

Q12; Print the number of elements in numbers and triplets.

```

List<int> numbers = new List<int> { 3, 6, 9, 17, 21 };

Console.WriteLine(numbers.Count);

var triplets = numbers.Where(x => x % 3 == 0);

Console.WriteLine(triplets.Count());
```

A12: Lists use the property Count.

Q13: What will be printed to the console?

```
List<int> integers = new List<int> { 7, 9 };
Console.WriteLine(integers.Contains(3));
```
A13: FALSE 👏 Correct! Contains() returns false if the argument does not exist in the list.

Q14: Use query syntax so that smallAnimals and smallAnimals2 have the same values.

A14: 
```
// Method syntax
var smallAnimals = savannah.Where(x => x.Length < 5);

// Query syntax
var smallAnimals2 = from x in savannah where x.length < 5 select x;
```

  


  

