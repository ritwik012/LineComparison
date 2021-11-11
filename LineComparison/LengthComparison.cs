using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    class LineCalculation
    {
        double xOnePt, xTwopt, yOnept, yTwopt;
        public LineCalculation(double xOnePt, double xTwopt, double yOnept, double yTwopt)
        {
            this.xOnePt = xOnePt;
            this.xTwopt = xTwopt;
            this.yOnept = yOnept;
            this.yTwopt = yTwopt;
        }
        public double lengthCalculation()
        {
            double result = Math.Sqrt(Math.Pow(this.xTwopt - this.xOnePt, 2) + (Math.Pow(this.yTwopt - this.yOnept, 2)));
            return result;
        }
        public void Check(double lengthOne, double lengthTwo)
        {
            if (lengthOne.CompareTo(lengthTwo) == 0)
                Console.WriteLine("Both the Lines are Equals");
            if (lengthOne.CompareTo(lengthTwo) > 0)
                Console.WriteLine("Line One is Greater then Line Two");
            if (lengthOne.CompareTo(lengthTwo) < 0)
                Console.WriteLine("Line Two is Greater then Line One");
        }
    }
}