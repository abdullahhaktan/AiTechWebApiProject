using AiTech.WebUi.DTOs.ProjectDtos;
using FluentValidation;

namespace AiTech.WebUi.Validators
{
    public class ProjectValidator:AbstractValidator<CreateProjectDto>
    {
        public ProjectValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz").MinimumLength(3).WithMessage("Başlık minimum 3 karakter içermelidir");
            RuleFor(x=>x.ImageUrl).NotEmpty().WithMessage("Resim url boş bırakılamaz");
            RuleFor(x=>x.CategoryId).NotEmpty().WithMessage("Kategori boş bırakılamaz");
        }
    }
}
