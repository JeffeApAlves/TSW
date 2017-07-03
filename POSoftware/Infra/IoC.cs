using CommonServiceLocator.NinjectAdapter.Unofficial;
using Microsoft.Practices.ServiceLocation;
using Ninject;

namespace Tyco.Infra.IoC
{
    public class IoC
    {
        /// <summary>
        /// inicializa o servicelocator 
        /// </summary>

        public static void Init()
        {
            var kernel = new StandardKernel(new IocModule());

            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(kernel));
        }
    }
}
