using POSoftware.Infra;
using System.Collections.Generic;
using System.Linq;
using Tyco.Domain.Interfaces;

namespace Tyco.Infra.Repositories
{
    public class SupplierRepository : RepositoryBase<Supplier>, ISupplierRepository
    {
        /// <summary>
        /// repositorio para gerenciamento do Context do DB(especifico para Supplier) com a interface de CRUD 
        /// implementada
        /// </summary>

        public IEnumerable<Supplier> GetByCNPJ(string cnpj)
        {
            return Context.Set<Supplier>().Where(x => x.CNPJ == cnpj).ToList();
        }

        public IEnumerable<Supplier> GetByData(string data)
        {
            return Context.Set<Supplier>().Where(x => x.CreateDate == data).ToList();
        }
    }
}
