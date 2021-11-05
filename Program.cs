using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rect(10,15));
        }
        static double Rect(double length, double width)
        {
        return length * width;
        }
    }
}
