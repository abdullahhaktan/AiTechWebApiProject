using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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