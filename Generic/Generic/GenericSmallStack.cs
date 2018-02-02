using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    //toto je nas vygenerovany generic s umelym 
    class  GenericSmallStack<T>
    {
        private T[] pole = new T[10];
        private int index = 0; //index, ktoru ukazuje posledny prvok zasobniku

        public void Push(T obj)
        {
            if (index == pole.Length - 1)
            {
                //vyhadyujeme vynimku, je na konci pola, uz sa neprida
                throw new IndexOutOfRangeException();
            }
            pole[index] = obj;
            index++;
        }



        public T Pop()
        {

            if (index - 1 < 0)
            {
                throw new IndexOutOfRangeException();
            }
            /*           int res = pole[index];
                       index--;
                       return res;
                       */
            //zapisane inak  
            return pole[index--];
        }



    }
}
