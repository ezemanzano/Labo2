using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sumador
    {
        private int cantidadSumas;



        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador()
            : this(0)
        {

        }

        public long Sumar(long numero1, long numero2)
        {
            this.cantidadSumas++;
            return numero1 + numero2;
        }

        public string Sumar(string string1, string string2)
        {
            this.cantidadSumas++;
            return string1 + string2;
        }

        public static explicit operator int(Sumador s)
        {
            return (int)s.cantidadSumas;
        }

        public static long operator + (Sumador s, Sumador s1)
            {
                return s.cantidadSumas + s1.cantidadSumas;
            }

        public static bool operator |(Sumador s, Sumador s1)
        {
            if (s.cantidadSumas  == s1.cantidadSumas)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
