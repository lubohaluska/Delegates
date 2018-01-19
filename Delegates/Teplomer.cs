using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Timers;

namespace Delegates
{
    class Teplomer
    {
        private Timer timer;  //zvysovanie teploty simulujeme odpocitavanim cez timer

        private Random randomizer = new Random();

        public delegate void PrehratiHandle(int teplota);
        public event PrehratiHandle Prehrati;

        public Teplomer()
        {
            timer = new Timer(randomizer.Next(2000, 10000));
            timer.Start();
            timer.Elapsed += Timer_Elapsed;
        }

        //toto sa vygenerovalo zo systemu automaticky
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //            throw new NotImplementedException(); toto nepotrebujeme

            timer.Stop();   ///tymto ho zastavime

            //            timer.Elapsed -= timer.Elapsed;  //takto by sme tuto funkciu odpocitali a event by skoncil

            if (Prehrati != null)   //kontrola ci tam je nejaka teplota
            {
                Prehrati(100);
            }

        }
    }
}
