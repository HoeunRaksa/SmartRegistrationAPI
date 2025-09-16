using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRegistrationAPI.Models;
public class Registration
{
    [Key]
    public int Id { get; set; }   // Auto primary key (DB identity)

    [Required]
    [MaxLength(20)]
    public string StudentID { get; set; } = string.Empty;
    // Auto-generated (RUPP2025-00123)

    // ===== Personal Information =====
    [Required, MaxLength(100)]
    public string FullNameKh { get; set; } = string.Empty;  // Khmer name

    [Required, MaxLength(100)]
    public string FullNameEn { get; set; } = string.Empty;  // English name

    [Required, MaxLength(20)]
    public string Gender { get; set; } = "Other";

    [Required]
    public DateTime DateOfBirth { get; set; }

    [MaxLength(20)]
    public string? NationalID { get; set; } = string.Empty;  // National ID / Passport

    [MaxLength(200)]
    public string Address { get; set; } = string.Empty;     // Permanent address

    [MaxLength(200)]
    public string CurrentAddress { get; set; } = string.Empty; // Current address

    [MaxLength(20)]
    public string? PhoneNumber { get; set; }

    [Required, MaxLength(150), EmailAddress]
    public string PersonalEmail { get; set; } = string.Empty;  // Student’s own email

    // ===== Academic Background =====
    [Required, MaxLength(100)]
    public string HighSchoolName { get; set; } = string.Empty;

    [Required, MaxLength(4)]
    public string GraduationYear { get; set; } = string.Empty;

    [MaxLength(50)]
    public string Grade12ExamCenter { get; set; } = string.Empty;  // Optional

    [MaxLength(10)]
    public string Grade12Result { get; set; } = string.Empty;      // A, B, C, D, E, F

    // ===== University Admission =====
    [Required, MaxLength(50)]
    public string Faculty { get; set; } = string.Empty;

    [Required, MaxLength(50)]
    public string Major { get; set; } = string.Empty;

    [Required, MaxLength(10)]
    public string Shift { get; set; } = "Morning";  // Morning, Afternoon, Evening

    [MaxLength(20)]
    public string Batch { get; set; } = string.Empty; // Generation (e.g., Batch 29)

    [MaxLength(10)]
    public string AcademicYear { get; set; } = string.Empty; // e.g. 2025-2026

    [Required]
    [MaxLength(255)]
    public string? ProfilePicturePath { get; set; } // e.g. "/uploads/students/123.jpg"

    // ===== Parent / Guardian Info =====
    [MaxLength(100)]
    public string? FatherName { get; set; }
    public string? FathersJob { get; set; }
    [MaxLength(100)]
    public string? MotherName { get; set; }
    public string? MothersJob { get; set; }
    [MaxLength(100)]
    public string? GuardianName { get; set; }
    [MaxLength(20)]
    public string? GuardianPhone { get; set; }
}