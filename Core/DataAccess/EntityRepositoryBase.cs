using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
       where TContext : DbContext, new()
    {
        public TEntity Create(TEntity entity)
        {
            using var context = new TContext();
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
            return addedEntity.Entity;
        }

        public void Update(TEntity entity)
        {
            using var context = new TContext();
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            using var context = new TContext();
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity? Get(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new TContext();
            var entity = context.Set<TEntity>().SingleOrDefault(filter);
            return entity;
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            using var context = new TContext();
            var entityList = filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
            return entityList;

        }
    }
}
