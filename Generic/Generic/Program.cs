using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            TelefonniSeznam telefonniSeznam = new TelefonniSeznam();

            telefonniSeznam.AddStudent(new Student { TelCislo = "09001531116", Jmeno = "Pavel", RodneCislo = "83545522365" } );
            telefonniSeznam.AddStudent(new Student { TelCislo = "420900531116", Jmeno = "Honza", RodneCislo = "88596522365" } );
            telefonniSeznam.AddStudent(new Student { TelCislo = "090182531116", Jmeno = "Ficko", RodneCislo = "08595522365" });

            Student student = new Student();
            if (telefonniSeznam.Find("420900531116", out student))
            {
                Console.WriteLine("Jmeno: {0}", student.Jmeno);
                Console.WriteLine(student.TelCislo);
                Console.WriteLine(student.RodneCislo);
            }
            else
            {
                Console.WriteLine("Zaznam neexistuje");
            }


            GenericSmallStack<string> stringSmallStack = new GenericSmallStack<string>();
            stringSmallStack.Pop();

            Console.ReadLine();
        }
    }
}
