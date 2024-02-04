// See https://aka.ms/new-console-template for more information



using System.Globalization;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Architec Arithmetic!\n");


            double AreaRectangle = RectangleArea(4, 5);
            Console.WriteLine("Rectangle Area : " + AreaRectangle);

            double AreaCircle = CircleArea(4,2);
            Console.WriteLine("Circle Area : " + AreaCircle);

            double AreaTriangle = TriangleArea(10, 9);
            Console.WriteLine("Triangle Area : " + AreaTriangle);


            
            double areaHalfCircleTH = CircleArea(375, 2) / 2;
            Console.WriteLine("Half Circle Area : " + areaHalfCircleTH);

            double areaRectangleTH = RectangleArea(1500, 2500);
            Console.WriteLine("Rectangle Area : " + areaRectangleTH);

            double areaTriangleTH = TriangleArea(750, 500);
            Console.WriteLine("Triangle Area : " + areaTriangleTH);

            double totalArea = areaHalfCircleTH + areaRectangleTH + areaTriangleTH;
            double mexicanPesos = 180;
            double totalCost = totalArea * mexicanPesos;
            string formattedPesos = string.Format(new CultureInfo("es-MX"),"{0:C0}",totalCost);
            Console.WriteLine($"Teotiuacan Total Area is {totalArea}, and it will cost around {formattedPesos} Mexican Pesos to construct this strcuture");

           ///One line Code for Calculating the COST OF THE STRUCTURE
            double TotalAreaCost = CalculateTotalCost(4, 5, 10, 9, 4, 2, 18);
            Console.WriteLine($"Total Cost of the Structure per square meter is {TotalAreaCost}");
        }
        public static double RectangleArea(double length, double width)
        {
            double area;
            return area = length * width;
        }
        public static double CircleArea(double baseValue , double power)
        {
            double area;
            return area = Math.Round(Math.PI * Math.Pow(baseValue, power));
        }
        public static double TriangleArea(double bottom, double height)
        {
            double area;
            return area = 0.5 * bottom * height;
        }

        public static double CalculateTotalCost(double length, double width, double bottom, double height, double baseValue, double power, double cost)
        {
            Console.WriteLine("Welcome to CodeCademy Architect Cost Estimator!!\n In order to calculate the square meter of the structure, follow the steps given below.");
            Console.WriteLine("Break the structure into \"Recatangle\", \"Triangle\", and \"Circle\".");
            Console.WriteLine("Enter the Dimension of each geomertical shape in the following manner:");
            Console.WriteLine("");
            Console.WriteLine("Enter the Length and Width of the Rectangle");
            Console.WriteLine("Enter the bottom and height of the Triangle");
            Console.WriteLine("Enter the baseValue and power of the Circle");
            Console.WriteLine("Enter the cost per square meter");

            double areaHalfCircleTH = CircleArea(375, 2) / 2;
           // Console.WriteLine("Half Circle Area : " + areaHalfCircleTH);

            double areaRectangleTH = RectangleArea(1500, 2500);
           // Console.WriteLine("Rectangle Area : " + areaRectangleTH);

            double areaTriangleTH = TriangleArea(750, 500);
           // Console.WriteLine("Triangle Area : " + areaTriangleTH);

            double totalArea = areaHalfCircleTH + areaRectangleTH + areaTriangleTH;
            double mexicanPesos = 180;
            double totalCost = 0;
            return totalCost = totalArea * mexicanPesos; 
            
            string formattedPesos = string.Format(new CultureInfo("es-MX"), "{0:C0}", totalCost);
            Console.WriteLine($"Teotiuacan Total Area is {totalArea}, and it will cost around {formattedPesos} Mexican Pesos to construct this strcuture");


        }
    }
}