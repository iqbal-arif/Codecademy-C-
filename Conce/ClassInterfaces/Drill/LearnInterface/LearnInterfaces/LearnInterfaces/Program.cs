namespace LearnInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LearnInterfaces!\n");

            //SEDAN

            Sedan sedan60 = new Sedan(60);
           // Sedan sedan70 = new Sedan(70);

            //Sedan Speed , Wheels, LicensePlate

            Console.WriteLine(sedan60.Speed); 
            Console.WriteLine(sedan60.Wheels); 
            Console.WriteLine(sedan60.LicensePlate);
            
           // Console.WriteLine(sedan70.Speed); 
           // Console.WriteLine(sedan70.Wheels); 
           // Console.WriteLine(sedan70.LicensePlate);

            sedan60.SpeedUp();
            Console.WriteLine();
           // sedan70.SpeedUp();
           // Console.WriteLine();
           // sedan70.Honk();


            //TRUCK

            Truck truck500 = new Truck(45,500);

            Console.WriteLine(truck500.Speed); 
            Console.WriteLine(truck500.Wheels); 
            //Console.WriteLine(truck500.LicensePlate); 

            truck500.SpeedUp();
            Console.WriteLine();
            //truck500.Honk();

            //BICYCLE

            Bicycle bicycle = new Bicycle(15);

            Console.WriteLine(bicycle.Speed);
            Console.WriteLine(bicycle.Wheels);
            //Console.WriteLine(bicycle.LicensePlate);

            bicycle.SpeedUp();
            Console.WriteLine();
            //bicycle.SlowDown();

            // Describe the Vehcle

            Console.WriteLine(sedan60.Describe());
            Console.WriteLine();
           // Console.WriteLine(sedan70.Describe());
            Console.WriteLine();
            Console.WriteLine(truck500.Describe());
            Console.WriteLine();
            Console.WriteLine(bicycle.Describe());





            Console.ReadLine();
        }
    }
}

