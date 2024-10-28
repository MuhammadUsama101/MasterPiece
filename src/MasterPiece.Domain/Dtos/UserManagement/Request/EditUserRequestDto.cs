namespace MasterPiece.Domain.Dtos.UserManagement.Request;

public record EditUserRequestDto(int Id,
    string FirstName,
    string LastName);       