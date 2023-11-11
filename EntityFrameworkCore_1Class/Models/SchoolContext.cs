using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_1Class.Models
{
    internal class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=MyDataBase2;Integrated Security=True;");
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Grade> Grade { get; set; }
    }
}
