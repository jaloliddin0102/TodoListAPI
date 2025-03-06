using Microsoft.EntityFrameworkCore;
using TodoListAPI.Data;
using TodoListAPI.DTOs;
using TodoListAPI.Models;

namespace TodoListAPI.Services;

public class TodoService : ITodoService
{
    private readonly TodoDbContext context;

    public TodoService(TodoDbContext context)
    {
        this.context = context;
    }

    public async Task<Todo?> CreateTodo(string userId, TodoRequest request)
    {
        var todo = new Todo
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
            Description = request.Description,
            IsCompleted = false,
            UserId = Guid.Parse(userId)
        };

        context.Todos.Add(todo);
        await context.SaveChangesAsync();
        return todo;
    }

    public async Task<List<Todo>> GetTodos(string userId)
    {
        return await context.Todos.Where(t => t.UserId.ToString() == userId).ToListAsync();
    }

    public async Task<Todo?> GetTodoById(string userId, Guid id)
    {
        return await context.Todos.FirstOrDefaultAsync(t => t.Id == id && t.UserId.ToString() == userId);
    }

    public async Task<bool> UpdateTodo(string userId, Guid id, TodoRequest request)
    {
        var todo = await GetTodoById(userId, id);
        if (todo == null) return false;

        todo.Title = request.Title;
        todo.Description = request.Description;
        todo.IsCompleted = request.IsCompleted;

        await context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteTodo(string userId, Guid id)
    {
        var todo = await GetTodoById(userId, id);
        if (todo == null) return false;

        context.Todos.Remove(todo);
        await context.SaveChangesAsync();
        return true;
    }
}
