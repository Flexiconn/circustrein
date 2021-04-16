using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circustreinui.models
{
    class Trein
    {
        public List<Wagon> Wagons { get; set; }
        public string Naampie { get; set; }

        public Trein()
        {
            Wagons = new List<Wagon>();
        }
    }
}
