using Microsoft.EntityFrameworkCore;
using SpecilisteServiceApi.Models;
using System.Reflection.Metadata;

namespace SpecilisteServiceApi.DbContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { 
        
        }

        public DbSet<Specialist> Specialists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Guid myuuid = Guid.NewGuid();
            modelBuilder.Entity<Specialist>().HasData(new Specialist
            {
                Image = "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg",
                SpecialistEmail = "Bouzri@gmail.com",
                SpecialistID = Guid.NewGuid().ToString(),
                SpecialistName = "Bouzri Mohamed",
                SpecialistTel = "06555891",
            });
            modelBuilder.Entity<Specialist>().HasData(new Specialist
            {
                Image = "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg",
                SpecialistEmail = "sanae@gmail.com",
                SpecialistID = Guid.NewGuid().ToString(),
                SpecialistName = "Bouzri Sanae",
                SpecialistTel = "06555891",
            });

            modelBuilder.Entity<Specialist>().HasData(new Specialist
            {
                Image = "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg",
                SpecialistEmail = "jana@gmail.com",
                SpecialistID = Guid.NewGuid().ToString(),
                SpecialistName = "Bouzri Jana",
                SpecialistTel = "06555891",
            });


        }
    }
}
