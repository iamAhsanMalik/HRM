

namespace Application.DTOs.Department;
public class Department
{
    public long DepartmentId { get; set; }
    public string? DepartmentName { get; set; }
    public long TotalPersons { get; set; }
    public DateTime? CreatedDate { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int? ModifiedBy { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsDeleted { get; set; }
}