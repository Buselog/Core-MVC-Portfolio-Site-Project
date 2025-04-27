using CoreMvcPortfolioProject.DAL.Entities;
using FluentValidation;

namespace CoreMvcPortfolioProject.Validations
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("This field cannot be empty")
                                           .EmailAddress()
                                           .WithMessage("Enter a valid email address");
            RuleFor(x => x.Address).NotEmpty().WithMessage("This field cannot be empty");
        }
    }
}
