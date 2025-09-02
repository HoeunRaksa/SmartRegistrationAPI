using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourProjectNamespace.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  // Primary Key

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;  // Department name

        [MaxLength(20)]
        public string? Code { get; set; }  // Department code, e.g., CS, MATH

        [MaxLength(100)]
        public string? Faculty { get; set; }  // Faculty or school name

        [MaxLength(255)]
        public string? Title { get; set; }  // Display title for website

        [MaxLength(1000)]
        public string? Description { get; set; }  // About the department

        [MaxLength(255)]
        public string? ContactEmail { get; set; }  // Department email

        [MaxLength(20)]
        public string? PhoneNumber { get; set; }  // Department contact number

        [MaxLength(255)]
        public string? ImagePath { get; set; }  // Optional: banner or logo image
    }
}
