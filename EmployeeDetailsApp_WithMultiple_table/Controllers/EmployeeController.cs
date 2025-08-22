using EmployeeDetailsApp_WithMultiple_table.Data;
using EmployeeDetailsApp_WithMultiple_table.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

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
              //*******This for Model Merging**********

            ViewModel emp = new ViewModel();
            //var empData = _context.Employees.ToList();
            //var depData = _context.Departments.ToList();
            //emp.Employees = empData;
            //emp.Departments = depData;
            return View(emp);
        }
    }
}
