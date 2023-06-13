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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Make>().HasData(
                    new Make { Id = 1, Name = "Toyota" },
                    new Make { Id = 2, Name = "Honda" },
                    new Make { Id = 3, Name = "Ford" },
                    new Make { Id = 4, Name = "Nissan" },
                    new Make { Id = 5, Name = "Chevrolet" });


            //builder.Entity<Model>().HasData(
            //    new Model { Id = 1, Name = "Camry", MakeId = 1 },
            //    new Model { Id = 2, Name = "Corolla", MakeId = 1 },
            //    new Model { Id = 3, Name = "Accord", MakeId = 2 },
            //    new Model { Id = 4, Name = "Civic", MakeId = 2 },
            //    new Model { Id = 5, Name = "Focus", MakeId = 3 },
            //    new Model { Id = 6, Name = "Fusion", MakeId = 3 });

            base.OnModelCreating(builder);
        }

        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Make> Makers { get; set; } = null!;
        public virtual DbSet<Model> Models { get; set; } = null!;

    }
}