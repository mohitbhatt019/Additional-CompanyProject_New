using System.ComponentModel.DataAnnotations;

namespace Company_Project.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string GST { get; set; }
        public string Designation { get; set; }

    }
}
