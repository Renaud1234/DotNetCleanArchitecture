using CleanArchitectureDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDemo.Infra.Data.Persistence
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) 
            : base(options)
        {
        }


        public DbSet<Library> Libraries { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
