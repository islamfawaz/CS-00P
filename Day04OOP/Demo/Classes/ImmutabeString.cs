using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    internal class ImmutabeString
    {
        private readonly string value;
        public string Value { get { return value; } }
        public ImmutabeString(string value)
        {
            this.value = value;
        }
    }
}
