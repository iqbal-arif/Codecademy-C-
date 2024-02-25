using MatchProfile;

namespace MatchProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matching Profile!");

            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA");

            sam.SetHobbies(new string[] { "listening to audiobooks and podcsts", "playing rec sports like bowling and kickball", "writing a specualtive fiction novel", "rading advice columns" });

            Console.WriteLine(sam.ViewProfile);


            Console.ReadLine();
        }
    }
}
