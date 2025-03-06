using TodoListAPI.DTOs;
using TodoListAPI.Models;

namespace TodoListAPI.Services;

public interface ITodoService
{
    Task<Todo?> CreateTodo(string userId, TodoRequest request);
    Task<List<Todo>> GetTodos(string userId);
    Task<Todo?> GetTodoById(string userId, Guid id);
    Task<bool> UpdateTodo(string userId, Guid id, TodoRequest request);
    Task<bool> DeleteTodo(string userId, Guid id);
}
