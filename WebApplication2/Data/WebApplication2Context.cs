using System.Collections.Generic;

namespace WebApplication2.Data
{
	public class WebApplication2Context: DbContext
	{
		
			public WebApplication2Context(DbContextOptions <WebApplication2Context> options): base(options)
			{
			}

			public DbSet<WebApplication2Context.Models.user> user { get; set; } = default!;
		}
	}


