using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Ashion.Web.Areas.Admin.AdminConstants;

namespace Ashion.Web.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class AdminController : Controller
    {
    }
}
