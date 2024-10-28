namespace MasterPiece.Domain.Dtos.UserManagement.Response;

public record GetUserResponseDto(int Id,
    string FirstName,
    string LastName,
    string Email);