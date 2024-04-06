using Microsoft.EntityFrameworkCore;

namespace Mission11_Zhang.Models
{
    public class BooksDbContext : DbContext
    {
        public BooksDbContext()
        {

        }
        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options) { } 
        public DbSet<Book> Books { get; set; }
    }
}
