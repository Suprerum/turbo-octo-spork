using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkApp
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Painter> Painters { get; set; }
        public DbSet<Set> Sets { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=entityframeworkappdb;Trusted_Connection=True;");
        }
    }
}
