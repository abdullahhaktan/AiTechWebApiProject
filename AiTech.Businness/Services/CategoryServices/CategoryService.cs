using AiTech.DataAccess.Repositories.CategoryRepository;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.CategoryDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Businness.Services.CategoryServices
{
    public class CategoryService(ICategoryRepository _categoryRepository, IUnitOfWork _unitOfWork) : ICategoryService

    {
        public async Task TCreateAsync(CreateCategoryDto createdDto)
        {
            var category = createdDto.Adapt<Category>();
            await _categoryRepository.CreateAsync(category);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category is null)
            {
                throw new Exception("Silinecek kategori bulunamadı");
            }   

            _categoryRepository.Delete(category);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultCategoryDto>> TGetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return categories.Adapt<List<ResultCategoryDto>>();
        }

        public async Task<ResultCategoryDto> TGetByIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category is null)
            {
                throw new Exception("Kategori bulunamadı");
            }

            return category.Adapt<ResultCategoryDto>();
        }

        public Task TUpdateAsync(UpdateCategoryDto updateDto)
        {
            var category = updateDto.Adapt<Category>();
            _categoryRepository.Update(category);
            return _unitOfWork.SaveChangesAsync();
        }
    }
}
