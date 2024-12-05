using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Common.Enums;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Services.Contracts;
using static SchoolManagementSystem.Common.ErrorMessages.AuthenticationErrorMessages;

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
            
            if (user.IsAuthenticated is false)
            {
                ModelState.AddModelError("user", NotAuthenticated);
                return RedirectToAction("Index", "Home");
            }

            var student = await _studentService.GetStudentByUserIdAsync(user.AppId);
            if (student is null)
            {
                ModelState.AddModelError("user", InvalidUser);
                return RedirectToAction("Index", "Home");
            }

            await AddGradesToIvan();
            await AddGradesToGencho();
            
            var models = _studentService.GetGradesViewModel(student);
            return View(models);
        }
        
        //Test Purposes
        private async Task AddGradesToIvan()
        {
            var student = await _context.Students
                .FirstOrDefaultAsync(s => s.FirstName == "Ivan");
            
            var teacher = await _context.Teachers
                .FirstOrDefaultAsync(t => t.FirstName == "Maria");

            var grade1 = new Grade
            {
                StudentId = student.Id,
                TeacherId = teacher.Id,
                GradeValue = 6,
                Subject = Subject.Bulgarian,
            };

            var grade2 = new Grade
            {
                StudentId = student.Id,
                TeacherId = teacher.Id,
                GradeValue = 5,
                Subject = Subject.Biology
            };

            var grade3 = new Grade
            {
                StudentId = student.Id,
                TeacherId = teacher.Id,
                GradeValue = 6,
                Subject = Subject.Maths
            };
        
            student.Grades.Add(grade1);
            student.Grades.Add(grade2);
            student.Grades.Add(grade3);
        
            await _context.SaveChangesAsync();
        }
        
        private async Task AddGradesToGencho()
        {
            var student = await _context.Students
                .FirstOrDefaultAsync(s => s.FirstName == "Gencho");
            
            var teacher = await _context.Teachers
                .FirstOrDefaultAsync(t => t.FirstName == "Maria");

            var grade1 = new Grade
            {
                StudentId = student.Id,
                TeacherId = teacher.Id,
                GradeValue = 6,
                Subject = Subject.Bulgarian,
            };

            var grade2 = new Grade
            {
                StudentId = student.Id,
                TeacherId = teacher.Id,
                GradeValue = 5,
                Subject = Subject.Bulgarian
            };

            var grade3 = new Grade
            {
                StudentId = student.Id,
                TeacherId = teacher.Id,
                GradeValue = 6,
                Subject = Subject.Maths
            };
        
            student.Grades.Add(grade1);
            student.Grades.Add(grade2);
            student.Grades.Add(grade3);
        
            await _context.SaveChangesAsync();
        }
    }
}