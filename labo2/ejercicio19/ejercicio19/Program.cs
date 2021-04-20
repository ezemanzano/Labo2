using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = 1;
            long num2 = 3;
            string text = "falo";
            string text2 = "pa";

            Sumador test1 = new Sumador();

            Console.WriteLine(test1.Sumar(num1, num2));
            Console.WriteLine(test1.Sumar(text, text2));




        }
    }
}
