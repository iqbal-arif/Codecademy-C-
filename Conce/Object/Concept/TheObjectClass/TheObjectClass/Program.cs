namespace TheObjectClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Object Class!\n");

            //THE OBJECT TYPE

            Book bk = new Book();

            Diary dy = new Diary(38);

            int i = 9;

            Object bk1 = bk;
            Object dy1 = dy;
            Object i1 = i;

            //OBJECT MEMBERS

            Book b = new Book();
            Diary d = new Diary(38);
            Random r = new Random();
            int j = 9;

            Object[] arrayObject = new Object[] { b, d, r, j };

            foreach (Object item in arrayObject)
            {
                Console.WriteLine(item.GetType());
            }

            Console.WriteLine(bk.ToString());

            Console.WriteLine(dy);
        }

    }
}
