using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio38
{
    abstract class Sobreescrito
    {

        protected string miAtributo;

        protected Sobreescrito(string miAtributo)
        {
            this.miAtributo = miAtributo;
        }

        protected Sobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }

       protected abstract string MiPropiedad
            {
            get;
            }

        protected override string MiPropiedad
        {
            get
            {
               return this.miAtributo;
            }
        }

        public override string ToString()
        {
            return "Este es mi metodo sobreeesctrto";
        }

        public override bool Equals(object obj)
        {
            if(this == obj)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
