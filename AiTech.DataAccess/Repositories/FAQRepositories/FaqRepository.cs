using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.DataAccess.Repositories.FAQRepositories
{
    public class FaqRepository : GenericRepository<FAQ>, IFaqRepository
    {
        private DbSet<FAQ> _dbSet;
        public FaqRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<FAQ>();
        }
    }
}
