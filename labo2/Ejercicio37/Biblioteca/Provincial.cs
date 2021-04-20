using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Provincial:Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
       
        protected Franja franjaHoraria;
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(string origen, Franja mifranja, float duracion, string destino)
        : base(duracion,destino,origen)
        {
            this.franjaHoraria = mifranja;
        }

        public Provincial( Llamada llamada, Franja miFranja) 
            :this(llamada.NroOrigen,miFranja,llamada.Duracion, llamada.NroDestino)
        {
            
        }
       



        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {this.CalcularCosto()} Franja Horaria {this.franjaHoraria}");
            return sb.ToString();
        }

        /*
        public override bool Equals(object obj)
        {
           if (this == obj)
            {
                return true;
            }
           else
            {
                return false;
            }
        }
        */
        public override string ToString()
        {
            return this.Mostrar();
        }

        private float CalcularCosto()
        {
            float resul=0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                   resul= this.duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    resul= this.duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    resul= this.duracion * 0.66f;
                    break;
            }
            return resul;

        }



    }
}
