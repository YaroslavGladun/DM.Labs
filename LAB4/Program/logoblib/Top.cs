using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logoblib
{
    class Top
    {
        private char name;

        public Top(char name)
        {
            this.name = name;
        }

        public char Name { get => name; set => name = value; }
    }
}
