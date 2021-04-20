using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona    
    {
        private string nombre;
        private string apellido;
        private long dni;

        public string getNombre 
        { get
            {
                return this.nombre;
           }
            set
            {
                this.nombre = value;
            }
        }
        public string getApellido 
        {
             
                get
            {
                    return this.apellido;
                }
                set
            {
                    this.apellido = value;
                }
            }
        public long getDni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }


        public Persona(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string mostrarPersona()
        {
            return string.Format("Nombre: {0}, Apellido {1} , Dni {2}", this.nombre, this.apellido, this.dni);
        }
    }
}
