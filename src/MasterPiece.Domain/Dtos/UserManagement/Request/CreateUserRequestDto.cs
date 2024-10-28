namespace MasterPiece.Domain.Dtos.UserManagement.Request;

public record CreateUserRequestDto(string FirstName,
    string LastName,
    string  Email);