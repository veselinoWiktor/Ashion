using Ashion.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace Ashion.Infrastructure.Data.Configurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(CreateColors());
        }

        private static List<Color> CreateColors()
        {
            return new List<Color>()
            {
                new Color() { Id = 1, Name = "Beige" },
                new Color() { Id = 2, Name = "Black" },
                new Color() { Id = 3, Name = "Blue" },
                new Color() { Id = 4, Name = "Brown" },
                new Color() { Id = 5, Name = "Gray" },
                new Color() { Id = 6, Name = "Green" },
                new Color() { Id = 7, Name = "Orange" },
                new Color() { Id = 8, Name = "Pink"},
                new Color() { Id = 9, Name = "Purple" },
                new Color() { Id = 10, Name = "Red" },
                new Color() { Id = 11, Name = "White" },
                new Color() { Id = 12, Name = "Yellow" }
            };
        }
    }
}
