using Microsoft.EntityFrameworkCore;

namespace BookShop.Models
{
    public sealed class Db : DbContext
    {

        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public Db()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1;DataBase=BookShop;User ID=admin; Password=1234");
        }
    }
}
