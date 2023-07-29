using Ashion.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace Ashion.Infrastructure.Data.Configurations
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasData(CreateSizes());
        }

        private static List<Size> CreateSizes()
        {
            return new List<Size>()
            {
                new Size() { Id = 1, SizeNumber = "XS" },
                new Size() { Id = 2, SizeNumber = "S" },
                new Size() { Id = 3, SizeNumber = "M" },
                new Size() { Id = 4, SizeNumber = "L" },
                new Size() { Id = 5, SizeNumber = "XL" },
                new Size() { Id = 6, SizeNumber = "XXL" },
            };
        }
    }
}
