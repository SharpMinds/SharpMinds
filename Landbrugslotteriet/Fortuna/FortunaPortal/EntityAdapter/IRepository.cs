using System;
using System.Linq;
using System.Linq.Expressions;

namespace EntityAdapter
{
    public interface IRepositoryBase
    {
        int Delete<TEntity>(TEntity entity) where TEntity : class;
        void Dispose();
        IQueryable<TEntity> FindAllBy<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        TEntity FindSingleBy<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;
        IQueryable<TEntity> GetAll<TEntity>() where TEntity : class;
        IQueryable<TEntity> GetIncluding<TEntity>(params Expression<Func<TEntity, object>>[] includeProperties) where TEntity : class;
        int Save<TEntity>(TEntity entity) where TEntity : class;
        int Update<TEntity>(TEntity entity) where TEntity : class;
    }
}
