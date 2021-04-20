﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
     public abstract class Llamada    
    {
       public enum TipoLlamada
        {
            Local,
            Provincia,
            Todas
        }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        { get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public abstract float CostoLlamada
        {
            get;
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion {this.duracion}, Nro Destino: {this.nroOrigen}, Nro Origen: {this.NroDestino}");
            return sb.ToString();
        }

        public static int OrdenarPorDuracion (Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            else
                return 0;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if (l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            if (!(l1==l2))
                return true;
            else
                return false;
        }

    }
}
