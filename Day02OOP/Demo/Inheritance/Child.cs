using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Child :Parent
    {
        public int Z  { get; set; }

        public Child(int _X,int _Y ,int _Z):base(_X,_Y)
        { 
         //X = _X;
         //Y = _Y;
         Z = _Z; 
        }
        public new int Product()
        {
            return base.Product() *Z;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nZ: {Z}";
        } 
    }
}
