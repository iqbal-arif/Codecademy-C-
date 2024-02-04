Q1: How can we get the current date/time?
A1: DateTime.Now
Good job!
DateTime has a static property called Now, which returns the current date/time.

Q2: What will be the output of this program?

var dateTime = new DateTime(2015, 1, 1);

dateTime.AddYears(1);

Console.WriteLine(dateTime.Year);
A2: 2015
DateTime objects are immutable. So here AddYears() does not affect our original object.

Q3: Select the best way to create a TimeSpan object to represent 1 hour.
A3: TimeSpan.FromHours(1);
DateTime objects are immutable. So here AddYears() does not affect our original object.

Q4: How can we get the current year?
A4: DateTime.Now.Year
Good job!
DateTime.Now returns a DateTime object that represents the current date/time. This object has a Year property that we can access to get the current year.