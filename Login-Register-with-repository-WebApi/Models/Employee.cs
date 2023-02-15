using System.ComponentModel.DataAnnotations;

namespace Company_Project.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Pancard_Number { get; set; }
        public string Account_Number { get; set; }
        public string PF_Number { get; set; }

    }
}
