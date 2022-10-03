

namespace Application.DTOs.EmployeeWorkExperience;
public class EmployeeWorkExperience
{
    public long EmployeeWorkExperienceId { get; set; }
    public long EmpId { get; set; }
    public string? LastCompany { get; set; }
    public int? TotalYears { get; set; }
    public string? LastDesignation { get; set; }
    public DateTime? CreatedDate { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int? ModifiedBy { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsDeleted { get; set; }
}