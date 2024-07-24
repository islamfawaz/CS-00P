using Demo.Inheritance;
using Demo.Polymorphism;

namespace Demo
{
    internal class Program
    {
        #region Polymorphism

        //public static double Sum(double X, double Y)
        //{
        //    return X + Y;
        //}
        //public static double Sum(double X, double Y, double Z)
        //{
        //    return X + Y + Z;
        //}
        //public static double Sum(int X, int Y, double Z)
        //{
        //    return X + Z;
        //}


        #endregion

        //public static void ProcessEmployee(Employee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.MyFun01(); // Static Binded Method => "I am Employee"
        //        employee.MyFun02(); // Dynamic Binded Method => specific to the derived class
        //    }
        //}
        static void Main(string[] args)
        {
            #region Class Video1
            //Car c1 = new Car(222);
            //Console.WriteLine(c1.ToString()); 
            #endregion

            #region Video3 inheritance
            // Child child = new Child(2, 2, 3);
            ///child.X = 1;
            ///child.Y = 2;
            //child.Z = 3;
            // Console.WriteLine(child.Product()); 
            #endregion

            #region Video8

            TypeA typeA = new TypeA(4);
            typeA.A = 11;
            typeA.MyFun01();
            typeA.MyFun02();
            TypeB typeB = new TypeB(4, 2);
            typeB.A = 11;
            typeB.B = 21;
            #endregion
            #region Video9 binding

            //           TypeA refBase=new TypeB(4, 2);

            //           refBase.A = 11;
            //        //   refBase.B=22;
            //           refBase.MyFun01();

            //0          refBase.MyFun02(); 
            #endregion

            #region Video10 contBinding
            //typeA=new TypeA(4);
            //typeA=new TypeB(4, 2);
            //typeA=new TypeC(4, 2,8);

            //TypeB typeB1 = new (TypeB) typeA;


            #endregion

            #region Video12 Binding behavior


            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Id = 10,
            //    Name = "Ahmed",
            //    Age = 23,
            //    Salary = 5000
            //};

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 20,
            //    Name = "Yassmin",
            //    Age = 25,
            //    HourRate = 120
            //};

            //ProcessEmployee(fullTimeEmployee);
            //ProcessEmployee(partTimeEmployee);
        }

        
        #endregion

            #region Video13 MorePractice

        //TypeC typeC = new TypeC(1, 10);
        //TypeD typeD = new TypeD(2, 20, 200);
        //TypeE typeE = new TypeE(3, 30, 300);

       
        #endregion

            
    }
}

