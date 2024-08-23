using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature
                {
                    Id = 1,
                    Color = "Brown",
                    Height = 100,
                    Width = 5,
                    ProductId = 1,
                },
                new ProductFeature
                {
                    Id = 2,
                    Color = "Yellow",
                    Height = 300,
                    Width = 10,
                    ProductId = 3,
                }
            );
        }
    }
}
