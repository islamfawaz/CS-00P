using System;
using System.IO.Pipes;

namespace Assignment
{
    internal enum SecurityLevel : byte
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8

    }

    class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel Security { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public char Gender { get; set; }

        public Employee(int id, string name, SecurityLevel security, decimal salary, DateTime hireDate, char gender)
        {
            ID = id;
            Name = name;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"Employee ID: {ID}\nName: {Name}\nSecurity Level: {Security}\nSalary: {Salary:C}\nHire Date: {HireDate:d}\nGender: {Gender}";
        }

    }






    public class HiringDate
    {
        public int Day { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }

        public HiringDate(int day, int month, int year)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12");
            }

            if (year < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(year), "Year must be a positive number");
            }

            int daysInMonth = month switch
            {
                2 when IsLeapYear(year) => 29,
                2 => 28,
                4 or 6 or 9 or 11 => 30,
                _ => 31
            };

            if (day < 1 || day > daysInMonth)
            {
                throw new ArgumentOutOfRangeException(nameof(day), $"Day must be between 1 and {daysInMonth} for month {month}");
            }

            Day = day;
            Month = month;
            Year = year;
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            //1 Try all what we have learned in the lecture.

            // class is blue print or template base on objedt
            // contructor help us to create and update object
            // constructor overloading : have more than constructor with same name
            // can distinguish between by type or quantity or arrangment of parameter

            //class use to do business object
            //stack is very fast in alllocate and dellocate memory because it has fixed size
            //use to store local variable

            //heap is more flexable than stack but is slower becuae it has no fixed size
            //it allocate and dellocate using new keyword
            //use to store reference type

            // dependency injection --->
            // dependency : class depend on another class if i edit in class another must be editing
            // injection :inject the constructor 

            //Inheritance : use of inheritance to not repeat the code
            //inheritane is relation ship key word 
            // ex: fulltime employee is employee
            //      dog is animal
            //Association :Has
            //ex: order has order item
            //    department has employee
            //==============================================================================================
            // Any constructor in class Child By default do chaning on empty constructor of
            // class parent

            //Assosiation  Composition :car has engine (mandatory) 
            //Assosiation  Aggregation :may be null string ?name

            //Polymorphism
            //1-overloading                 2-overriding
            //1.1 indexable overloading
            //1.2 constructor overloading
            //1.3 object overloading
            //1.4 casting overloading

            // overloading -> is good for readability
            // overloading :if i has more than function have same name
            // support in class and struct
            //distinguish between by type or quantity or arrangment of parameter
            // give function power to do more than job
            // ex: + operator do summing and concate

            //overriding 
            // if i have inheritance relation ship
            // by using new key word or overriding

            //Binding  is a behavior
            //reference from parent ->object from child

            //RefBase.A=10; correct
            //RefBase.B=22;wrong

            // using new key word is static
            // using ovverriding is dynamic


            #endregion


            #region Question1
            //  1 Design and implement a Class for the employees in a company:
            //var employees = new Employee[]
            //    {
            //     new Employee(1, "islam", SecurityLevel.Developer, 80000, new DateTime(2023, 3, 15), 'M'),
            //     new Employee(2, "fawaz", SecurityLevel.Secretary, 25000, new DateTime(2021, 8, 10), 'M'),
            //   };
            // Console.WriteLine(employees);



            #endregion



            #region Question2
            //HiringDate hiringDate = new HiringDate(15, 12, 2002);
            //Console.WriteLine(hiringDate.ToString());
            //Console.WriteLine(hiringDate.ToDateTime());
            #endregion


            #region Question4
            //            Array.Sort(employees, (emp1, emp2) => emp1.HireDate.CompareTo(emp2.HireDate));

            //            foreach (var emp in employees)
            //            {
            //                Console.WriteLine(emp);
            //            }

            //            int boxingCount = 0;
            //            int unboxingCount = 0;

            //            foreach (var emp in employees)
            //            {
            //                object boxedEmp = emp;

            //                if (boxedEmp is Employee unboxedEmp)
            //                {
            //                    unboxingCount++;
            //                }
            //            }

            //            Console.WriteLine($"Boxing count: {boxingCount}");
            //            Console.WriteLine($"Unboxing count: {unboxingCount}");
            //        }
            //    }
            //}
            #endregion


        }
    }
}

  