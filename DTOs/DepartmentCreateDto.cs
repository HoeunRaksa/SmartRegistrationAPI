using System.ComponentModel.DataAnnotations; 
namespace SmartRegistration.DTOs;
public class DepartmentCreateDto {
	[Required]
	[MaxLength(100)]
	public string Name { get; set; } = string.Empty;

	[MaxLength(20)]
	public string? Code { get; set; }
	[MaxLength(100)]
	public string? Faculty { get; set; }

	[MaxLength(255)]
	public string? Title { get; set; }

	[MaxLength(1000)]
	public string? Description { get; set; } 

	[MaxLength(255)]
	public string? ContactEmail { get; set; } 

	[MaxLength(20)]
	public string? PhoneNumber { get; set; } 

	[MaxLength(255)]
	public string? ImagePath { get; set; } 
}
