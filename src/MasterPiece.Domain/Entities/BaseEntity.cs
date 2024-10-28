using System.ComponentModel.DataAnnotations;

namespace MasterPiece.Domain.Entities;

public abstract class BaseEntity
{
    public BaseEntity(string createdBy,
        DateTime createdDate,
        string? modifiedBy,
        DateTime? modifiedDate)
    {
        CreatedBy = createdBy;
        CreatedDate = createdDate;
        ModifiedBy = modifiedBy;
        ModifiedDate = modifiedDate;
    }

    public string CreatedBy { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public bool Deleted { get; set; }
}