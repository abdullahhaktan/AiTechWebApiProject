using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace AiTech.DataAccess.Repositories.AboutItemRepositories
{
    public class AboutItemRepository : GenericRepository<AboutItem>, IAboutItemRepository
    {
        private readonly DbSet<AboutItem> _dbSet;
        public AboutItemRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<AboutItem>();
        }
    }
}
