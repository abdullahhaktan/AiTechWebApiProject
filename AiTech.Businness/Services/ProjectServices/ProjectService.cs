using AiTech.DataAccess.Repositories.ProjectReposityory.cs;
using AiTech.DataAccess.UnitOfWorks;
using AiTech.DTO.ProjectDtos;
using AiTech.Entity.Entities;
using Mapster;

namespace AiTech.Businness.Services.ProjectServices
{
    public class ProjectService(
        IProjectRepository _projectRepository,
        IUnitOfWork _unitOfWork) : IProjectService
    {
        public async Task<List<ResultProjectDto>> GetProjectWithCategories()
        {
            var projects = await _projectRepository.GetProjectWithCategories();
            return projects.Adapt<List<ResultProjectDto>>();
        }

        public async Task TCreateAsync(CreateProjectDto createdDto)
        {
            var project = createdDto.Adapt<Project>();
            await _projectRepository.CreateAsync(project);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task TDeleteAsync(int id)
        {
            var project = await _projectRepository.GetByIdAsync(id);
            if(project == null)
            {
                throw new Exception("Proje Bulunamadı");
            }
            _projectRepository.Delete(project);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<List<ResultProjectDto>> TGetAllAsync()
        {
            var projects = await _projectRepository.GetAllAsync();
            return projects.Adapt<List<ResultProjectDto>>();
        }

        public async Task<ResultProjectDto> TGetByIdAsync(int id)
        {
            var project = await _projectRepository.GetByIdAsync(id);
            return project.Adapt<ResultProjectDto>();
        }

        public async Task TUpdateAsync(UpdateProjectDto updateDto)
        {
            var project = updateDto.Adapt<Project>();
            _projectRepository.Update(project);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
