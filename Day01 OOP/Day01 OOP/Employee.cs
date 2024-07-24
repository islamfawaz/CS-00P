using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day01_OOP
{
     struct Employee
    {
        public int ID;  
        private string Name;
        public decimal salary; 


        public decimal Salary {
            get
            {
                return salary;
            }


            set
            {
                salary = value;
            }
        
        }


        public Employee(int _ID,string _name,decimal _salary) {
            ID = _ID;
            Name = _name;
            salary = _salary;

        }

        public override string ToString()
        {
            return $"id: {ID} \nName : {Name} \n Salary : {salary:c})";
        }

    }
}
