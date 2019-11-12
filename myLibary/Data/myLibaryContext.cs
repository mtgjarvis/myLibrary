using Microsoft.EntityFrameworkCore;
using myLibary.Models;

namespace myLibary.Data
{
    public class myLibaryContext : DbContext
    {
        public myLibaryContext(DbContextOptions<myLibaryContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}
