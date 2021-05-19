using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class Base
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public Base()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
