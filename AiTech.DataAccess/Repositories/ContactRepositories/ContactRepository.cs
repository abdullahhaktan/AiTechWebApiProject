using AiTech.DataAccess.Context;
using AiTech.DataAccess.Repositories.GenericRepositories;
using AiTech.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTech.DataAccess.Repositories.ContactRepositories
{
    public class ContactRepository:GenericRepository<Contact> , IContactRepository
    {
        private readonly DbSet<Contact> _dbSet;
        public ContactRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<Contact>();
        }
    }
}
