using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TBControl.Business.Interfaces.IRepository
{
    public interface IRepositoryBase<T>
    {
        Task<T> GetById(Guid id);
        Task<List<T>> GetAll();
        Task<IEnumerable<T>> Search(Expression<Func<T, bool>> predicate);
        Task Register(T register);
        Task Update(T register);
        Task Remove(Guid id);
        Task<int> SaveChanges();
    }
}
