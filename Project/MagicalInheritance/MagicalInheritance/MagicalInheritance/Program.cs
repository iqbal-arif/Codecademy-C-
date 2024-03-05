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

            // PUPIL
            //  CONSTRUCTING NEW PUPIL OBJECT

            Pupil mezil = new Pupil("Mezil-Kree");


            var stormWind = mezil.CastWindStorm();

            //ANNOUNCE


            Console.WriteLine(stormWind.Announce());


            //MAGE
            //  CONSTRUCTING NEW MAGE OBJECT

            Mage Guldan = new Mage("Gul'dan");

            var stormRain = Guldan.CastWindStorm();

            //ANNOUNCE
            Console.WriteLine(stormRain.Announce());


        }
    }
}
