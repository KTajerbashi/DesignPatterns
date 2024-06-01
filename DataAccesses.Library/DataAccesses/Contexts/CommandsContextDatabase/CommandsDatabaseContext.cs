using DataAccesses.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccesses.Contexts.CommandsContextDatabase
{
    public class CommandsDatabaseContext : DbContext
    {
        public CommandsDatabaseContext(DbContextOptions<CommandsDatabaseContext> options) : base(options)
        {
        }
        public DbSet<LogEvent> LogEvents { get; set; }
    }
}

//optionsBuilder.UseSqlServer(@"
//Data Source = TAJERBASHI;
//Initial Catalog = Console_Database;
//User ID = sa; 
//Password = 123123;
//TrustServerCertificate = True;");
//optionsBuilder.UseSqlServer(@"
//Server=RHG-DATABASE\\DEV;
//Database=Design_Pattern_DB;
//User ID=sa; 
//Password=soft157703ware; 
//MultipleActiveResultSets=true;");