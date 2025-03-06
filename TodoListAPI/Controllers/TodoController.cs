using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TodoListAPI.DTOs;
using TodoListAPI.Services;

namespace TodoListAPI.Controllers;

[Authorize]
[Route("api/todos")]
[ApiController]
public class TodoController : ControllerBase
{
    private readonly ITodoService todoService;

    public TodoController(ITodoService todoService)
    {
        this.todoService = todoService;
    }

    private string GetUserId()
    {
        return User.FindFirstValue(ClaimTypes.NameIdentifier) ?? throw new UnauthorizedAccessException();
    }

    [HttpPost]
    public async Task<IActionResult> CreateTodo([FromBody] TodoRequest request)
    {
        var userId = GetUserId();
        var todo = await todoService.CreateTodo(userId, request);
        return CreatedAtAction(nameof(GetTodoById), new { id = todo?.Id }, todo);
    }

    [HttpGet]
    public async Task<IActionResult> GetTodos()
    {
        var userId = GetUserId();
        var todos = await todoService.GetTodos(userId);
        return Ok(todos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTodoById(Guid id)
    {
        var userId = GetUserId();
        var todo = await todoService.GetTodoById(userId, id);
        if (todo == null) return NotFound();
        return Ok(todo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTodo(Guid id, [FromBody] TodoRequest request)
    {
        var userId = GetUserId();
        var success = await todoService.UpdateTodo(userId, id, request);
        if (!success) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodo(Guid id)
    {
        var userId = GetUserId();
        var success = await todoService.DeleteTodo(userId, id);
        if (!success) return NotFound();
        return NoContent();
    }
}
