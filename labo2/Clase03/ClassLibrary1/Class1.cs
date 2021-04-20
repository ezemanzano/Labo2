using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public Alumno (string apellido,string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            this.notaFinal = -1;
           
            if (this.nota1 >=4 && this.nota2>=4)
            {
                this.notaFinal = 10;
            }
           
        }

        public void Estudiar (byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public string Mostrar()
        {
            string retorno = "-1";
           if (this.notaFinal>1)
            {
             retorno = $" nombre:{this.apellido} {this.notaFinal}";
            }
            return retorno;
        }
    }
}
