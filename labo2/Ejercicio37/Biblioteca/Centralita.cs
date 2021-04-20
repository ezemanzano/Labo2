using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string razonSocial)
            : this()
        {
            this.razonSocial = razonSocial;
        }

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincia);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float valorRecaudado = 0;
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Local)
                        {
                            Local local = (Local)llamada;
                            valorRecaudado += local.CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Provincia:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Provincial)
                        {
                            Provincial provincial = (Provincial)llamada;
                            valorRecaudado += provincial.CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Local)
                        {
                            Local local = (Local)llamada;
                            valorRecaudado += local.CostoLlamada;
                        }
                        else if (llamada is Provincial)
                        {
                            Provincial provincial = (Provincial)llamada;
                            valorRecaudado = valorRecaudado + provincial.CostoLlamada;
                        }
                    }
                    break;
            }
            return valorRecaudado;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------DATOS DE LA EMPRESA------------------\n");
            sb.AppendLine($"Nombre de la empresa: {this.razonSocial}");
            sb.AppendLine($"Ganancia Total: {GananciasPorTotal} Pesos.");
            sb.AppendLine($"Ganancia por llamada local: {GananciasPorLocal} Pesos.");
            sb.AppendLine($"Ganancia por llamada provincial: {GananciasPorProvincial} Pesos.");
            sb.AppendLine("\n--------------------------LLAMADAS------------------------\n");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                sb.AppendLine(llamada.ToString());
                sb.AppendLine("----------------------------------------------------------\n");
            }
            return sb.ToString();
        }
      
        private void AgregarLlamada(Llamada l1)
        {
            if (l1 != null)
            {
                listaDeLlamadas.Add(l1);
            }
        }


        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public static bool operator == (Centralita c, Llamada llamada)
        {
            for (int i = 0; i < c.listaDeLlamadas.Count; i++)
            {
                if (c.listaDeLlamadas[i] == llamada)
                {
                    return true;
                }
            }
            return false;
            
        }


        public static bool operator !=(Centralita c, Llamada llamada)
        {
            for (int i = 0; i < c.listaDeLlamadas.Count; i++)
            {
                if (c.listaDeLlamadas[i] == llamada)
                {
                    return false;
                }                
            }
            return true;

        }


        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (!(c == nuevaLlamada))
            {
                c.AgregarLlamada(nuevaLlamada);
                return c;
            }
            else
            {
                Console.WriteLine("La llamada ya se encuentra en la central");
                return c;
            }
        }


    }
}
