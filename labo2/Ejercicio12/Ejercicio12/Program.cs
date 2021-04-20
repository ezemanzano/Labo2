using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            char resultado;
            int numeroIngresado = 0;
            int total = 0;         
            do
            {            
                Console.WriteLine("Ingrese numero:");
                numeroIngresado = int.Parse(Console.ReadLine());
                total = total + numeroIngresado;
                Console.WriteLine("Desea continuar?");
                resultado = char.Parse(Console.ReadLine());
            } while (Validar.ValidarS_N(resultado) == true);

            Console.WriteLine("Total:" + total);

        }
    }
}
