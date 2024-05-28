using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

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

    }
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            //optionsBuilder.UseSqlServer(@"
            //                                Server=rhg-database.roshdgroup.net\dev;
            //                                Database=Design_Pattern_DB;
            //                                User ID=sa; 
            //                                Password=soft157703ware; 
            //                                MultipleActiveResultSets=true;
            //                                TrustServerCertificate=True");

            optionsBuilder.UseSqlServer(@"
                                            Server=TAJERBASHI;
                                            Database=Design_Pattern_DB;
                                            User ID=sa; 
                                            Password=123123; 
                                            MultipleActiveResultSets=true;
                                            TrustServerCertificate=True");

            return new DatabaseContext(optionsBuilder.Options);
        }
    }

}
