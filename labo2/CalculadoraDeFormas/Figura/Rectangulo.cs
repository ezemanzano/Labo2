using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Rectangulo : Figura
    {
        protected double lado1;
        protected double lado2;

        public Rectangulo(double lado1, double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo";
        }

        public override double CalcularSuperficie()
        {
            return lado1 * lado2;
        }

        public override double CalcularPerimetro()
        {
            return 2*(lado1+lado2);
        }

    }
}
