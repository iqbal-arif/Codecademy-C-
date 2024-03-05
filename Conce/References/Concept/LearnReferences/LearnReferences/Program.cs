namespace LearnReferences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn References!\n");


            //DISSERTATIION

            Dissertation diss1 = new Dissertation();

            Dissertation diss2 = diss1;

            diss1.CurrentPage = 0;

            diss2.CurrentPage = 16;

            Console.WriteLine(diss1.CurrentPage);
            Console.WriteLine(diss2.CurrentPage);

            //DIARY

            Diary dy1 = new Diary(5);
            Diary dy2 = dy1 ;

            dy2.Flip();

            Console.WriteLine(dy1.CurrentPage);
            Console.WriteLine(dy2.CurrentPage);

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

            Console.ReadLine();


        }
    }
}
