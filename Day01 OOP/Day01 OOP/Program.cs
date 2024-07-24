
using System.Drawing;

namespace Demo
{
    enum Grade
    {
        A, B, C, D, E, F
    }
    enum Gender
    {
        male,
        female
    }
    enum Branch : byte
    {
        Dokki = 202, NasrCity, SmartVillage
    }
    internal class Program
    {
        [Flags]
        enum Permission : byte
        {
            write = 1, read = 2, execute = 4, delete = 8
        }
        class Employee
        {
            public int id { get; set; }
            public string name { get; set; }

            public decimal salary { get; set; }
            public Permission permission { get; set; }



        }



        static void Main(string[] args)
        {
            #region AccessModifiers Video3

            //TypeA obj =new TypeA();
            ////   obj.x=10
            ////   obj.y = 20;
            //obj.z = 10;

            #endregion

            #region Enum Example 1
            //    Grade G01 = Grade.A;
            //if (G01 == Grade.A)
            //{
            //    Console.WriteLine(")");

            //}
            //else
            //{
            //    Console.WriteLine("(");
            //}
            //G01 = (Grade)4;
            //Console.WriteLine(G01);

            #endregion
            // Gender myGender;
            #region Video5 Example2

            #region Parse Method
            //    myGender = Enum.Parse<Gender>(Console.ReadLine() ?? "", true);
            //    myGender= (Gender)Enum.Parse(typeof(Gender),"Male");

            #endregion
            #region TryParse
            //Enum.TryParse(typeof(Gender),Console.ReadLine(),true ,out object ? obj);
            //myGender = (Gender?) obj;

            // Enum.TryParse<Gender>(Console.ReadLine(), out myGender);
            // Console.WriteLine(myGender); 
            #endregion

            #endregion



            #region Video6 Example 3 


            //Employee employee = new Employee();
            //employee.id = 101;
            //employee.name = "Test";
            //employee.salary = 100;
            //employee.permission = (Permission)3;
            //Permission MyP = (Permission)3;
            //MyP = MyP |Permission.execute;
            //Console.WriteLine(MyP); 
            #endregion


            #region struct video7
            //Point P1;
            //P1= new Point(10,20);
            //Console.WriteLine(P1.ToString());
            #endregion


            #region encapsulation Video9
            //Employee emp1 = new Employee(1, "islam", 50000);

            //Console.WriteLine("Employee 1:");
            //Console.WriteLine(emp1);

            //// Modify employee salary
            //emp1.salary = 60000.00m;
            //Console.WriteLine("\nUpdated Salary:");
            //Console.WriteLine(emp1);
            #endregion


            #region Indexer Video10
            //phoneBook Note = new phoneBook(3);
            //Note.AddPerson(0, "Ahmed", 123);
            //Note.AddPerson(0, "islam", 456);
            //Note.AddPerson(0, "aya", 678);
            //Note.SetNumber("aya", 999);
            #endregion
        }



    }
}