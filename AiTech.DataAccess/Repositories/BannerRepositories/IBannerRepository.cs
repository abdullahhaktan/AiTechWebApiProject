using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;

namespace AiTech.DataAccess.Repositories.BannerRepositories
{
    public interface IBannerRepository : IRepository<Banner>
    {
        Task MakeActiveAsync(Banner banner);
        Task MakePasiveAsync(Banner banner);
    }
}
