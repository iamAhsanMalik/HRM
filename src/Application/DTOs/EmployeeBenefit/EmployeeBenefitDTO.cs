

namespace Application.DTOs.EmployeeBenefit;
public class EmployeeBenefit
{
    public long EmployeeBenefitId { get; set; }
    public long EmpId { get; set; }
    public long BenefitId { get; set; }
    public bool? Available { get; set; }
    public DateTime? CreatedDate { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int? ModifiedBy { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsDeleted { get; set; }
}