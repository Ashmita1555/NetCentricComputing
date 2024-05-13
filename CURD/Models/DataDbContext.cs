using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CURD.Models
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