using DataLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class ServiceStationContext : IdentityDbContext<Employee>
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Inspector> Inspectors { get; set; }
        public DbSet<Owner> Owners { get; set; }

        public ServiceStationContext(DbContextOptions<ServiceStationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
