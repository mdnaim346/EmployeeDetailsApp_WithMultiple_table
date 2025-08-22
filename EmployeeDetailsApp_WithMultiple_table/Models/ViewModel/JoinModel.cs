namespace EmployeeDetailsApp_WithMultiple_table.Models.ViewModel
{
    public class JoinModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
    }
}
