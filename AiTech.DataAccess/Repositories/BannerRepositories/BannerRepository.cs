using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.DataAccess.Repositories.BannerRepositories
{
    public class BannerRepository : GenericRepository<Banner>, IBannerRepository
    {
        public BannerRepository(AppDbContext context) : base(context)
        {
        }

        public async Task MakeActiveAsync(Banner banner)
        {
            banner.IsActive = true;
        }

        public async Task MakePasiveAsync(Banner banner)
        {
            banner.IsActive = false;
        }
    }
}
