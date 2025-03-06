using System.ComponentModel.DataAnnotations;

namespace TodoListAPI.DTOs;

public class LoginRequest
{
    public required string Username { get; set; } = string.Empty;  
    public required string Password { get; set; } = string.Empty;
}

