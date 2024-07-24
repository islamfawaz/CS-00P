using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association_Aggregation
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee[] ? Employee { get; set; }

        public Department(string name)
        {
          Name = name;
        }

        public Department(string name, Employee[] employees)
        {
            Name = name;
            Employee = employees;
        }
    }
}
