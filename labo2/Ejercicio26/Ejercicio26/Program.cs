using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {

           int[] numerosRandom = new int[20];
           for (int i = 0; i < numerosRandom.GetLength(0); i++)
           {
                Random testeo = new Random();
                numerosRandom[i]= testeo.Next(100);
           }

            foreach (int item in numerosRandom)
            {
                Console.WriteLine($"Numero = {item}");
            }
           
           

        }
    }
}
