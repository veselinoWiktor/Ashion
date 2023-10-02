using Ashion.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Infrastructure.Data.Configurations
{
    public class UserCartConfiguration : IEntityTypeConfiguration<UserCart>
    {
        public void Configure(EntityTypeBuilder<UserCart> builder)
        {
            builder.HasKey(uc => new { uc.UserId, uc.ProductId, uc.ProductType });

            builder
                .HasOne(uc => uc.User)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
