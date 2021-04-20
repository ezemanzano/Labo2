using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class Cliente
    {
        string nombre;
        string apellido;
        long dni;
        string[] formasPago;
        string provincia;
        public Cliente(string nombre, string apellido, long dni, string[] formasPago, string provincia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.formasPago = formasPago;
            this.provincia = provincia;
        }

        private string mostrarNombres()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.nombre);
            sb.Append(this.apellido);
            sb.Append(this.dni);
            sb.Append(this.formasPago);
            sb.Append(this.provincia);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.mostrarNombres();
        }
    }
}
