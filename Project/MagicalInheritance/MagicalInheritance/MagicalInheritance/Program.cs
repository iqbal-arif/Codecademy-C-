namespace MagicalInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MagicalInheritance!\n");

            // CONSTRUCTING NEW OBJECT

            Storm firstStorm = new Storm("Zul rajas", "wind", false);

            //ANNOUNCE

            Console.WriteLine(firstStorm.Announce());


        }
    }
}
