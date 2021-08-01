using FluentValidation;
using ProjectRunner.Common.Entities;
using System.Globalization;
using System.Threading;

namespace ProjectRunner.Common.Validators
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
                .NotEmpty().WithName(Resources.Strings.Filename).WithMessage(Resources.Strings.FilenameRequired)
                .NotNull().WithName(Resources.Strings.Filename).WithMessage(Resources.Strings.FilenameRequired);

            RuleFor(c => c.ExecutableId)
                .GreaterThan(0).WithName(Resources.Strings.Executable).WithMessage(Resources.Strings.ExecutableInvalid);
        }
    }
}
