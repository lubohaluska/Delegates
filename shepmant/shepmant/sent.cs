using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shepmant
{
    class sent
    {
        private string tracknumber;
        public ArrayList Polozky = new ArrayList();

        public void AddItem(int PocetKusu, string NazevPolozky, double CenaZaKus)
        {
            Item item = new Item();
            item.PocetKusu = PocetKusu;
            item.NazevPolozky = NazevPolozky;
            item.CenaZaKus = CenaZaKus;

            Polozky.Add(item);

        }


//// trace cislo
        public string TrackNumber
        {
            get
            {
                return tracknumber;
            }
            set
            {
                tracknumber = value;
                TrackingNumberAdded?.Invoke(GetInfo());
            }

        }

//vyoise hlasenie na konzolu
        public delegate void TrackNumberHandler(string message);
        public event TrackNumberHandler TrackingNumberAdded;



        public string GetInfo()
        {
            string VypisBalik = "";
            for (int i=0; i < Polozky.Count ;i++)
            {

// v tejto triede vyberam z itemu jednotlive polozky
                VypisBalik += tracknumber + " " + ((Item)Polozky[i]).NazevPolozky + " " + ((Item)Polozky[i]).PocetKusu + Environment.NewLine;
            }
            return VypisBalik;
        }


    }
}
