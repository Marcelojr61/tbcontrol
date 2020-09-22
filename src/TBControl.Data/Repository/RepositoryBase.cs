using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TBControl.Business.Interfaces.IRepository;
using TBControl.Data.Context;

namespace TBControl.Data.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>, IDisposable where T : class
    {
        protected TBControlDbContext Context; 
        protected DbSet<T> DbSet;

        protected RepositoryBase(TBControlDbContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task<T> GetById(Guid id)
        {
            return await DbSet.FindAsync();
        }

        public async Task<IEnumerable<T>> Search(Expression<Func<T, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task Register(T register)
        {
            DbSet.Add(register);
            await SaveChanges();
        }

        public virtual async Task Remove(Guid id)
        {
            var register = DbSet.FindAsync().Result; 
            DbSet.Remove(register);
            await SaveChanges();
        }

        public virtual async Task Update(T register)
        {
            DbSet.Update(register);
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (Context !=null)
            {
                Context = null;
            };
        }
    }
}
