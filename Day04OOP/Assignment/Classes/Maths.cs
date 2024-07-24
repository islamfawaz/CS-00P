using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Classes
{
    internal static class Maths
    {
        public static double Num01 { get; set; }
        public static double Num02 { get; set; }

        public static int Add(int num01, int num02)
        {
            return num01 + num02;
        }

        public static int Subtract(int num01, int num02)
        {
            return num01 - num02;
        }

        public static int Mult(int num01, int num02)
        {
            return num01 * num02;
        }

        public static double Divide(int num01, int num02)
        {
            if (num02 == 0)
            {
                throw new DivideByZeroException("Cant divide by zero.");
            }
            return (double)num01 / num02;
        }






    }
}
