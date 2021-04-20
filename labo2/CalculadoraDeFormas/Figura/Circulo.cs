﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public sealed class Circulo : Figura
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando Circulo";
        }

        public override double CalcularSuperficie()
        {
            return (Math.PI)*(radio*radio);
        }

        public override double CalcularPerimetro()
        {
            return 2*Math.PI*radio;
        }

    }
}
