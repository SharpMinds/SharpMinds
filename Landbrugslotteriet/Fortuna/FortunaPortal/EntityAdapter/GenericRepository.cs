using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace EntityAdapter
{
    // ReSharper disable CSharpWarnings::CS0693
    public sealed class GenericRepository<T> : IDisposable, IRepositoryBase where T : class
    {
        private FortunaEntities _dataContext;

        private FortunaEntities DataContext
        {
            get { return _dataContext ?? (_dataContext = new FortunaEntities()); }
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            using (DataContext)
                return DataContext.Set<T>();
        }


        public T FindSingleBy<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            if (predicate == null)
                throw new ArgumentNullException("Predicate value must be passed to FindSingleBy<T>.");
            using (DataContext)
                return DataContext.Set<T>().Where(predicate).SingleOrDefault();
        }

        public IQueryable<T> FindAllBy<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            if (predicate == null) throw new ArgumentNullException("Predicate value must be passed to FindBy<T,TKey>.");
            using (DataContext)
                return DataContext.Set<T>().Where(predicate).AsQueryable<T>();
        }

        public IQueryable<T> GetIncluding<T>(params Expression<Func<T, object>>[] includeProperties) where T : class
        {
            IQueryable<T> query = _dataContext.Set<T>();
            return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public int Save<T>(T entity) where T : class
        {
            return DataContext.SaveChanges();
        }

        public int Update<T>(T entity) where T : class
        {
            return DataContext.SaveChanges();
        }

        public int Delete<T>(T entity) where T : class
        {
            DataContext.Set<T>().Remove(entity);
            return DataContext.SaveChanges();
        }

        public void Dispose()
        {
            if (DataContext != null) DataContext.Dispose();
        }
    }
    // ReSharper restore CSharpWarnings::CS0693
}
