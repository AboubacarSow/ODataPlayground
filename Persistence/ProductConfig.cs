using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OdataRESTAPI.Models;

namespace OdataRESTAPI.Persistence;

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x=>x.Id);

        builder.Property(x=>x.Id)
        .ValueGeneratedOnAdd();

        builder.Property(x=>x.Name);
        builder.Property(x=>x.Price);
    }
}