using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;

namespace AiTech.DataAccess.Repositories.ProjectReposityory.cs
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<List<Project>> GetProjectWithCategories();
    }
}
