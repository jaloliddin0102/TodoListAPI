using System.ComponentModel.DataAnnotations;


namespace TodoListAPI.Models;

public class User
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(50)]
    public string Username { get; set; } = string.Empty;

    [Required]
    public string PasswordHash { get; set; } = string.Empty;

    public List<Todo> Todos { get; set; } = new List<Todo>();
}

