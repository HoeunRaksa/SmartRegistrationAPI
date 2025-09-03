namespace SmartRegistrationAPI.DTOs;

public class DepartmentReadDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Code { get; set; }
    public string? Faculty { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}
