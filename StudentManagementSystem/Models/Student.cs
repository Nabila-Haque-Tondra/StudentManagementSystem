using System.ComponentModel.DataAnnotations;
namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string ClassName { get; set; }
        [Required]
        public string Section { get; set; }

    }
}
