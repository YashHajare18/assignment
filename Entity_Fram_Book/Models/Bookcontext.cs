using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Fram_Book.Models
{
    public class Bookcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=DatabaseBooks;Integrated Security=True;");
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }

    }
}
