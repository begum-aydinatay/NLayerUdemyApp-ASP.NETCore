using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Mitsubishi 9852EW HB",
                    Price = 10,
                    Stock = 100,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 2,
                    Name = "Faber Castell A4",
                    Price = 5,
                    Stock = 30,
                    CreatedDate = DateTime.Now,
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Name = "Sharpi Accent",
                    Price = 15,
                    Stock = 10,
                    CreatedDate = DateTime.Now,
                }
            );
        }
    }
}
