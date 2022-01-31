using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lab4.Data;
using lab4_.Models;
public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<City>? Cities { get; set; }
    public DbSet<Province>? Provinces { get; set; }  
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
   base.OnModelCreating(modelBuilder);
   
   modelBuilder.Entity<City>().HasData(SampleData.GetCities());
   modelBuilder.Entity<Province>().HasData(SampleData.GetProvinces());
   
}
}
