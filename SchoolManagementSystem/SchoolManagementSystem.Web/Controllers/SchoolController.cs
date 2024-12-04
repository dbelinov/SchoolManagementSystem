using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Services.Contracts;

namespace SchoolManagementSystem.Web.Controllers;

public class SchoolController : Controller
{
    private readonly ISchoolService _schoolService;

    public SchoolController(ISchoolService schoolService)
    {
        _schoolService = schoolService;
    }

    public async Task<IActionResult> Schools()
        => View(await _schoolService.GetAllSchoolsAsync());
}