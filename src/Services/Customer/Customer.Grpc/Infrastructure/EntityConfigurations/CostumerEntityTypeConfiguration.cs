using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Customer.Grpc.Infrastructure.EntityConfigurations
{
    public class CostumerEntityTypeConfiguration
        : IEntityTypeConfiguration<Model.Customer>
    {

        public void Configure(EntityTypeBuilder<Model.Customer> modelBuilder)
        {
            modelBuilder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();
        }
    }
}
