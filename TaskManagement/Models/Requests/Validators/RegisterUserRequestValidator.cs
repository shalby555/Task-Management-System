using FluentValidation;

namespace TaskManagement.Models.Requests.Validators;

public class RegisterUserRequestValidator : AbstractValidator<RegisterUserRequest>
{
    public RegisterUserRequestValidator()
    {
        RuleFor(model => model.FirstName).MaximumLength(20).MinimumLength(2);
        RuleFor(model => model.LastName).MaximumLength(20).MinimumLength(2);
        RuleFor(model => model.Email).EmailAddress();
        RuleFor(model => model.Password).NotEmpty().MinimumLength(6).MaximumLength(20);
    }
}
