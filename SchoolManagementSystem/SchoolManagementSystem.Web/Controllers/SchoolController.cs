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
    public IActionResult Schools()
        => View(_schoolService.GetAllSchoolsAsync());

    public async Task<IActionResult> Details(int id)
    {
        var model = await _schoolService.GetSchoolDetailsAsync(id);

        if (model is null)
        {
            return BadRequest();
        }
        
        return View(model);
    }
    
    [HttpGet]
    public IActionResult Search(string query, int? page)
    {
        int pageSize = 6;
        int pageNumber = page ?? 1;

        var schools = _schoolService.SearchSchools(query, pageNumber, pageSize);
        return View("Schools", schools);
    }
}