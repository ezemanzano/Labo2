using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre)
           : this()
        {
            this.nombre = nombre;
        }


        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                bool retorno = (this + value);
            }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cli in n.clientes)
            {
                if (cli == c)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            foreach (Cliente cli in n.clientes)
            {
                if (cli == c)
                    return true;
            }
            return false;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }
    }
}
