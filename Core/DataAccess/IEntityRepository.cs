using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Utilities.Abstracts;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity
    {
        T Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        T? Get(Expression<Func<T, bool>> filter);
        List<T>? GetAll(Expression<Func<T, bool>>? filter = null);
    }
}
