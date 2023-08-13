using Ashion.Core.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Core.Contracts
{
    public interface ILikesService
    {
        Task<LikedProductServiceModel> GetLikedProduct(int id, string type);
    }
}
