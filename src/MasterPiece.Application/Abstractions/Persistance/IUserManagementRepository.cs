using MasterPiece.Domain.Dtos.UserManagement.Request;
using MasterPiece.Domain.Dtos.UserManagement.Response;

namespace MasterPiece.Application.Abstractions.Persistance;

public interface IUserManagementRepository
{
    Task<IEnumerable<GetUsersResponseDto>> GetUsersAsync();
    Task<GetUserResponseDto?> GetUserAsync(int id);
    Task CreateUserAsync(UserEntity entity);
    Task EditeUserAsync(UserEntity requestDto);
    Task DeleteUserAsync(int id);
    Task<UserEntity?> GetUserEntityAsync(int id);
}
