using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.DataAccess.Repositories.ChooseRepositories
{
    public class ChooseRepository : GenericRepository<Choose>, IChooseRepository
    {
        private readonly DbSet<Choose> _dbSet;
        public ChooseRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<Choose>();
        }
    }
}
