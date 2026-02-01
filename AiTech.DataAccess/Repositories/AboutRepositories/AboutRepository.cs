using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace AiTech.DataAccess.Repositories.AboutRepositories
{
    internal class AboutRepository : GenericRepository<About>, IAboutRepository
    {
        private readonly DbSet<About> _dbSet;
        public AboutRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<About>();
        }
    }
}
