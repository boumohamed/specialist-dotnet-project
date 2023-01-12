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
                Email = "Bouzri@gmail.com",
                id = Guid.NewGuid().ToString(),
                FirstName = "Mohamed",
                LastName = "Bouzri",
                Tel = "06555891",
                Speciality = "Medcin",
                city = "Casablanca",
                joined = DateTime.Now
            });
            modelBuilder.Entity<Specialist>().HasData(new Specialist
            {
                Image = "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg",
                Email = "sanae@gmail.com",
                id = Guid.NewGuid().ToString(),
                LastName = "Bouzri",
                FirstName = "Sanae",
                Tel = "06555891",
                Speciality = "Medcin",
                city = "rabat",
                joined = DateTime.Now
            });

            modelBuilder.Entity<Specialist>().HasData(new Specialist
            {
                Image = "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg",
                Email = "jana@gmail.com",
                id = Guid.NewGuid().ToString(),
                LastName = "Bouzri",
                FirstName = "Jana",
                Speciality = "Medcin",
                city = "Tanger",
                joined = DateTime.Now
            });


        }
    }
}
