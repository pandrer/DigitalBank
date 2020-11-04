using Customer.Grpc.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Customer.Grpc.Infrastructure
{
    public class CustomerContext : DbContext
    {

        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        public DbSet<Model.Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CostumerEntityTypeConfiguration());
        }
    }
}
