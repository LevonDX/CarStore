using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Make> Makers { get; set; } = null!;
        public virtual DbSet<Model> Models { get; set; } = null!;

    }
}