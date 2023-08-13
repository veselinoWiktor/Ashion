using Ashion.Core.Contracts;
using Ashion.Core.Models.Products;
using Ashion.Core.Models.Shop;
using Ashion.Web.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Experimental.ProjectCache;
using System.Text;

namespace Ashion.Web.Controllers
{
    [Authorize]
    public class LikesController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILikesService likes;

        public LikesController(ILikesService likes)
        {
            this.likes = likes;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Mine()
        {
            if (this.User?.Identity?.IsAuthenticated == false)
            {
                var likedProducts = HttpContext.Session.Get<List<LikedProductServiceModel>>("likes");

                return View(likedProducts);
            }

            return Ok();
            //var likedProducts = likes.GetUserLikedProducts();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Like(int id, [FromQuery] string type)
        {
            if (this.User?.Identity?.IsAuthenticated == false)
            {
                var likedProducts = HttpContext.Session.Get<List<LikedProductServiceModel>>("likes");
                var likedProduct = await likes.GetLikedProduct(id, type);

                if (likedProducts == null)
                {
                    likedProducts = new List<LikedProductServiceModel>() { likedProduct };
                }
                else
                {
                    int index = likedProducts.FindIndex(p => p.Id == id && p.Type == type);

                    if (index != -1)
                    {
                        return BadRequest();
                    }

                    likedProducts.Add(likedProduct);

                }

                HttpContext.Session.Set("likes", likedProducts);
            }
            var check = HttpContext.Session.Get<List<LikedProductServiceModel>>("likes");

            return new JsonResult("everythins is okay");
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult UnLike(int id)
        {
            if (this.User?.Identity?.IsAuthenticated == false)
            {
                var likedProducts = HttpContext.Session.Get<List<ShopProductServiceModel>>("likes");

                if (likedProducts == null)
                {
                    return BadRequest();
                }
                else
                {
                    int index = likedProducts.FindIndex(p => p.Id == id);

                    if (index == -1)
                    {
                        return BadRequest();
                    }

                    likedProducts.RemoveAt(index);
                }

                HttpContext.Session.Set("likes", likedProducts);
            }

            return Ok();
        }
    }
}
