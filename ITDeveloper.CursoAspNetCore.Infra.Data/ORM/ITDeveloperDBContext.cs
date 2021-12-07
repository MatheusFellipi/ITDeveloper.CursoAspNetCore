using ITDeveloper.CursoAspNetCore.Domain.Entities;
using ITDeveloper.CursoAspNetCore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ITDeveloper.CursoAspNetCore.Infra.Data.ORM
{
	public class ITDeveloperDBContext : DbContext
	{
		public ITDeveloperDBContext(DbContextOptions<ITDeveloperDBContext> options)
		:base(options)
		{
		}

		public DbSet<Mural> Mural { get; set; }

		public DbSet<Paciente> Pacientes { get; set; }
	}  
}
