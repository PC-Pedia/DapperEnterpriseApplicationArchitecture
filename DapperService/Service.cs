using Dapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Service
{
    public class Service<TEntity> where TEntity : new()
    {
        #region Private Fields
        private readonly IDataRepository<TEntity> _repository;
        #endregion Private Fields

        #region Protected Fields
        protected IDataRepository<TEntity> repository
        {
            get
            {
                return _repository;
            }
        }
        #endregion Protected Fields

        #region Constructor
        protected Service(IDataRepository<TEntity> repository) { _repository = repository; }
        #endregion Constructor

        #region Sync

        IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        IEnumerable<TEntity> GetWhere(object filters)
        {
            return repository.GetWhere(filters);
        }

        TEntity GetFirst(object filters)
        {
            return repository.GetFirst(filters);
        }

        bool Insert(TEntity instance)
        {
            return repository.Insert(instance);
        }

        bool Delete(object key)
        {
            return repository.Delete(key);
        }

        bool Update(TEntity instance)
        {
            return repository.Update(instance);
        }

        #endregion

        #region Async

        Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return repository.GetAllAsync();
        }

        Task<IEnumerable<TEntity>> GetWhereAsync(object filters)
        {
            return repository.GetWhereAsync(filters);
        }

        Task<TEntity> GetFirstAsync(object filters)
        {
            return repository.GetFirstAsync(filters);
        }

        Task<bool> UpdateAsync(TEntity instance)
        {
            return repository.UpdateAsync(instance);
        }

        Task<bool> InsertAsync(TEntity instance)
        {
            return repository.InsertAsync(instance);
        }

        Task<bool> DeleteAsync(object key)
        {
            return repository.DeleteAsync(key);
        }

        #endregion
    }
}