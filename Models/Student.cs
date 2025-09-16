namespace SmartRegistrationAPI.Models;
public class Student : User
    {
        // Personal Info
        public string FullName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Nationality { get; set; }

        // Contact Info
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }

        // University Info
        public string StudentId { get; set; } = string.Empty;
        public int Generation { get; set; }
        public string? Department { get; set; }

        // Parental Info
        public string? ParentName { get; set; }
        public string? ParentPhone { get; set; }
    }
