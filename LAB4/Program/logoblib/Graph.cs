using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logoblib
{
    public class Graph
    {
        private List<Top> tops;
        private List<Rib> ribs;

        public Graph()
        {
            tops = new List<Top>();
            ribs = new List<Rib>();
        }

        public void AddTop(string name)
        {
            tops.Add(new Top(name)); // Upgrade this teqnique
        }

        public void AddRib(string start_top_name, string end_top_name)
        {
            // Write this teqnique
        }
    }
}
