using System.ComponentModel.DataAnnotations;

namespace TaskWebApplication.Models
{
    public class Employee_Salary
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public string Salary { get; set; }
    }
}
