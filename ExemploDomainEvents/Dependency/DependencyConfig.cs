using ExemploDomainEvents.DomainEvents.Handles;
using SimpleInjector;
using SimpleInjector.Extensions;

namespace ExemploDomainEvents.Dependency
{
    public static class DependencyConfig
    {
        static DependencyConfig()
        {
            Container = new Container();
        }

        private static readonly Container Container;

        public static Container RegisterServices()
        {
            Container.RegisterManyForOpenGeneric(typeof (IHandle<>),
                (serviceType, implTypes) => Container.RegisterAll(serviceType, implTypes),
                typeof (IHandle<>).Assembly);

            Container.Verify();
            return Container;
        }

        public static Container GetContainer()
        {
            return Container;
        }
    }
}