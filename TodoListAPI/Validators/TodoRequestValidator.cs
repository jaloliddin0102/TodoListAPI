using FluentValidation;
using TodoListAPI.DTOs;

namespace TodoListAPI.Validators;

public class TodoRequestValidator : AbstractValidator<TodoRequest>
{
    public TodoRequestValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required")
            .MaximumLength(255).WithMessage("Title must be at most 255 characters");

        RuleFor(x => x.Description)
            .MaximumLength(1000).WithMessage("Description must be at most 1000 characters");
    }
}
