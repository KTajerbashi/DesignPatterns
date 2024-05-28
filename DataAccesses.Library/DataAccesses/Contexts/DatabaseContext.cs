using DataAccesses.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccesses.Contexts
{
    //public class DatabaseContext : IdentityDbContext
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //          optionsBuilder.UseSqlServer(@"
            //Data Source = TAJERBASHI;
            //Initial Catalog = Console_Database;
            //User ID = sa; 
            //Password = 123123;
            //TrustServerCertificate = True;"
            //            );
            //           optionsBuilder.UseSqlServer(@"
            //    Server=RHG-DATABASE\\DEV;
            //    Database=Design_Pattern_DB;
            //    User ID=sa; 
            //    Password=soft157703ware; 
            //    MultipleActiveResultSets=true;");
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<LogEvent> LogEvents { get; set; }  

    }

}
