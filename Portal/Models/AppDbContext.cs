using Microsoft.EntityFrameworkCore;

namespace Portal.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasMany(a => a.Admin)
            .WithOne(b => b.User)
            .HasForeignKey(b => b.UserId);
        }
    }
}
