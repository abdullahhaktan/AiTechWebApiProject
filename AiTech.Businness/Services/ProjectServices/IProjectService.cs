using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.ProjectDtos;


namespace AiTech.Businness.Services.ProjectServices
{
    public interface IProjectService : IGenericService<ResultProjectDto, CreateProjectDto, UpdateProjectDto>
    {
        Task<List<ResultProjectDto>> GetProjectWithCategories();
    }
}
