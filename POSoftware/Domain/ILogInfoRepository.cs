using POSoftware.Infra;
using System.Collections.Generic;

namespace Tyco.Domain.Interfaces
{
    public interface ILogInfoRepository : IRepositoryBase<LogInfo>
    {
        /// <summary>
        /// interface CRUD especifica para o repositorio HistoricoRepository
        /// </summary>

        IEnumerable<LogInfo> GetByCNPJ(string cnpj);
    }
}
