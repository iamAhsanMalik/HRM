

namespace Application.DTOs.EmployeeEducation;
public class EmployeeEducation
{
    public long EmployeeEducationId { get; set; }
    public long EmpId { get; set; }
    public int? LastEducation { get; set; }
    public string? NameLastEducation { get; set; }
    public long ObtainMarks { get; set; }
    public decimal? CGP { get; set; }
    public string? Grade { get; set; }
    public decimal? PercentageMarks { get; set; }
    public DateTime? CreatedDate { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int? ModifiedBy { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsDeleted { get; set; }
}