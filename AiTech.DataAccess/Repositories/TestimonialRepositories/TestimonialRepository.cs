using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace AiTech.DataAccess.Repositories.TestimonialRepositories
{
    public class TestimonialRepository : GenericRepository<Testimonial>, ITestimonailRepository
    {
        private readonly DbSet<Testimonial> _dbSet;
        public TestimonialRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<Testimonial>();
        }
    }
}
