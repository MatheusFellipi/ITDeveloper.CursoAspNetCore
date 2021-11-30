using System;

namespace ITDeveloper.CursoAspNetCore.Domain.Entities
{
	public class Mural
	{
		public int MuralId  { get; set; }

		public DateTime Data  { get; set; }

		public string Titulo { get; set; }

		public string Aviso { get; set; }

		public string Autor { get; set; }

		public string Email { get; set; }


	}
}
