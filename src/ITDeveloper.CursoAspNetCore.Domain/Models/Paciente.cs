using ITDeveloper.CursoAspNetCore.Domain.Entities;
using ITDeveloper.CursoAspNetCore.Domain.Enums;
using System;

namespace ITDeveloper.CursoAspNetCore.Domain.Models
{
	public class  Paciente : EntityBase

	{
		public Paciente()
		{
			this.DataCreated_at = DateTime.Now;
			this.Ativo = true;
		}
		public string Nome { get; set; }

		public string Email { get; set; }

		public bool Ativo { get; set; }

		public string Cpf { get; set; }

		public Sexo Sexo { get; set; }

		public TipoPaciente TipoPaciente { get; set; }

		public string Rg { get; set; }

		public string RgOrgao { get; set; } 

		public DateTime RgDataEmisao { get; set; }
		public DateTime DataInternacao { get; set; }
		public DateTime DataNascimento { get; set; }

		public DateTime DataCreated_at { get; set; }
	}
}
