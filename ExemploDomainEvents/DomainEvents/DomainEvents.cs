using ExemploDomainEvents.Dependency;
using ExemploDomainEvents.DomainEvents.Events;
using ExemploDomainEvents.DomainEvents.Handles;

namespace ExemploDomainEvents.DomainEvents
{
    public static class DomainEvents
    {
        public static void Raise<T>(T evento) where T : IDomainEvent
        {
            var handles = DependencyConfig.GetContainer().GetAllInstances<IHandle<T>>();

            foreach (var handle in handles)
                handle.Handle(evento);
        }
    }
}
