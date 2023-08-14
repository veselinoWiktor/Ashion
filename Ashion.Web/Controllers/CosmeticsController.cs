using Ashion.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Controllers
{
    public class CosmeticsController : Controller
    {
        private readonly ICosmeticsService cosmetics;

        public CosmeticsController(ICosmeticsService cosmetics)
        {
            this.cosmetics = cosmetics;
        }

        public async Task<IActionResult> Details(int id)
        {
            if (!(await cosmetics.Exists(id)))
            {
                return BadRequest();
            }

            var cosmeticModel = await this.cosmetics.CosmeticDetailsById(id);

            return View(cosmeticModel);
        }
    }
}
