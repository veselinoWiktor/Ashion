using Ashion.Core.Models.Shop;
using Ashion.WebApi.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ashion.WebApi.Controllers
{
    [ApiController]
    [Route("likes/[action]/{id?}")]
    public class LikesApiController : ControllerBase
    {
        //[HttpPost]
        //public async Task<IActionResult> Like(int id)
        //{
        //    if (this.User?.Identity?.IsAuthenticated == false)
        //    {
        //        var likedProducts = HttpContext.Session.Get<List<ShopProductServiceModel>>("likes");
        //        if (likedProducts == null)
        //        {
        //            likedProducts = new List<ShopProductServiceModel>();
        //            likedProducts.Add(new ShopProductServiceModel() { Id = 53, Brand = "nike" });
        //        }
        //        else
        //        {
        //            int index = likedProducts.FindIndex(p => p.Id == id);

        //            if (index != -1)
        //            {
        //                return BadRequest();
        //            }

        //            likedProducts.Add(new ShopProductServiceModel());

        //        }

        //        HttpContext.Session.Set("likes", likedProducts);
        //    }
        //    var check = HttpContext.Session.Get<List<ShopProductServiceModel>>("likes");

        //    return new EmptyResult();
        //}
    }
}
