using System.ComponentModel.DataAnnotations;

namespace TodoListAPI.DTOs;

public class RegisterRequest
{
    [StringLength(50)]
    public required string Username { get; set; } = string.Empty;

    [MinLength(6)]
    public required string Password { get; set; } = string.Empty;
}

