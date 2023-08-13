using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Areas.Admin.Controllers
{
    public class ClothesController : AdminController
    {
        [HttpGet]
        public IActionResult All()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
