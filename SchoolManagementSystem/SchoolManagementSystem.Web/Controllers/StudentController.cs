using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Services.Contracts;
using SchoolManagementSystem.Web.ViewModels;

namespace SchoolManagementSystem.Web.Controllers
{
    [Authorize(Roles = nameof(Student))]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly ApplicationDbContext _context;

        public StudentController(IStudentService studentService, ApplicationDbContext context)
        {
            _studentService = studentService;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Dashboard()
        {
            var user = await _studentService.GetLoggedInUserAsync(HttpContext.User);

            if (user is null)
            {
                return BadRequest();
            }
            
            if (user.IsAuthenticated is false)
            {
                return RedirectToAction("Index", "Home");
            }

            var student = await _studentService.GetStudentByUserIdAsync(user.AppId);
            if (student is null)
            {
                return BadRequest();
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
                return BadRequest();
            }
            
            if (user.IsAuthenticated is false)
            {
                return BadRequest();
            }

            var student = await _studentService.GetStudentByUserIdAsync(user.AppId);
            if (student is null)
            {
                return BadRequest();
            }

            // await AddGradesToIvan();
            // await AddGradesToGencho();
            // await AddGradesToMartin();
            
            var models = _studentService.GetGradesViewModel(student);
            return View(models);
        }

        [HttpGet]
        public async Task<IActionResult> Projects()
        {
            var model = await _studentService.GetStudentProjectsAsync(User);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> JoinProject(int projectId)
        {
            var success = await _studentService.JoinProjectAsync(User, projectId);
            if (!success)
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(Projects));
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> LeaveProject(int projectId)
        {
            var success = await _studentService.LeaveProjectAsync(User, projectId);
            if (!success)
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(Projects));
        }
        
        // //Test Purposes
        // private async Task AddGradesToIvan()
        // {
        //     var student = await _context.Students
        //         .FirstOrDefaultAsync(s => s.FirstName == "Ivan");
        //
        //     var maria = await _context.Teachers
        //         .FirstOrDefaultAsync(t => t.FirstName == "Maria");
        //
        //     var grade1 = new Grade
        //     {
        //         StudentId = student.Id,
        //         TeacherId = maria.Id,
        //         GradeValue = 6,
        //         Subject = Subject.Bulgarian,
        //     };
        //
        //     student.Grades.Add(grade1);
        //
        //     await _context.SaveChangesAsync();
        // }
        //
        // private async Task AddGradesToGencho()
        // {
        //     var student = await _context.Students
        //         .FirstOrDefaultAsync(s => s.FirstName == "Gencho");
        //     
        //     var stefka = await _context.Teachers
        //         .FirstOrDefaultAsync(t => t.FirstName == "Stefka");
        //
        //     var maria = await _context.Teachers
        //         .FirstOrDefaultAsync(t => t.FirstName == "Maria");
        //
        //     var grade1 = new Grade
        //     {
        //         StudentId = student.Id,
        //         TeacherId = maria.Id,
        //         GradeValue = 6,
        //         Subject = Subject.Bulgarian,
        //     };
        //
        //     var grade2 = new Grade
        //     {
        //         StudentId = student.Id,
        //         TeacherId = maria.Id,
        //         GradeValue = 5,
        //         Subject = Subject.Bulgarian
        //     };
        //
        //     student.Grades.Add(grade1);
        //     student.Grades.Add(grade2);
        //
        //     await _context.SaveChangesAsync();
        // }
        //
        // private async Task AddGradesToMartin()
        // {
        //     var student = await _context.Students
        //         .FirstOrDefaultAsync(s => s.FirstName == "Martin");
        //     
        //     var stefka = await _context.Teachers
        //         .FirstOrDefaultAsync(t => t.FirstName == "Stefka");
        //
        //     var maria = await _context.Teachers
        //         .FirstOrDefaultAsync(t => t.FirstName == "Maria");
        //
        //     var grade1 = new Grade
        //     {
        //         StudentId = student.Id,
        //         TeacherId = maria.Id,
        //         GradeValue = 6,
        //         Subject = Subject.Bulgarian,
        //     };
        //
        //     var grade2 = new Grade
        //     {
        //         StudentId = student.Id,
        //         TeacherId = maria.Id,
        //         GradeValue = 5,
        //         Subject = Subject.Bulgarian
        //     };
        //
        //     var grade3 = new Grade
        //     {
        //         StudentId = student.Id,
        //         TeacherId = stefka.Id,
        //         GradeValue = 6,
        //         Subject = Subject.German
        //     };
        //
        //     student.Grades.Add(grade1);
        //     student.Grades.Add(grade2);
        //     student.Grades.Add(grade3);
        //
        //     await _context.SaveChangesAsync();
        // }
    }
}