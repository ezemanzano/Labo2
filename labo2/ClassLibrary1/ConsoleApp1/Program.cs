using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> nuevalista = new List<Animal>()
            {
                new Gato(),
                 new Perro(),
                 new Animal(),
                 new Mascota()
            };

            //foreach (Animal animal in nuevalista)
            //{
            //    if (animal is Perro)
            //    {
            //        Perro perro = (Perro)animal;
            //        Console.WriteLine(perro.HacerSonido());
            //    }
            //    else if (animal is Gato)
            //    {
            //        Gato gato = (Gato)animal;
            //        Console.WriteLine(gato.HacerSonido());
            //    }
            //}

            foreach (Animal animal in nuevalista)
            {
                Console.WriteLine(animal.HacerSonido());
            }
        }
    }
}
