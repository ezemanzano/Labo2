using Business;
using System;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {

            Baraja bajaraEspañola = new Baraja();
            Console.WriteLine(Baraja.MostrarBaraja(bajaraEspañola));
            Console.ReadKey();
        }
    }
}
