using Microsoft.EntityFrameworkCore;

namespace JwtInveonOrnek.Entities
{
    public class ApplicationDbContext : DbContext
    {
        //Veritabanına hazırladığımız  modeli tablo olarak eklemesini söylüyoruz.
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        //Veritabanı olarak SQLite kullanacağımı söylüyoruz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=jwtSampleInveon.db");

        //Veritabanı oluşturulurken dummy data ile oluşturulmasını istiyoruz.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = 1,
                FirstName = "test",
                Username = "testUser",
                Password = "testPassword"
            });
        }
    }
}
