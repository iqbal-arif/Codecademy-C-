namespace LearnReferences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn References!\n");


            //DISSERTATIION

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


            //REFERENCE VS VALUE COMPARISON

            Book b1 = new Book();
            Book b2 =b1;
            
            Console.WriteLine(b1 == b2);

            Dissertation diss1 = new Dissertation(32, "Anna Knowles-Smith", "Refugees and Theatre");
            Dissertation diss2 = new Dissertation(19, "Lajos Kossuth", "Shiny Happy People");
            Diary dy1 = new Diary(48, "Anne Frank", "The Diary of a Young Girl");
            Diary dy2 = new Diary(23, "Lili Elbe", "Man into Woman");


            //REFERENCE ARRAY

            Book[] books = new Book[] { diss1, diss2, dy1, dy2 };

            foreach (Book book in books)
            {
                Console.WriteLine(book.Title);
            }

            //Polymorphism

            Book BookClass = new Book();
            Book DiaryClass = new Diary();

            Console.WriteLine(BookClass.Stringify());
            Console.WriteLine(DiaryClass.Stringify());


            //Null and Unassigned Reference

            Book nullBook = null;

            Console.WriteLine(nullBook);

            Console.WriteLine(nullBook == null); //True


            Console.ReadLine();


        }
    }
}
