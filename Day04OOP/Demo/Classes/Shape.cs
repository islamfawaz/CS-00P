using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        public abstract decimal CalcArea();
        public abstract decimal Perimeter { get;}

    }

    class Rectangle:Shape
    {
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;   
        }
        public override decimal Perimeter {get => Dim01 + Dim02; }
    }

    class Square:Shape{
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;

        }
        public override decimal Perimeter =>2*Dim01;

    }

    class Circle:Shape
    {
        public Circle(decimal Raduis)
        {
            this.Dim01 =Dim02 = Raduis;
        }

        public override decimal CalcArea()=> (decimal)Math.PI * this.Dim01 * Dim02;
        public override decimal Perimeter => (decimal)Math.PI * this.Dim01 * 2;



    }

}

