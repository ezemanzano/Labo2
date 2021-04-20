using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public  abstract class Figura
    {
        public virtual string Dibujar()
        {
            return "Haciendo dibujo";
        }

        public abstract double CalcularSuperficie();
        public abstract double CalcularPerimetro();


    }
}
