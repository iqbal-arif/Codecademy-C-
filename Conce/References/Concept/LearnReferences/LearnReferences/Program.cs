namespace LearnReferences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn References!\n");


            //DISSERTATIION

            // Two references to the same object

            Dissertation dissOne = new Dissertation();

            Dissertation dissTwo = dissOne;

            dissOne.CurrentPage = 0;

            dissTwo.CurrentPage = 16;

            Console.WriteLine(dissOne.CurrentPage);
            Console.WriteLine(dissTwo.CurrentPage);

            //DIARY

            Diary dyOne = new Diary(5);
            Diary dyTwo = dyOne ;

            dyTwo.Flip();

            Console.WriteLine(dyOne.CurrentPage);
            Console.WriteLine(dyTwo.CurrentPage);

            //BOOK

            Book bookLocation = new Book();

            Book sameBookLocation = bookLocation;

            bool falseValue = false;

            bool anotherFalseValue = falseValue;

            //The false value was copied to a new location in memory for anotherFalseValue to use.



            //Polymorphism

            Book BookClass = new Book();
            Book DiaryClass = new Diary();

            Console.WriteLine(BookClass.Stringify());
            Console.WriteLine(DiaryClass.Stringify());


            //Null and Unassigned Reference

            Book nullBook = null;

            Console.WriteLine(nullBook);

            Console.WriteLine(nullBook == null); //True



            //REFERENCE VS VALUE COMPARISON

            Book b1 = new Book();
            Book b2 = b1;

            Console.WriteLine(b1 == b2);

            Dissertation diss1 = new Dissertation(32, "Anna Knowles-Smith", "Refugees and Theatre");
            Dissertation diss2 = new Dissertation(19, "Lajos Kossuth", "Shiny Happy People");
            Diary dy1 = new Diary(48, "Anne Frank", "The Diary of a Young Girl");
            Diary dy2 = new Diary(23, "Lili Elbe", "Man into Woman");


            //1.  Referential equality when comparing reference types
            Dissertation d1 = new Dissertation(50);
            Dissertation d2 = new Dissertation(50);
            Console.WriteLine(d1 == d2);
            // Prints false

            //2.  Value equality when comparing value types
            int int1 = 6;
            int int2 = 6;
            Console.WriteLine(int1 == int2);
            // Prints true


            //3.  Reference to object with implemented interface
            Dissertation diss = new Dissertation(50);
            IFlippable f = diss;
            diss.Flip();
            f.Flip();
            Console.WriteLine(diss.Define());
            // This causes an error!
            //Console.WriteLine(f.Define());


            //4.  Reference to object with inherited superclass
            Dissertation diss3 = new Dissertation(19, "Lajos Kossuth", "Shiny Happy People");
            Book bdiss3 = diss3;
            Console.WriteLine(diss3.Author);
            Console.WriteLine(bdiss3.Author);
            Console.WriteLine(diss3.Define());
            // This causes an error!
            // bdiss3.Define();

            //5.  Arrays of references
            IFlippable[] flippers = new IFlippable[] { new Dissertation(), new Diary() };
            foreach (IFlippable flipper in flippers)
            {
                flipper.Flip();
            }


            //REFERENCE ARRAY

            Book[] books = new Book[] { diss1, diss2, dy1, dy2 };

            foreach (Book book in books)
            {
                Console.WriteLine(book.Title);
            }


            //6.  Same reference type but different behavior (using virtual/override)
            Book bdiss = new Dissertation();
            Book bk = new Book();
            Console.WriteLine(bdiss.Stringify());
            Console.WriteLine(bk.Stringify());
            // Output:
            // "This is a Dissertation object!"
            // "This is a Book object!"

            //7.  Null reference
            Diary dyNull = null;
            // Unassigned reference
            Diary dyNoValue;
            // Unassigned references in array
            Diary[] dys = new Diary[5];


            Console.ReadLine();


        }
    }
}
