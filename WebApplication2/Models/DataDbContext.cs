using System.Collections.Generic;

namespace WebApplication2.Models
{
	public class DataDbContext : DbContext

	{
		public DataDbContext(DbContextOptions options) : base(options)
		{
		}


		public DbSet<user> Users
		{ get; set; }
	}
	}
	

