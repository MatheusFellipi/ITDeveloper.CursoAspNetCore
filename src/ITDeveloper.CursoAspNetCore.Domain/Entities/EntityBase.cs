using System;

namespace ITDeveloper.CursoAspNetCore.Domain.Entities
{
	public class EntityBase
	{
		public EntityBase()
		{
			this.Id = Guid.NewGuid();
		}
		public Guid Id { get; set; }
	}
}
