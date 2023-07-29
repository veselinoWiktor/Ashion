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
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        private readonly bool seedDb;

        public ReviewConfiguration(bool seedDb = true)
        {
            this.seedDb = seedDb;
        }

        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder
                .HasOne(r => r.FromUser)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            //if (seedDb)
            //{
            //    builder
            //        .HasData(CreateReviews());
            //}
        }

        private static List<Review> CreateReviews()
        {
            throw new NotImplementedException();
        }
    }
}
