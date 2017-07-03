using POSoftware.Infra;
using System.Collections.Generic;
using System.Linq;
using Tyco.Domain.Interfaces;


namespace Tyco.Infra.Repositories
{
    public class HistoricoRepository : RepositoryBase<LogInfo>, ILogInfoRepository
    {
        /// <summary>
        /// Repositorio para gerenciamento do Context do DB(especifico para Log) com a interface CRUD implementada
        /// </summary>

        public IEnumerable<LogInfo> GetByCNPJ(string cnpj)
        {
            return Context.Set<LogInfo>().Where(x => x.CNPJ == cnpj).ToList();
        }
    }
}
