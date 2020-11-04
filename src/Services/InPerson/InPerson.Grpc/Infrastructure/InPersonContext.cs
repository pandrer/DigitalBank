using InPerson.Grpc.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace InPerson.Grpc.Infrastructure
{
    public class InPersonContext : DbContext
    {
        public InPersonContext(DbContextOptions<InPersonContext> options) : base(options)
        {
        }

        public DbSet<Model.BankProduct> BankProduct { get; set; }
        public DbSet<Model.CreditCard> CreditCard { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BankProductEntityTypeConfiguration());
            builder.ApplyConfiguration(new CreditCardEntityTypeConfiguration());
        }
    }
}
