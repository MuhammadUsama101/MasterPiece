
using System.ComponentModel.DataAnnotations.Schema;
using MasterPiece.Domain.Entities;

[Table("users")]
public class UserEntity : BaseEntity
{
    public UserEntity(int id,
        string firstName,
        string lastName,
        string email,
        string createdBy,
        DateTime createdDate,
        string modifiedBy,
        DateTime? modifiedDate) 
        : base(id,
            createdBy,
            createdDate,
            modifiedBy,
            modifiedDate)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public string FirstName { get; set; } = null!;
        
    public string LastName { get; set; } = null!;
        
    public string Email { get; set; } = null!;
}