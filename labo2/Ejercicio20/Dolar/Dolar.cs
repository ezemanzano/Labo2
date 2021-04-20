using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolar
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;


        static Dolar()
        {
           cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
            :this(cantidad)
        {
            
           cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Dolar (double d)
        {             
            return new Dolar(d);
        }




    }



}
