using System;
using System.Collections.Generic;
using System.Text;

namespace PARCIALTEST
{
	public class Orquesta
	{
		public String nombre;
		public String lugar;
		public String tipo;
		public int idOrquesta;
		public Orquesta()
		{

		}
		public Orquesta(String nombre, String lugar, String tipo, int idOrquesta)
		{
			this.nombre = nombre;
			this.lugar = lugar;
			this.tipo = tipo;
			this.idOrquesta = idOrquesta;
		}
	}
}
