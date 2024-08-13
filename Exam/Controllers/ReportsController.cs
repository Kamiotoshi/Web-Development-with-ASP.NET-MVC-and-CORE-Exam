using Microsoft.AspNetCore.Mvc;
using Exam.Data;
using Microsoft.EntityFrameworkCore;

namespace Exam.Controllers
{
    public class ReportsController : Controller
    {
        private readonly AppDbContext _context;

        public ReportsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> DepartmentStatistics()
        {
            var departmentStats = await _context.Departments
                .Select(d => new
                {
                    DepartmentName = d.Name,
                    EmployeeCount = d.Employees.Count()
                })
                .ToListAsync();

            return View(departmentStats);
        }
    }
}
