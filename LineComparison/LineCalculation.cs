using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public class LineCalculation
    {
        double xOnePoint, xTwoPoint, yOnePoint, yTwoPoint;
        public LineCalculation(double xOnePoint, double xTwoPoint, double yOnePoint, double yTwoPoint)
        {
            this.xOnePoint = xOnePoint;
            this.xTwoPoint = xTwoPoint;
            this.yOnePoint = yOnePoint;
            this.yTwoPoint = yTwoPoint;
        }
        public double LengthCalculate()
        {
            double result = Math.Sqrt(Math.Pow(this.xTwoPoint - this.xOnePoint, 2) + Math.Pow(this.yTwoPoint - this.yOnePoint, 2));
            return result;
        }
        public void Check(double lengthOne, double lengthTwo)
        {
            if (lengthOne.Equals(lengthTwo))
            {
                Console.WriteLine("The two lines are equal");
            }
            if (lengthOne.CompareTo(lengthTwo) < 0)
            {
                Console.WriteLine("The second line is greater than first line");
            }
            if (lengthOne.CompareTo(lengthTwo) > 0)
            {
                Console.WriteLine("The first line is greater than second line");
            }
        }
    }
}