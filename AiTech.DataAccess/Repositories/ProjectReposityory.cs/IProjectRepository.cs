using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.DataAccess.Repositories.ProjectReposityory.cs
{
    public interface IProjectRepository: IRepository<Project>
    {
        Task<List<Project>> GetProjectWithCategories();
    }
}
