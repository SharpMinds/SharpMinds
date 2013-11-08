using System;
using EntityAdapter;
using Fortuna.Common.BusinessObjects;

namespace Fortuna.Services
{
    public abstract class BaseService<T> : IDisposable where T : BusinessObject
    {
        private readonly BaseService<T> _baseService;

        public T GetById(int id)
        {
            using (var repository = new GenericRepository<T>())
            {
                var entity = repository.FindSingleBy<T>(t => t.Id == id);
                return entity;
            }
        }

        protected BaseService(BaseService<T> baseService)
        {
            _baseService = baseService;
        }

        protected BaseService()
        {
        }

        public void Dispose()
        {
            if (_baseService != null) _baseService.Dispose();
        }
    }
}
