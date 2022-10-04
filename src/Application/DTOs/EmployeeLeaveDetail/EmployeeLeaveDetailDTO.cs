

namespace Application.DTOs.EmployeeLeaveDetail;
public class EmployeeLeaveDetail
{
    public long EmployeeLeaveDetailsId { get; set; }
    public long EmpId { get; set; }
    public long LeaveTypeId { get; set; }
    public DateTime? LeaveFrom { get; set; }
    public DateTime? LeaveTo { get; set; }
    public int? TotalLeaves { get; set; }
    public int? RemainingLeaves { get; set; }
    public bool? StatusPaid { get; set; }
    public int? AutherizedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int? ModifiedBy { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsDeleted { get; set; }
}