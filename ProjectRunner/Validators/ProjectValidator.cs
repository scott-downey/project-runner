using FluentValidation;
using ProjectRunner.Entities;
using System.Globalization;
using System.Threading;

namespace ProjectRunner.Validators
{
    public class ProjectValidator : AbstractValidator<Project>
    {
        public ProjectValidator()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentCulture;

            RuleFor(c => c.Name)
                .NotEmpty().WithName(Resources.Strings.Name).WithMessage(Resources.Strings.NameRequired)
                .NotNull().WithName(Resources.Strings.Name).WithMessage(Resources.Strings.NameRequired);

            RuleFor(c => c.Path)
                .NotEmpty().WithName(Resources.Strings.Path).WithMessage(Resources.Strings.PathRequired)
                .NotNull().WithName(Resources.Strings.Path).WithMessage(Resources.Strings.PathRequired);

            RuleFor(c => c.Executable)
                .NotEmpty().WithName(Resources.Strings.Executable).WithMessage(Resources.Strings.ExecutableRequired)
                .NotNull().WithName(Resources.Strings.Executable).WithMessage(Resources.Strings.ExecutableRequired);
        }
    }
}
