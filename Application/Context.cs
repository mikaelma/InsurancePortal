using Domain;
using Domain.Insurance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Application
{
    public class Context: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<CarInsurance> CarInsurances { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
        }
    }
}