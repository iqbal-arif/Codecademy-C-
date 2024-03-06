﻿namespace RoverControlCenter
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


            Rover[] rovers = {lunokhod, apollo, sojourner, sputnik };


             static void DirectAll(Rover[] rovers)
            {
                foreach (Rover rover in rovers)
                {
                    Console.WriteLine(rover.GetInfo());
                    Console.WriteLine(rover.Explore());
                    Console.WriteLine(rover.Collect());

                }
            }   
            
            
            DirectAll(rovers);

            Object[] rovers2 = {lunokhod, apollo, sojourner, sputnik };
            
            static void DirectAll2(Object[] rovers2)
            {
                foreach (Rover rover in rovers2)
                {
                    Console.WriteLine(rover.GetType());
                    Console.WriteLine(rover.GetType());
                    Console.WriteLine(rover.GetType());

                }
            }

            DirectAll2(rovers);
            
            
            
            
            
            
            Console.ReadLine();

        }

    }
}
