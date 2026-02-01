using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace AiTech.DataAccess.Repositories.FeatureRepositories
{
    public class FeatureRepository : GenericRepository<Feature>, IFeatureRepository
    {
        private readonly DbSet<Feature> _dbSet;
        public FeatureRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<Feature>();
        }
    }
}
