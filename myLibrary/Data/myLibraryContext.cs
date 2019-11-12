using Microsoft.EntityFrameworkCore;
using myLibrary.Models;

namespace myLibrary.Data
{
    public class myLibraryContext : DbContext
    {
        public myLibraryContext(DbContextOptions<myLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}
