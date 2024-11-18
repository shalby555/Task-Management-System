using FluentValidation;

namespace TaskManagement.Models.Requests.Validators
{
    public class CreateTaskRequestValidator: AbstractValidator<CreateTaskRequest>
    {
        public CreateTaskRequestValidator()
        {
            RuleFor(model => model.Name).MaximumLength(20).MinimumLength(2);
            RuleFor(model => model.Description).MaximumLength(150).MinimumLength(20);
        }
    }
}
