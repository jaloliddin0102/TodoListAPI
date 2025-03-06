using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListAPI.Models;

public class Todo
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [StringLength(255)]
    public required string Title { get; set; } = string.Empty;

    [StringLength(1000)]
    public string? Description { get; set; }

    public bool IsCompleted { get; set; } = false;
    public required Guid UserId { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; } = null!;
}

