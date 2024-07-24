using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    internal class Parent
    {
        public virtual int Id { get; set; }

    }

    class Child :Parent
    {
        public override int Id { get => base.Id; set => base.Id = value; }

    }
    sealed class GrandChild:Child 
    {
        public override int Id { get => base.Id; set => base.Id = value; }
    }
}
