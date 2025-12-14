using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.DataAccess.Repositories.BannerRepositories
{
    public interface IBannerRepository:IRepository<Banner>
    {
        Task MakeActiveAsync(Banner banner);
        Task MakePasiveAsync(Banner banner);
    }
}
