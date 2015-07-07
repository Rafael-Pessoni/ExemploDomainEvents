using ExemploDomainEvents.DomainEvents.Events;

namespace ExemploDomainEvents.DomainEvents.Handles
{
    public interface IHandle<in T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}
