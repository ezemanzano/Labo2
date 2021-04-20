using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractas
{
    public class Vaca : Animal
    {
        public Vaca(string nombre) : base(nombre)
        {

        }

        protected override bool EsDomestico
        {
            get
            {
                return false;
            }
        }

        public override string EmitirSonido()
        {
            return "muuuu";
        }

    }
}

