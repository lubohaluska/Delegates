using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shepmant
{
    class Program
    {
        static void Main(string[] args)
        {
            sent s = new sent();

            // naplnenie udajov do bazy

            s.AddItem(1, "Balik cislo 1", 4.50 );

            s.AddItem(2, "Balik cislo 2", 5.50);

            s.AddItem(3, "Balik cislo 3", 6.50);


            //prirazeni notifikace metody udalosti
            notifikace n = new notifikace();
            s.TrackingNumberAdded += n.Notify;

            s.TrackNumber = "123456das";

            Console.ReadLine();

        }
    }
}
