using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final
{
	internal class Administrador
	{
		public Stack<Usuario> usuarios = new Stack<Usuario>();
		public Administrador()
		{
			Usuario us = new Usuario("Harold", 3006397804, "Hombre");
			this.usuarios.Push(us);
		}
	}
}
