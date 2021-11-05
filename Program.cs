using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Circle(5));
        }
        static double Rect(double length, double width)
        {
        return length * width;
        }
         static double Circle(double radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }
    }
}
