using System;

namespace PARCIALTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Orquesta orquestaUno = new Orquesta("alvarogay","caballito","orquesta gay",1);
            Console.WriteLine("Nombre : {0}",orquestaUno.nombre);
            

        }
    }
}
