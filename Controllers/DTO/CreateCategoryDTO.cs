using FluentValidation;
using MedicalStore.Utils.Validator;

namespace MedicalStore.Controllers.DTO
{
    public class CreateCategoryDTO
    {
        public string Name { set; get; }
        public string Description { set; get; }        
        public string CategoryId { set; get; }
    }
    public class CategoryDTOValidator : AbstractValidator<CreateCategoryDTO>
    {
        public CategoryDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().Length(CategoryValidator.NAME_MIN, CategoryValidator.NAME_MAX);
            RuleFor(x => x.Description).Length(CategoryValidator.DESCRIPTION_MIN, CategoryValidator.DESCRIPTION_MAX);
        }
    }
}
