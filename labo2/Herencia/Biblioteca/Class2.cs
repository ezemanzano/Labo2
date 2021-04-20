using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Alumno:Persona
    {
        private int legajo;
        private List<string> materias;

        public Alumno(Persona p , int legajo) : base(p.getNombre, p.getApellido,p.getDni)
        {
            this.legajo = legajo;
            this.materias = new List<string>();
        }


        public Alumno(string nombre, string apellido, long dni, int legajo) : this(new Persona(nombre, apellido, dni),legajo)
        {
                
        }

        
    }
}
