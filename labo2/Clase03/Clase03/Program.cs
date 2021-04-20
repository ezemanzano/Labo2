using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;



namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("manzano","ezequiel",120);
            Alumno alumno2 = new Alumno("sobrino", "leandro", 121);
            Alumno alumno3 = new Alumno("elena", "alvarojae", 122);

            alumno1.Estudiar(1, 2);
            alumno2.Estudiar(5, 6);
            alumno3.Estudiar(2, 5);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine (alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

        }
    }
}
