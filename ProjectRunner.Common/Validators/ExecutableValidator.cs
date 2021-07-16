using FluentValidation;
using ProjectRunner.Common.Entities;
using System.Globalization;
using System.Threading;

namespace ProjectRunner.Common.Validators
{
    public class ExecutableValidator : AbstractValidator<Executable>
    {
        public ExecutableValidator()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentCulture;

            RuleFor(c => c.Name)
                .NotEmpty().WithName(Resources.Strings.Name).WithMessage(Resources.Strings.NameRequired)
                .NotNull().WithName(Resources.Strings.Name).WithMessage(Resources.Strings.NameRequired);

            RuleFor(c => c.FileName)
                .NotEmpty().WithName(Resources.Strings.Filename).WithMessage(Resources.Strings.FilenameRequired)
                .NotNull().WithName(Resources.Strings.Filename).WithMessage(Resources.Strings.FilenameRequired);
        }
    }
}
