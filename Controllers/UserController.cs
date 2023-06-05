using Microsoft.AspNetCore.Mvc;
namespace nanatsu.Controllers;
using nanatsu.Services;
using nanatsu.Models;


[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger, IUserService postService)
    {
        _logger = logger;
        _userService = postService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _userService.GetUsers();

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _userService.GetUser(id);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Post(User post)
    {
        var result = await _userService.AddUser(post);

        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Put(User post)
    {
        var result = await _userService.UpdateUser(post);

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _userService.DeleteUser(id);

        return Ok(result);
    }
}

