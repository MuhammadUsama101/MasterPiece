using MasterPiece.Domain.Dtos.UserManagement.Request;
using MasterPiece.Domain.Dtos.UserManagement.Response;

namespace MasterPiece.Application.Abstractions.Application;

public interface IUserManagementService
{
    Task<IEnumerable<GetUsersResponseDto>> GetUsersAsync();
    Task<GetUserResponseDto> GetUserAsync(int id);
    Task CreateUserAsync(CreateUserRequestDto requestDto);
    Task EditeUserAsync(EditUserRequestDto requestDto);
    Task DeleteUserAsync(int id);
}