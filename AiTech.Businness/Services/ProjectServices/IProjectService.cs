using AiTech.Businness.Services.GenericServices;
using AiTech.DTO.ProjectDtos;
using AiTech.Entity.Entities;
using System;
using System.Collections.Generic;


namespace AiTech.Businness.Services.ProjectServices
{
    public interface IProjectService:IGenericService<ResultProjectDto,CreateProjectDto,UpdateProjectDto>
    {
        Task<List<ResultProjectDto>> GetProjectWithCategories();
    }
}
