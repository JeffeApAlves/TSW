using POSoftware.Infra;
using System.Collections.Generic;
using Tyco.Domain.Interfaces;
using Tyco.Infra.Repositories;

namespace Tyco.Application
{
    public class HistoricoApplication : ApplicationBase
    {
        /// <summary>
        /// metodos com as consultas(em alto nivel) e interacao com seu respectivo repostiros
        /// </summary>

        private HistoricoRepository _repository;
        private ILogInfoRepository _irepository;


        public HistoricoApplication()
        {
            _repository = new HistoricoRepository();

            _irepository = _repository;
        }

        public HistoricoApplication(ILogInfoRepository irepository)
        {
            _irepository = irepository;
        }

        public void Register(LogInfo info)
        {
            _irepository.BeginTransaction();

            _irepository.Add(info);

            _irepository.Commit();
        }

        public void Remove(LogInfo info)
        {
            _irepository.BeginTransaction();

            _irepository.Delete(info);

            _irepository.Commit();
        }

        public void Remove(int id)
        {
            _irepository.BeginTransaction();

            _irepository.Delete(id);

            _irepository.Commit();
        }

        public LogInfo Get(int id)
        {
            _irepository.BeginTransaction();

            LogInfo info = _irepository.Get(id);

            return info;
        }

        public IEnumerable<LogInfo> Get()
        {
            _irepository.BeginTransaction();

            IEnumerable<LogInfo> list_info = _irepository.Get();

            return list_info;
        }

        public IEnumerable<LogInfo> GetByCNPJ(string cnpj)
        {
            _irepository.BeginTransaction();

            IEnumerable<LogInfo> list_LogInfos;

            if (cnpj == null || cnpj == "" || cnpj == " ")

                list_LogInfos = _irepository.Get();
            else
                list_LogInfos = _irepository.GetByCNPJ(cnpj);

            return list_LogInfos;
        }

        public void Update(LogInfo info)
        {
            _irepository.BeginTransaction();

            _irepository.Update(info);

            _irepository.Commit();
        }
    }
}

