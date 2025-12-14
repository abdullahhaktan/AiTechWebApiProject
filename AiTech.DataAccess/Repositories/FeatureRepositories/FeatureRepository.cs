using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.DataAccess.Repositories.FeatureRepositories
{
    public class FeatureRepository : GenericRepository<Feature> , IFeatureRepository
    {
        private readonly DbSet<Feature> _dbSet;
        public FeatureRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<Feature>();
        }
    }
}
