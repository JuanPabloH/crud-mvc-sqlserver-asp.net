using Microsoft.EntityFrameworkCore;

namespace MvcSqlServer.Models
{
    public class ContextCrud: DbContext
    {
        public DbSet<Person> Persons { get; set; }

        
        public ContextCrud (DbContextOptions<ContextCrud> options): base(options)
        {
            
        }
    }
}