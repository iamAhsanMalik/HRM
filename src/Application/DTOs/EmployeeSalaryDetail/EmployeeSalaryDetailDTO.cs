
namespace Application.DTOs.EmployeeSalaryDetail;
public class EmployeeSalaryDetail
{
    public long EmployeeSalaryDetailId { get; set; }
    public long EmpId { get; set; }
    public long BasicSalary { get; set; }
    public long Allowances { get; set; }
    public long TaxDetection { get; set; }
    public long GrossSalary { get; set; }
    public long MonthlySalary { get; set; }
    public long Incriment { get; set; }
    public DateTime? CreatedDate { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int? ModifiedBy { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsDeleted { get; set; }
}
