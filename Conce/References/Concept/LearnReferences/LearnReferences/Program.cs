namespace LearnReferences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn References!\n");

            Dissertation diss1 = new Dissertation();

            Dissertation diss2 = diss1;

            diss1.CurrentPage = 0;

            diss2.CurrentPage = 16;

            Console.WriteLine(diss1.CurrentPage);
            Console.WriteLine(diss2.CurrentPage);


            Diary dy1 = new Diary(5);
            Diary dy2 = dy1 ;

            dy2.Flip();

            Console.WriteLine(dy1.CurrentPage);
            Console.WriteLine(dy2.CurrentPage);

            Console.ReadLine();
        }
    }
}
