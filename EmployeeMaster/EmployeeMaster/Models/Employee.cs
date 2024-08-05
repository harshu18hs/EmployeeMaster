using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeMaster.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public int Country_Id { get; set; }

        [Required]
        public bool Maritial_Status { get; set; }

        [StringLength(100)]
        public string Hobbies { get; set; }
    }
}
