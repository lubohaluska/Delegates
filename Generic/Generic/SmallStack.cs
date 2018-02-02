using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class SmallStack
    {
        private int[] pole = new int[10];
        private int index = 0; //index, ktoru ukazuje posledny prvok zasobniku

        public void Push(int cislo)
        {
            if (index == pole.Length-1)
            {
                //vyhadyujeme vynimku, je na konci pola, uz sa neprida
                throw new IndexOutOfRangeException();
            }
            pole[index] = cislo;
            index++;
        }
        


        public int Pop()
        {

            if (index-1 < 0)
            {
                throw new IndexOutOfRangeException();
            }
            int res = pole[index];
            index--;
            return res;

            //zapisane inak return pole[index--];
        }



    }
}
