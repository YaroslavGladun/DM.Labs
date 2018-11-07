using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logoblib
{
    class Top
    {
        private string name;

        public Top(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
