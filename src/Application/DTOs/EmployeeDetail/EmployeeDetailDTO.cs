
namespace Application.DTOs.EmployeeDetail;
public class EmployeeDetail
{
    public long EmployeeDetailId { get; set; }
    public long EmpId { get; set; }
    public string? FormId { get; set; }
    public string? Name { get; set; }
    public string? Department { get; set; }
    public string? DesignationName { get; set; }
    public DateTime? DOB { get; set; }
    public string? Gender { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Cnic { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public DateTime? CreatedDate { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int? ModifiedBy { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsDeleted { get; set; }
    public int? DesignationId { get; set; }
}