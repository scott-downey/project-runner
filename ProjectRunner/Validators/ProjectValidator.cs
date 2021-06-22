using FluentValidation;
using ProjectRunner.Entities;

namespace ProjectRunner.Validators
{
    public class ProjectValidator : AbstractValidator<Project>
    {
        public ProjectValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Name is required.")
                .NotNull().WithMessage("Name is required.");

            RuleFor(c => c.Path)
                .NotEmpty().WithMessage("Path is required.")
                .NotNull().WithMessage("Path is required.");

            RuleFor(c => c.Executable)
                .NotEmpty().WithMessage("Executable is required.")
                .NotNull().WithMessage("Executable is required.");
        }
    }
}
