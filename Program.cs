using System;

namespace Methods
{
    class Program
    {
        public class Calculator
        {
            
        }
        static void Main(string[] args)
        {
            
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y); 
            }
            catch (Exception)
            {
                System.Console.WriteLine("An unexpected error occured");
            }
           
        }
    }
}
