using Microsoft.EntityFrameworkCore;
using UdemyJwtApp.Back.Core.Domain;
using UdemyJwtApp.Back.Persistance.Configurations;

namespace UdemyJwtApp.Back.Persistance.Context
{
    public class UdemyJwtContext : DbContext
    {
        public UdemyJwtContext(DbContextOptions<UdemyJwtContext> options) : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<AppUser> AppUsers => Set<AppUser>();
        public DbSet<AppRole>AppRoles =>Set<AppRole>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
