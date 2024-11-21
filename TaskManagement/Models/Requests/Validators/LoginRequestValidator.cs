﻿using FluentValidation;
namespace TaskManagement.Models.Requests.Validators;

public class LoginRequestValidator : AbstractValidator<LoginRequest>
{
    public LoginRequestValidator()
    {
        RuleFor(model => model.Email).EmailAddress();
        RuleFor(model => model.Password).NotEmpty().MinimumLength(6).MaximumLength(20);
    } 
}
