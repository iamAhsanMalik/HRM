

namespace Application.DTOs.EmployeeAttendance;
public class EmployeeAttendance
{
    public long AttendanceId { get; set; }
    public long EmpId { get; set; }
    public DateTime? CheckInTime { get; set; }
    public DateTime? CheckOutTime { get; set; }
    public int? AttendenceStatusId { get; set; }
    public string? QualityHours { get; set; }
    public string? BreakDuration { get; set; }
    public string? OverTime { get; set; }
    public DateTime? AttendenceDate { get; set; }
    public DateTime? CreatedDate { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int? ModifiedBy { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsDeleted { get; set; }
}