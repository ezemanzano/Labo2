using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Baraja
    {
        Carta[] barajaEspañola = new Carta[48];

        public Baraja()
        {
          for (int i = 0; i < 4; i++)
            {
                Carta newCarta;
                for (int j = 0; j < 12; j++)
                {
                    newCarta = new Carta((Carta.Valor)j+1, (Carta.Palo)i);
                    barajaEspañola[(i * 12) + j] = newCarta;
                }
            }
            
        }
       public static string MostrarBaraja(Baraja b)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Carta carta in b.barajaEspañola)
            {
                sb.AppendLine($"{carta.ObtenerNombre()}");
            }
            return sb.ToString();
            }

    }
}
