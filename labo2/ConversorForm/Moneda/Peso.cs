using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moneda;

namespace Moneda

{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        static Peso()
        {
            cotizRespectoDolar = 66;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Peso.cotizRespectoDolar;
        }
        public static void SetCotizacion(double cotizacion)
        {
            Peso.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.cantidad + ((Peso)e).GetCantidad());
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.cantidad + ((Peso)d).GetCantidad());
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.cantidad - ((Peso)e).GetCantidad());
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad - ((Dolar)d).GetCantidad());
        }

        public static bool operator ==(Peso s1, Peso s2)
        {
            return s1.cantidad == s2.cantidad;
        }

        public static bool operator !=(Peso s1, Peso s2)
        {
            return !(s1 == s2);
        }

        public static bool operator ==(Peso s1, Dolar s2)
        {
            return s1 == (Peso)s2;
        }

        public static bool operator !=(Peso s1, Dolar s2)
        {
            return !(s1 == s2);
        }

        public static bool operator ==(Peso s1, Euro s2)
        {
            return s1 == (Peso)s2;
        }

        public static bool operator !=(Peso s1, Euro s2)
        {
            return !(s1 == s2);
        }
    }
}
