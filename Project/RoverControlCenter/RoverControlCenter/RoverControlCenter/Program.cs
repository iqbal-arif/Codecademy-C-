namespace RoverControlCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rover Control Center!\n");

            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            Rover[] rovers = {lunokhod, apollo, sojourner };


            DirectAll(rovers);

            Console.ReadLine()

        }
             static void DirectAll(Rover[] rovers)
            {
                foreach (Rover rover in rovers)
                {
                    rover.GetInfo();
                    rover.Explore();
                    rover.Collect();

                }
            }

    }
}
