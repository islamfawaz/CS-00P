using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    internal partial class Employee :Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        partial void DoSomeCode();


    }
}
