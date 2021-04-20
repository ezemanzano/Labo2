using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
     public class Local:Llamada
    {
        protected float costo;


        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Local(string nroOrigen, float duracion, string nroDestino, float costo)
             : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        
       
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append($" Costo: {this.costo}");
            return sb.ToString();
        
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        private float CalcularCosto()
        {
            return (this.duracion * this.costo);
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

    }
}
