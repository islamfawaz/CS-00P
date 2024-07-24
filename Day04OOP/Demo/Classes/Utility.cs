using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    internal class Utility
    {
        public int X { get; set; }
        public int Y { get; set; }
       
        public Utility(int X ,int Y)
        {
            this.X = X;
            this.Y = Y; 
        }
        
        public override string ToString()
        {
            return $"X equal {X} ,Y equal {Y}";
        }
        public static double CmToInch(double Cm)
        {
            return Cm/2.54;
        }

        public static double CalcCircleArea(double Radius)
        {
            return 3.14 *Radius *Radius;
        }


    }
}
