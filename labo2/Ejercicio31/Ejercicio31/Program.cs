using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(123);
            Cliente c2 = new Cliente(123);
            Cliente c3 = new Cliente(456);
            Cliente c4 = new Cliente(789);
            Negocio negocio = new Negocio("utn");
            
            
            if (negocio + c1)
                Console.WriteLine("agregado");
            else
                Console.WriteLine("no se puede agregar");
            if (negocio + c3)
                Console.WriteLine("agregado");
            else
                Console.WriteLine("no se puede agregar");
            if (negocio + c2)
                Console.WriteLine("agregado");
            else
                Console.WriteLine("no se puede agregar");



            while (~negocio)
            {
                Console.WriteLine("cliente atendido!! quedan ");
            }
        }
    }
}
