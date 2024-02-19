using System.ComponentModel.DataAnnotations;

namespace TaskWebApplication.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }
        [Required]
        public string Name { get; set;}
        [Required]
        public int? Mobile { get; set;}
        [Required]
        public string Email { get; set;}
        [Required]
        public string Address { get; set;}
        [Required]
        public int? Salary { get; set; }
        [Required]
        public DateTime DOJ { get; set; }

        

    }
}
