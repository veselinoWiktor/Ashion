using Ashion.Core.Contracts;
using Ashion.Web.Extensions;
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

        public async Task<IActionResult> Details(int id, string information)
        {
            if (!(await cosmetics.Exists(id)))
            {
                return BadRequest();
            }

            var cosmeticModel = await this.cosmetics.CosmeticDetailsById(id);

            if (information != cosmeticModel.GetInformation())
            {
                return BadRequest();
            }

            return View(cosmeticModel);
        }
    }
}
