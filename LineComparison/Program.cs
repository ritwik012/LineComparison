using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Program");
            LineCalculation ln = new LineCalculation(6.0, 2.0, 3.0, 5.0);
            double lengthOne = ln.lengthCalculation();
            Console.WriteLine("The Length of the First Line is {0}", lengthOne);
            double lengthTwo = ln.lengthCalculation();
            Console.WriteLine("The Length of Second Line is {0}", lengthTwo);
            ln.Check(lengthOne, lengthTwo);
        }
    }
}