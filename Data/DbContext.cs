using Microsoft.EntityFrameworkCore;

namespace FicmaDT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add DbSet properties for your entities
        public DbSet<YourEntity> YourEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize your model with Fluent API here
        }
    }

    public class YourEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Other properties
    }
}
