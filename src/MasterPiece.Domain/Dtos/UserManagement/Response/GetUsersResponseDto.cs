namespace MasterPiece.Domain.Dtos.UserManagement.Response;

public record GetUsersResponseDto(int Id,
    string FirstName,
    string LastName,
    string Email);
    