using System.ComponentModel.DataAnnotations;

namespace MasterPiece.Domain.Entities;

public abstract class BaseEntity
{
    public BaseEntity(int id,
        string createdBy,
        DateTime createdDate,
        string modifiedBy,
        DateTime? modifiedDate)
    {
        Id = id;
        CreatedBy = createdBy;
        CreatedDate = createdDate;
        ModifiedBy = modifiedBy;
        ModifiedDate = modifiedDate;
    }
    
    [Key]
    public int Id { get; set; }
    public string CreatedBy { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
}