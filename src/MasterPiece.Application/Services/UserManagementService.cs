using MasterPiece.Application.Abstractions.Application;
using MasterPiece.Application.Abstractions.Persistance;
using MasterPiece.Domain.Dtos.UserManagement.Request;
using MasterPiece.Domain.Dtos.UserManagement.Response;

namespace MasterPiece.Application.Services;

public class UserManagementService : IUserManagementService
{
    private readonly IUserManagementRepository _userManagementRepository;

    public UserManagementService(IUserManagementRepository userManagementRepository)
    {
        _userManagementRepository = userManagementRepository;
    }

    public async Task CreateUserAsync(CreateUserRequestDto requestDto)
    {
        //Validations
        var entity = new UserEntity(requestDto.FirstName,
            requestDto.LastName,
            requestDto.Email,
            requestDto.Email,
            DateTime.UtcNow,
            null,
            null);

        await _userManagementRepository.CreateUserAsync(entity);
    }

    public async Task DeleteUserAsync(int id)
    {
        await _userManagementRepository.DeleteUserAsync(id);
    }

    public async Task EditeUserAsync(EditUserRequestDto requestDto)
    {
        var entity = await _userManagementRepository.GetUserEntityAsync(requestDto.Id);

        if(entity == null)
        {
            throw new ArgumentException("User not found.");
        }

        entity.FirstName = requestDto.FirstName;
        entity.LastName = requestDto.LastName;

        await _userManagementRepository.EditeUserAsync(entity);
    }

    public async Task<GetUserResponseDto?> GetUserAsync(int id)
    {
        var user = await _userManagementRepository.GetUserAsync(id);

        if(user == null)
        {
            throw new ArgumentException("User not found");
        }

        return user;
    }

    public async Task<IEnumerable<GetUsersResponseDto>> GetUsersAsync()
    {
        return await _userManagementRepository.GetUsersAsync();
    }
}
