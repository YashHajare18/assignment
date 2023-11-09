using Microsoft.EntityFrameworkCore;

namespace Mvc_with__Entity.Models
{
    public class Appdbcontext :DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options):base(options)
        { 

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
