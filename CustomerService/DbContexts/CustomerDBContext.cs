using Microsoft.EntityFrameworkCore;
using CustomerService.Models;
using System.Reflection.Metadata;
using System.Diagnostics;

namespace CustomerService.DbContexts
{
    public class CustomerDBContext:DbContext
    {
        public CustomerDBContext(DbContextOptions options) : base(options)
        { 
        
        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Offer> offers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Offer>()
                .HasOne(o => o.customer)
                .WithMany(c => c.offers)
                .HasForeignKey(o => o.customerId);

            modelBuilder.Entity<Customer>()
            .Navigation(c => c.offers)
            .UsePropertyAccessMode(PropertyAccessMode.Property);
            /*
            modelBuilder.Entity<Student>()
                .HasRequired<Grade>(s => s.CurrentGrade)
                .WithMany(g => g.Students);*/
        }

    }
}
