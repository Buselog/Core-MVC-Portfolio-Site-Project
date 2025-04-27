using CoreMvcPortfolioProject.DAL.Entities;
using FluentValidation;
using Newtonsoft.Json.Linq;

namespace CoreMvcPortfolioProject.Validations
{
    public class SkillValidator : AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(x=>x.SkillName).NotEmpty().WithMessage("Skill name field cannot be empty");
            RuleFor(x => x.SkillValue).NotEmpty().WithMessage("Skill value field cannot be empty").
                                       GreaterThan(0).WithMessage("Skill value must be greater than 0.");
        }
    }
}
