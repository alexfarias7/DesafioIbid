using DesafioIbid.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioIbid.Datas.Maps
{
    public class ProductMap : IEntityTypeConfiguration<ProductModel>
    {
        public void Configure(EntityTypeBuilder<ProductModel> builder)
        {
            builder.HasKey(product => product.Id);
            builder.Property(product => product.Name).IsRequired().HasMaxLength(255); 
            builder.Property(product => product.Description).IsRequired().HasMaxLength(255);
            builder.Property(product => product.Price).IsRequired(); 
        }
    }
}
