using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.Services.Contracts;
using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

namespace SchoolManagementSystem.Web.Controllers
{
    [Authorize(Roles = nameof(Student))]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> Dashboard()
        {
            var user = await _studentService.GetLoggedInUserAsync(HttpContext.User);

            if (user is null)
            {
                ModelState.AddModelError("user", NotLoggedIn);
                return RedirectToAction("Index", "Home");
            }
            
            if (user.IsAuthenticated is false)
            {
                return RedirectToAction("Index", "Home");
            }

            var student = await _studentService.GetStudentByUserIdAsync(user.AppId);
            if (student is null)
            {
                ModelState.AddModelError("user", InvalidUser);
                return RedirectToAction("Index", "Home");
            }

            var model = _studentService.GetDashboardViewModel(student);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Grades()
        {
            var user = await _studentService.GetLoggedInUserAsync(HttpContext.User);

            if (user is null)
            {
                ModelState.AddModelError("user", NotLoggedIn);
                return RedirectToAction("Index", "Home");
            }

            var student = await _studentService.GetStudentByUserIdAsync(user.AppId);
            if (student is null)
            {
                ModelState.AddModelError("user", InvalidUser);
                return RedirectToAction("Index", "Home");
            }
            
            if (user.IsAuthenticated is false)
            {
                return RedirectToAction("Index", "Home");
            }

            var models = _studentService.GetGradesViewModel(student);
            return View(models);
        }
    }


    //Test Purposes
    /*private async Task AddGradesToIvan()
    {
        var student = await _context.Students
            .FirstOrDefaultAsync(s => s.FirstName == "Ivan");

        var grade1 = new StudentGrade
        {
            StudentId = student.Id,
            Grade = 6,
            Subject = Subject.Biology
        };

        var grade2 = new StudentGrade
        {
            StudentId = student.Id,
            Grade = 5,
            Subject = Subject.Biology
        };

        var grade3 = new StudentGrade
        {
            StudentId = student.Id,
            Grade = 6,
            Subject = Subject.Maths
        };
        
        student.StudentGrades.Add(grade1);
        student.StudentGrades.Add(grade2);
        student.StudentGrades.Add(grade3);
        
        await _context.SaveChangesAsync();
    }*/
}