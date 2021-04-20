using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            Alumno alumni = new Alumno("tete","Manzano",212122,2212);
            Persona personita = new Persona("sofi","gonzale",6666);
            
           Console.WriteLine(alumni.mostrarPersona());
        }
    }
}
