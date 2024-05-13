using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CURD.Models;

namespace CURD.Data
{
    public class CURDContext : DbContext
    {
        public CURDContext (DbContextOptions<CURDContext> options)
            : base(options)
        {
        }

        public DbSet<CURD.Models.user> user { get; set; } = default!;
    }
}
