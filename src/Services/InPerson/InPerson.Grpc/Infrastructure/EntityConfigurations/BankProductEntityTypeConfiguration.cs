using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InPerson.Grpc.Infrastructure.EntityConfigurations
{
    public class BankProductEntityTypeConfiguration
        : IEntityTypeConfiguration<Model.BankProduct>
    {
        public void Configure(EntityTypeBuilder<Model.BankProduct> modelBuilder)
        {
            modelBuilder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();
        }
    }
}
