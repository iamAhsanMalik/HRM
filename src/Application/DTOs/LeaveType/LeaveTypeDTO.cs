

namespace Application.DTOs.LeaveType;
public class LeaveType
{
    public long LeaveTypeId { get; set; }
    public string? Name { get; set; }
    public DateTime? CreatedDate { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int? ModifiedBy { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsDeleted { get; set; }
}