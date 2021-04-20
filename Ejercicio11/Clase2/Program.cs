using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            float total = 0;
            int max = 0;
            int min = 0;
            int numeroIngresado;
            
            while (i<10)
            {
                Console.WriteLine("Ingrese numero -100 a 100");
                numeroIngresado = int.Parse(Console.ReadLine());              
                if ( Validacion.Validar(numeroIngresado, -100, 100) == true)
                {
                    total = total + numeroIngresado;

                    if (i==0)
                    {
                        max = numeroIngresado;
                        min = numeroIngresado;           
                    }
                    else if ( numeroIngresado<min)
                    {
                        min = numeroIngresado;
                    }
                    else if (numeroIngresado > max)
                    {
                        max = numeroIngresado;
                    }
                     
                    i++;

                }
                else
                {
                    Console.WriteLine("ERROR.");
                }
                
               

                
            }
            Console.WriteLine(" El max es: " + (max));
            Console.WriteLine(" El max es: " + (min));
            Console.WriteLine(" El promedio es: " + ((float)total / 10));
        }
    }
}
