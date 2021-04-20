using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    class Program
    {
        static void Main(string[] args)
        {
             /* Console.WriteLine("Holis");
            int valorEntero = 2;
            Console.WriteLine(valorEntero);
            
            string numeroEnterno = Console.ReadLine();
            
            int suma = valorEntero + int.Parse(numeroEnterno);
            Console.WriteLine(suma);

            Console.ReadKey();
            
            //////
            
            string dato;  
            float numeroDec;
             Console.WriteLine("Ingrese numero: ");
             dato = Console.ReadLine();
            numeroDec = float.Parse(dato);
             Console.WriteLine(QuitarEntero(numeroDec));
             */
             
            string palabra;
            int totalLetras;
            Console.WriteLine("Ingrese palabra: ");
            palabra = Console.ReadLine();
            totalLetras = ContarLetras(palabra,'a');
            Console.WriteLine(totalLetras);




        }
        
       
        public static int ContarLetras (string palabra, char letra) 
            {
                int contador=0;
                 foreach (char item in palabra.ToCharArray())
	                {
                    if (Char.ToLower (item) == Char.ToLower (letra)) 
                    {
                    contador++;     
                    }                  
            }
                return contador;
            }

        public static int ContarLetras2 (string palabra, char letra) 
            {
                int contador=0;
                 while ()
                    if (Char.ToLower (item) == Char.ToLower (letra)) 
                    {
                    contador++;     
                    }                  
            }
                return contador;
            }
    }
}
