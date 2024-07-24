using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }

        public void MyFun01()
        {
            Console.WriteLine("I am Employee");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"Employee: Id: {Id}, Name: {Name}, Age: {Age}");
        }

    }

    public class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public new void MyFun01()
        {
            Console.WriteLine("I am FullTime Employee");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"FullTime Employee: Id = {Id}, Name = {Name}, Age = {Age}, Salary = {Salary}");
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }

    public class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }

        public new void MyFun01()
        {
            Console.WriteLine("I am PartTime Employee");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"PartTime Employee: Id = {Id}, Name = {Name}, Age = {Age}, HourRate = {HourRate}");
        }
    }


}
