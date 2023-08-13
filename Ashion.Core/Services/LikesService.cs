using Ashion.Core.Contracts;
using Ashion.Core.Models.ProductsShared;
using Ashion.Infrastructure.Common;
using Ashion.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Core.Services
{
    public class LikesService : ILikesService
    {
        private readonly IRepository repository;

        public LikesService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<LikedProductServiceModel> GetLikedProduct(int id, string type)
        {
            if (type.ToLower() == "cloth")
            {
                return await repository.AllReadonly<Cloth>()
                    .Where(c => c.Id == id)
                    .Select(c => new LikedProductServiceModel()
                    {
                        Id = c.Id,
                        Type = "Cloth",
                        Name = c.Name,
                        Brand = c.Brand,
                        ImageUrl = c.Images.First().Url,
                        Price = c.Price,
                    })
                    .FirstAsync();
            }
            else if(type.ToLower() == "accessory")
            {
                return await repository.AllReadonly<Accessory>()
                    .Where(c => c.Id == id)
                    .Select(c => new LikedProductServiceModel()
                    {
                        Id = c.Id,
                        Type = "Cloth",
                        Name = c.Name,
                        Brand = c.Brand,
                        ImageUrl = c.Images.First().Url,
                        Price = c.Price,
                    })
                    .FirstAsync();
            }
            else if(type.ToLower() == "cosmetic")
            {
                return await repository.AllReadonly<Accessory>()
                    .Where(c => c.Id == id)
                    .Select(c => new LikedProductServiceModel()
                    {
                        Id = c.Id,
                        Type = "Cloth",
                        Name = c.Name,
                        Brand = c.Brand,
                        ImageUrl = c.Images.First().Url,
                        Price = c.Price,
                    })
                    .FirstAsync();
            }

            return default;
        }
    }
}
