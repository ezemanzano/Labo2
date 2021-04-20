using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras;

namespace CalculadoraDeFormas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuritas = new List<Figura>() 
            {
                new Rectangulo(10,10),
                new Circulo(10),
                new Cuadrado(5)
            };

            foreach (Figura figura in figuritas)

            {
                Console.WriteLine($"{figura.Dibujar()} Area: {figura.CalcularSuperficie()} Perimetro: {figura.CalcularPerimetro()}");
            }


        }
    }
}
