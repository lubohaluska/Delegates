using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Stroj
    {
        private string nazevStroje;
        private Teplomer teplomer = new Teplomer();

        public Stroj(string nazevStroje)
        {
            teplomer.Prehrati += onPrehratiStroje; ///reakcia na event teplomeru

            this.nazevStroje = nazevStroje;
        }

        private void onPrehratiStroje(int teplota)
        {
            Console.WriteLine("Teplota je hranicna, vypni sa");
            VypniStroj();
        }

        public void ZapniStroj()
        {
        Console.WriteLine("zapinam" + nazevStroje);
        }


        public void VypniStroj()
        {
        Console.WriteLine("vypinam" + nazevStroje);
        }
    }
}
