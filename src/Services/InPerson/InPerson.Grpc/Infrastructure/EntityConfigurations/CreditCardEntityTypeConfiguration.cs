using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InPerson.Grpc.Infrastructure.EntityConfigurations
{
    public class CreditCardEntityTypeConfiguration
        : IEntityTypeConfiguration<Model.CreditCard>
    {
        public void Configure(EntityTypeBuilder<Model.CreditCard> modelBuilder)
        {
            modelBuilder.Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();
        }
    }
}
