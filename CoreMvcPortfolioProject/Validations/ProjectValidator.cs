using CoreMvcPortfolioProject.DAL.Entities;
using FluentValidation;

namespace CoreMvcPortfolioProject.Validations
{
    public class ProjectValidator : AbstractValidator<Projects>
    {
        public ProjectValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Subtitle).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.ProjectDescription).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("This field cannot be empty")
                                      .Must(link => Uri.IsWellFormedUriString(link, UriKind.Absolute))
                                      .WithMessage("Enter a valid URL."); 
            RuleFor(x => x.ProjectImageUrl).NotEmpty().WithMessage("This field cannot be empty");
        }
    }
}
