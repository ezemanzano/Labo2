using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class1;
namespace MiniSuper
{
           public static class MiniSuper
        {
            private static Cliente[] cliente;

            static MiniSuper()
            {
                cliente = new Cliente[0];
            }

            public static Cliente[] GetUsuarios()
            {
                return cliente;
            }

            public static bool AgregarUsuario(Cliente user)
            {
                //TODO sobrecargar el == para ver si el user existe ya
                foreach (Cliente item in cliente)
                {
                    if (user == item)
                    {
                        return false;
                    }
                }
                //si recorri y el user no esta:
                //usuarios += user;//TODO sobrecargar +=

                return true;
            }
        }
    

}

