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

    [HttpGet]
    public async Task<IActionResult> Schools()
        => View(await _schoolService.GetAllSchoolsAsync());

    public async Task<IActionResult> Details(int id)
    {
        var model = await _schoolService.GetSchoolDetailsAsync(id);

        if (model is null)
        {
            return BadRequest();
        }
        
        return View(model);
    }
}