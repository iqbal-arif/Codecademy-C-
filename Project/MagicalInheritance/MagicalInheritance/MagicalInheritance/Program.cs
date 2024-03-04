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


            //  CONSTRUCTING NEW PUPIL OBJECT

            Pupil mezil = new Pupil("Mezil-Kree");


            var storm = mezil.CastWindStorm();

            //ANNOUNCE


            Console.WriteLine(storm.Announce());
   


        }
    }
}
