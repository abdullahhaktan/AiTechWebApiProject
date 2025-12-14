using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
