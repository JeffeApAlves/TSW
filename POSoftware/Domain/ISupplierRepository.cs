using POSoftware.Infra;
using System.Collections.Generic;

namespace Tyco.Domain.Interfaces
{
    public interface ISupplierRepository : IRepositoryBase<Supplier>
    {
        /// <summary>
        /// interface CRUD especifica para o repositorio SupplierRepository
        /// </summary>

        IEnumerable<Supplier> GetByData(string data);
        IEnumerable<Supplier> GetByCNPJ(string cnpj);
    }
}
