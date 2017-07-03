using Ninject.Modules;
using Tyco.Domain.Interfaces;
using Tyco.Infra.Repositories;


namespace Tyco.Infra.IoC
{
    public class IocModule : NinjectModule
    {
        /// <summary>
        /// Mapeamento entre interfaces e class para utilizacao do servicelocator
        /// </summary>

        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<ILogInfoRepository>().To<HistoricoRepository>();
            Bind<ISupplierRepository>().To<SupplierRepository>();
            Bind<ContextManager>().ToSelf();
        }
    }
}
