using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado = "*";
            int cantidad;
            Console.WriteLine("Ingrese cantidad de *");
            cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i<cantidad; i++)
            {
                Console.WriteLine(resultado);
                resultado = resultado + "**";
            }

        }
    }
}
