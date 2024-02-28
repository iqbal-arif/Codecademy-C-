using MatchProfile;

namespace MatchProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matching Profile!\n");

            Profile sam = new Profile("Sam Drakkila", 20, "New York", "USA", "He");
            
            sam.ViewProfile();

           string[] hob = {"listening to audiobooks and podcsts", "playing rec sports like bowling and kickball", "writing a specualtive fiction novel", "rading advice columns"};

            sam.SetHobbies(hob);



            //Console.WriteLine(sam.ViewProfile());


            Console.ReadLine();
        }
    }
}
