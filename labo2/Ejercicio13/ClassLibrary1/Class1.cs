using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static string DecimalBinario (int a)
        {
                   return "hola";
        }

        public static double BinarioDecimal(string b)
        {
            double total=0;
            for (int i =0 ; i<b.Length; i++)
            {
               if (b[i] == '1')
                {
                 total = total + (Math.Pow(2,(b.Length-i-1)));
                }
            }
            return total;
        }
    }
}
