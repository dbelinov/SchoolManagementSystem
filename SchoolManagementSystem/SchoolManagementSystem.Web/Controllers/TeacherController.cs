using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Web.Controllers;

public class TeacherController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}