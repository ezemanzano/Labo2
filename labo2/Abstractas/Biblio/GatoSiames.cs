﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractas

{
    public class GatoSiames:Gato
    {
        public GatoSiames(string nombre) :base(nombre)
        {

        }

        public override string EmitirSonido()
        {
            return "Ruido siames";
        }
        
    }
}
