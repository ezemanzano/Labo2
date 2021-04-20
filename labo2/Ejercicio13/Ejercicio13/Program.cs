using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            string binario;
            Console.WriteLine("ingrese bin");
            binario = Console.ReadLine();
            Console.WriteLine("Resultado" + ClassLibrary1.Class1.BinarioDecimal(binario));




        }
    }
}
