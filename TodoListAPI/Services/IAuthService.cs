using TodoListAPI.DTOs;
using TodoListAPI.Models;

namespace TodoListAPI.Services;

public interface IAuthService
{
    Task<User?> Register(RegisterRequest request);
    Task<string?> Login(LoginRequest request);
}
