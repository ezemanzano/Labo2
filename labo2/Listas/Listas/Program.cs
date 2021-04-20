using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            ProbarPilas();

        }

        static void ProbarListas()
        {
            
            List<int> numeros = new List<int>();
            numeros.Add(2);
            numeros[0] = 1;
            int unNumero = numeros[0];
            numeros.Add(7);
            numeros.Add(4);

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            numeros.Sort(Comparar);
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }      
        }
        /// <summary>
        /// (al revés)si a es mayor a b devuelve un positivo, si b es menor a b negativo
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Comparar(int a, int b)
        {
            return b -a ;
        }

        static void ProbarDiccionario()
        {
            Dictionary<string, int> guiaTel= new Dictionary<string, int>(); 
            guiaTel.Add("eze",12312) ;
            guiaTel.Add("fede", 123123111);
            foreach (KeyValuePair<string,int> agendados in guiaTel)
            {
                Console.WriteLine($"Apellidos {agendados.Key} Telefono {agendados.Value}");
            }
            Console.WriteLine($"Busco por clave {guiaTel["eze"]}");
            guiaTel["eze"] = 21212111;
            Console.WriteLine($"Busco por clave {guiaTel["eze"]}");
            Console.WriteLine($"contiene la clave? {guiaTel.ContainsKey("fede")}"); // para ver si contiene la clave // aplica tmb con Value.
        }

        static void ProbarColas()
        {
            Queue<string> prueba = new Queue<string>();
            prueba.Enqueue("eze");
            prueba.Enqueue("fde");
            prueba.Enqueue("weas");

            foreach (string nombre in prueba)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine(prueba.Peek());

            Console.WriteLine(prueba.Dequeue()); // saco un elemento de la cola FIFO
            
            
            foreach (string nombre in prueba)
            {
                Console.WriteLine(nombre);
            }

        }



        static void ProbarPilas()
        {
            // orden LIFO ultimo en entrar primero en salir
            Stack<string> prueba = new Stack<string>();
            prueba.Push("eze");
            prueba.Push("fde");
            prueba.Push("weas");

            foreach (string nombre in prueba)
            {
                Console.WriteLine(nombre);
            }

        }


    }
}
