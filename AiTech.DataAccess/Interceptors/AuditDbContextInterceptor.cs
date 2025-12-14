using AiTech.Entity.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace AiTech.DataAccess.Interceptors
{
    public class AuditDbContextInterceptor:SaveChangesInterceptor
    {
        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            foreach( var entry in eventData.Context.ChangeTracker.Entries())
            {
                if(entry.Entity is not BaseEntity baseEntity)
                {
                    continue;
                }

                if(entry.State is EntityState.Added)
                {
                    eventData.Context.Entry(baseEntity).Property(x => x.CreatedDate).CurrentValue = DateTime.Now;
                    eventData.Context.Entry(baseEntity).Property(x => x.UpdateDate).IsModified = false;
                }

                if (entry.State is EntityState.Modified)
                {
                    eventData.Context.Entry(baseEntity).Property(x => x.UpdateDate).CurrentValue = DateTime.Now;
                    eventData.Context.Entry(baseEntity).Property(x => x.CreatedDate).IsModified = true;
                }
            }

            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }
    }
}
