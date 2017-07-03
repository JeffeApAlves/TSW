using System.Collections.Generic;

namespace Tyco.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        /// <summary>
        /// Interface com o CRUD generico dos repositorios
        /// </summary>


        void Add(TEntity obj);
        void Delete(TEntity obj);
        void Delete(int id);
        TEntity Get(int id);
        IEnumerable<TEntity> Get();
        void Update(TEntity obj);
        void BeginTransaction();
        void Commit();
    }
}
