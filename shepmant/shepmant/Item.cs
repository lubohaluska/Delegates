using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shepmant
{
    class Item
    {
        public int PocetKusu;
        public string NazevPolozky;
        public double CenaZaKus;

        public static Item item { get; internal set; }
    }
}
