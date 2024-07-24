using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism
{
    class TypeA
    {
        public int A { get; set; }
        public TypeA(int _A)
        {
            A = _A;
        }
        public void MyFun01()
        {
            Console.WriteLine("I am base");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A} ");
        }
    }

    class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _A, int _B) : base(_A)
        {
            B = _B;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am derived");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A} ,B = {B}");
        }
    }

    class TypeC : TypeA
    {
        public int C { get; set; }
        public TypeC(int _A, int _C) : base(_A)
        {
            C = _C;
        }

        public override void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A}, C = {C}");
        }
    }

    class TypeD : TypeB
    {
        public int D { get; set; }
        public TypeD(int _A, int _B, int _D) : base(_A, _B)
        {
            D = _D;
        }

        public override void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A}, B = {B}, D = {D}");
        }
    }

    class TypeE : TypeC
    {
        public int E { get; set; }
        public TypeE(int _A, int _C, int _E) : base(_A, _C)
        {
            E = _E;
        }

        public override void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A}, C = {C}, E = {E}");
        }
    }
}
