﻿using System;

namespace Methods
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                System.Console.WriteLine("Conversion failed");
            }
            //code above and below do the same thing but different ways.
            // Parse on top TryParse on bottom


            int number;
            var result =  int.TryParse("abc", out number);
            if (result)
                System.Console.WriteLine(number);
            else   
                System.Console.WriteLine("Conversion failed.");
        }

        static void UseParams()
        {
            var calcultor = new Calculator();
            System.Console.WriteLine(calcultor.Add(1, 2));
            System.Console.WriteLine(calcultor.Add(1, 2, 3 ));
            System.Console.WriteLine(calcultor.Add(1, 2, 3, 4));
            System.Console.WriteLine(calcultor.Add(new int[]{1, 2, 3 , 4, 5}));
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
