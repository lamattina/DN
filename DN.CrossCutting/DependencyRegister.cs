using DN.ApplicationService;
using DN.Data;
using DN.Data.DataContext;
using DN.Data.Repository;
using DN.Domain.Repositories;
using DN.Domain.Services;
using DN.SharedKernel.Contracts;
using DN.SharedKernel.Events;
using Unity;
using Unity.Lifetime;

namespace DN.CrossCutting
{
    public static class DependencyRegister
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<DNContext, DNContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());

            container.RegisterType<IProductRepository, ProductRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IProductApplicationService, ProductApplicationService>(new HierarchicalLifetimeManager());

            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());
        }
    }
}
