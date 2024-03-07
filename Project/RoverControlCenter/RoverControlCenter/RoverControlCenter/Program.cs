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


             static void DirectAll(Rover[] rovers)
            {
                foreach (Rover rover in rovers)
                {
                    Console.WriteLine(rover.GetInfo());
                    Console.WriteLine(rover.Explore());
                    Console.WriteLine(rover.Collect());
                    Console.WriteLine();

                }
            }   
            
            
            DirectAll(rovers);

            Object[] rovers2 = {lunokhod, apollo, sojourner, sputnik };
            
            static void DirectAll2(Object[] rovers2)
            {
                foreach (Object rover2 in rovers2)
                {
                    Console.WriteLine($"Tracking a {rover2.GetType()}....");
                    Console.WriteLine();
                }
            }

            DirectAll2(rovers2);



            IDirectable[] probes = { lunokhod, apollo, sojourner, sputnik };


            static void DirectAll3(IDirectable[] probes)
            {
                foreach (IDirectable probe in probes)
                {
                    Console.WriteLine(probe.GetInfo());
                    Console.WriteLine(probe.Explore());
                    Console.WriteLine(probe.Collect());
                    Console.WriteLine();

                }
            }

            DirectAll3(probes);

            
           // Console.ReadLine();

        }

    }
}
