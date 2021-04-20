using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;


        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
            :this()
            {
                this.dni = dni;
                this.nombre = nombre;
            }

        public Jugador (int dni, string nombre, int totalGoles,int totalPartidos)
            :this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public float GetPromedioGoles()
        {
            if (this.partidosJugados != 0)
                return (float)this.totalGoles / this.partidosJugados;
            else
                return -1;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}, Dni: {this.dni.ToString()}");
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1.dni == j2.dni)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            if (j1.dni != j2.dni)
            {
                return true;
            }
            else
                return false;

        }

    }
}
