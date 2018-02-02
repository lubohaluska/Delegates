using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class TelefonniSeznam
    {
//genericky nadefinovany zoznam
        Dictionary<string, Student> seznam = new Dictionary<string, Student>();

        public void AddStudent(Student student)
        {

            //ideme skontrolovat, ci sa uz v zozname nenachadza
            try
            {
                seznam.Add(student.TelCislo, student);
                // nenachadza doplni
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.ToString());
                //nachadza zahlasi sa chyba
            }

        }

        public bool Find(string telCislo, out Student student)
        {

//ked najde zaznam tak ho vrati a nplni
            return seznam.TryGetValue(telCislo, out student);
        }


    }
}
