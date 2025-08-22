using System.ComponentModel.DataAnnotations;

namespace EmployeeDetailsApp_WithMultiple_table.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }

    }
}
