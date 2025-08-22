using EmployeeDetailsApp_WithMultiple_table.Data;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDetailsApp_WithMultiple_table.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public  EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var empData = _context.Employees.ToList();
            return View(empData);
        }
    }
}
