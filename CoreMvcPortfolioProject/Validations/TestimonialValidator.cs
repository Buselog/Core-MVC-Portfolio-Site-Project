using CoreMvcPortfolioProject.DAL.Entities;
using FluentValidation;

namespace CoreMvcPortfolioProject.Validations
{
    public class TestimonialValidator : AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x=>x.TestimonialName).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Title).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("This field cannot be empty");
            RuleFor(x => x.TestimonialImageUrl).NotEmpty().WithMessage("This field cannot be empty")
                                               .Must(link => Uri.IsWellFormedUriString(link, UriKind.Absolute))
                                               .WithMessage("Enter a valid URL");
                                               
                                          
        }
    }
}
