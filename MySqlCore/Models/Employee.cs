using System.ComponentModel.DataAnnotations;

namespace MySqlCore.Models
{
    [Index(nameof(Email), IsUnique =true)]
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name field is required.")]
        [StringLength(maximumLength:100, MinimumLength =2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email field is required.")]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        [EmailAddress]
        public string  Email { get; set; }

        [Required(ErrorMessage = "Phone field is required.")]
        [StringLength(maximumLength: 15, MinimumLength = 10)]
        public String Phone { get; set; }

        [Required(ErrorMessage = "Address field is required.")]
        [StringLength(maximumLength: 250)]
        public string? Address { get; set; }
    }
}
