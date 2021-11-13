using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Line Comparison Computation Program");
            LineCalculation lineOne = new LineCalculation(23.0, 28.0, 14.0, 18.0);
            double lengthOne = lineOne.LengthCalculate();
            Console.WriteLine("The length of the first line is {0}", lengthOne);
            LineCalculation lineTwo = new LineCalculation(13.0, 19.0, 20.0, 11.0);
            double lengthTwo = lineTwo.LengthCalculate();
            Console.WriteLine("The length of the second line is {0}", lengthTwo);
            lineTwo.Check(lengthOne, lengthTwo);
        }
    }
}