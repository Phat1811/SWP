using FluentValidation;
using MedicalStore.Utils.Validator;

namespace MedicalStore.Controllers.DTO
{
    public class DeleteCategoryDTO
    {      
        public string CategoryId { set; get; }
    }
    public class DeleteCategoryDTOValidator : AbstractValidator<UpdateCategoryDTO>
    {
        public DeleteCategoryDTOValidator()
        {
            RuleFor(x => x.CategoryId).NotEmpty().Length(CategoryValidator.ID_MIN, CategoryValidator.ID_MAX);
        }
    }
}
