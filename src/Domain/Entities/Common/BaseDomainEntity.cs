namespace Domain.Entities.Common;
public class BaseDomainEntity
{
    public DateTimeOffset Created { get; set; }
    public string? CreatedBy { get; set; }
    public DateTimeOffset LastModified { get; set; }
    public string? LastModifyBy { get; set; }
}
