using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static SchoolManagementSystem.Common.EntityConstants.IdentityConstants;

namespace SchoolManagementSystem.Web.Areas.Admin.Controllers;

[Area(AdminAreaName)]
[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    [HttpGet]
    public IActionResult Dashboard()
    {
        return View();
    }
}