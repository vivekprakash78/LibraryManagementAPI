using Microsoft.EntityFrameworkCore;

namespace DatabaseService
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }
}