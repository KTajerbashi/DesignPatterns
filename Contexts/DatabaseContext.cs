using DesignPatterns.Composite.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Contexts
{
    //public class DatabaseContext : IdentityDbContext
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }


        public DbSet<CategoryComponent> CategoryComponents { get; set; }
        private DbSet<CategoryComposite> CategoryComposites { get; set; }
        private DbSet<CategoryItemLeaf> CategoryItemLeaves { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
Data Source = TAJERBASHI;
Initial Catalog = Console_Database;
User ID = sa; 
Password = 123123;
TrustServerCertificate = True;"
            );
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }

}
