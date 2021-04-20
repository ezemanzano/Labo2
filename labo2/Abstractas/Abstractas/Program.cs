using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Vaca vaca = new Vaca("Vaquita");
            Animal vaca2 = new Vaca("otra vaca");
            Console.WriteLine(vaca.EmitirSonido());

            Animal g1 = new Gato("felix");
            GatoSiames g2 = new GatoSiames("felipe");

            Console.WriteLine(g1.EmitirSonido());
            Console.WriteLine(g2.EmitirSonido());

            

        }
    }
}
