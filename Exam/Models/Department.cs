

namespace Exam.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }
        public int NumberOfPersonals { get; set; }

        public ICollection<Employee>? Employees { get; set; }
    }
}
