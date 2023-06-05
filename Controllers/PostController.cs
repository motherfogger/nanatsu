using Microsoft.AspNetCore.Mvc;
namespace nanatsu.Controllers;
using nanatsu.Services;
using nanatsu.Models;


[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{
    private readonly IPostService _postService;
    private readonly ILogger<PostController> _logger;

    public PostController(ILogger<PostController> logger, IPostService postService)
    {
        _logger = logger;
        _postService = postService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _postService.GetPosts();

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _postService.GetPost(id);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Post post)
    {
        var result = await _postService.AddPost(post);

        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Put(Post post)
    {
        var result = await _postService.UpdatePost(post);

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _postService.DeletePost(id);

        return Ok(result);
    }
}
