using CoreMvcPortfolioProject.DAL.Entities;
using FluentValidation;

namespace CoreMvcPortfolioProject.Validations
{
    public class ExperienceValidator : AbstractValidator<Experience>
    {
        public ExperienceValidator()
        {
            RuleFor(x=>x.Head).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Title).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Date).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("This field cannot be empty");
        }
    }
}
