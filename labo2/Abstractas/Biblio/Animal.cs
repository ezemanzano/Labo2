using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractas
{
    public abstract class Animal
    {
        protected string nombre;

        protected Animal(string nombre)
        {
            this.nombre = nombre;
        }

        protected abstract bool EsDomestico { get; }
        public abstract string EmitirSonido();


    }
}
