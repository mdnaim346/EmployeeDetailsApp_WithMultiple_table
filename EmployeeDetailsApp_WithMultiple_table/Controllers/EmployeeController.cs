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

            // ViewModel emp = new ViewModel();
            //var empData = _context.Employees.ToList();
            //var depData = _context.Departments.ToList();
            //emp.Employees = empData;
            //emp.Departments = depData;

            //*******This for Join Model **********
            var emp = (from e in _context.Employees
                       join d in _context.Departments
                       on e.DepartmentId equals d.DepartmentId
                       select new JoinModel
                       {
                           EmployeeId = e.EmployeeId,
                           FirstName = e.FirstName,
                           LastName = e.LastName,
                           Gender = e.Gender,
                           Email = e.Email,
                           DepartmentName = d.DepartmentName,
                           DepartmentCode = d.DepartmentCode

                       }).ToList();

            return View(emp);
        }
    }
}
