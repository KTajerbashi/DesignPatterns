using Microsoft.EntityFrameworkCore;

namespace DataAccesses.Contexts.QueriesContextDatabase
{
    public class QueriesDatabaseContext : DbContext
    {
        public QueriesDatabaseContext(DbContextOptions<QueriesDatabaseContext> options) : base(options)
        {}
    }
}
