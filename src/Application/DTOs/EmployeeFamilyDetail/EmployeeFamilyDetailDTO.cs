
namespace Application.DTOs.EmployeeFamilyDetail;
public class EmployeeFamilyDetail
{
    public long EmployeeFamilyDetailId { get; set; }
    public long EmpId { get; set; }
    public int? TotalNumber { get; set; }
    public string? FatherName { get; set; }
    public string? MotherName { get; set; }
    public string? ContactNumber { get; set; }
    public decimal? PercentageMarks { get; set; }
    public DateTime? CreatedDate { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int? ModifiedBy { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsDeleted { get; set; }
}