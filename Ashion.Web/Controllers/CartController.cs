using Ashion.Core.Contracts;
using Ashion.Web.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ICartService cart;

        public CartController(ICartService cart)
        {
            this.cart = cart;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult AddToCart()
        {
            return Ok();
        }

        public async Task<IActionResult> Mine()
        {
            if (this.User?.Identity?.IsAuthenticated != null 
                && this.User.Identity.IsAuthenticated)
            {
                //Check if user have items in Cart
                var userProductsInCart = await this.cart.GetUserProductsInCart(this.User.Id());

                return View(userProductsInCart);
            }
            else
            {
                
            }
            return View();
        }
    }
}
