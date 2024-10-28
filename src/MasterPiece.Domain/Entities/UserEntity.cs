
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MasterPiece.Domain.Entities;

[Table("users")]
public class UserEntity : BaseEntity
{
    public UserEntity(
        string firstName,
        string lastName,
        string email,
        string createdBy,
        DateTime createdDate,
        string? modifiedBy,
        DateTime? modifiedDate) 
        : base(
            createdBy,
            createdDate,
            modifiedBy,
            modifiedDate)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }


    [Key]
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;
        
    public string LastName { get; set; } = null!;
        
    public string Email { get; set; } = null!;
}