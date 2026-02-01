using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace AiTech.DataAccess.Repositories.TeamRepositories
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        private readonly DbSet<Team> _dbSet;
        public TeamRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<Team>();
        }
    }
}
