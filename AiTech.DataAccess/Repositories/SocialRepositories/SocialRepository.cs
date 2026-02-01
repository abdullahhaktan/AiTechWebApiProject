using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace AiTech.DataAccess.Repositories.SocialRepositories
{
    public class SocialRepository : GenericRepository<Social>, ISocialRepository
    {
        private readonly DbSet<Social> _dbSet;
        public SocialRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<Social>();
        }
    }
}