using MasterPiece.Application.Abstractions.Application;
using MasterPiece.Domain.Dtos.UserManagement.Request;
using Microsoft.AspNetCore.Mvc;

namespace MasterPiece.API.Controllers;

//controller call service --> service call repository --> repository call database
// api routing rule collection/resource/collection/resource
// example of routing rule users/1/repos/5
[Route("api/usermanagement")]
public class UserManagementController(IUserManagementService _userManagementService) : BaseApiController
{
    private readonly IUserManagementService _userManagementService = _userManagementService;

    [HttpGet("users")]
    public async Task<IActionResult> GetUsers()
    {
        return Ok(await _userManagementService.GetUsersAsync());
    }

    [HttpGet("users/{id}")]
    public async Task<IActionResult> GetUser(int id)
    {
        return Ok(await _userManagementService.GetUserAsync(id));
    }

    [HttpPost("users")]
    public async Task<IActionResult> CreateUser(CreateUserRequestDto requestDto)
    {
        await _userManagementService.CreateUserAsync(requestDto);
        return NoContent();
    }
    
    [HttpPut("users")]
    public async Task<IActionResult> EditeUser(EditUserRequestDto requestDto)
    {
        await _userManagementService.EditeUserAsync(requestDto);
        return NoContent();
    }

    [HttpDelete("users/{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        await _userManagementService.DeleteUserAsync(id);
        return NoContent();
    }
    
}