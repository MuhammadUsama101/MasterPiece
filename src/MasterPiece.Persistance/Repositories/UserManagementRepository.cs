using MasterPiece.Application.Abstractions.Persistance;
using MasterPiece.Domain.Dtos.UserManagement.Response;
using MasterPiece.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MasterPiece.Persistance.Repositories;

public class UserManagementRepository : IUserManagementRepository
{

    private readonly MasterPieceDbContext _context;

    public UserManagementRepository(MasterPieceDbContext context)
    {
        _context = context;
    }

    public async Task CreateUserAsync(UserEntity entity)
    {
        await _context.Users.AddAsync(entity);

        await _context.SaveChangesAsync();
    }

    public async Task DeleteUserAsync(int id)
    {
        var entity = await GetUserEntityAsync(id);

        if (entity == null)
        {
            throw new ArgumentException($"Incorrect user id is passed {id}");
        }

        entity.Deleted = true;
        entity.ModifiedBy = entity.Email;
        entity.ModifiedDate = DateTime.UtcNow;

        await _context.SaveChangesAsync();
    }

    public async Task EditeUserAsync(UserEntity entity)
    {
        _context.Users.Update(entity);

        await _context.SaveChangesAsync();
    }

    public async Task<GetUserResponseDto?> GetUserAsync(int id)
    {
        return await _context.Users
            .Where(x => x.Id == id)
            .Select(x => new GetUserResponseDto(x.Id,
            x.FirstName,
            x.LastName,
            x.Email))
            .AsNoTracking()
            .FirstOrDefaultAsync();
    }

    public async Task<UserEntity?> GetUserEntityAsync(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    public async Task<IEnumerable<GetUsersResponseDto>> GetUsersAsync()
    {
        return await _context.Users
            .Select(x => new GetUsersResponseDto(x.Id,
            x.FirstName,
            x.LastName,
            x.Email))
            .AsNoTracking()
            .ToListAsync();
    }
}
