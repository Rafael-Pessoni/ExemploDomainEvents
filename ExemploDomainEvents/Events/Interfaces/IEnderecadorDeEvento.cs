
namespace ExemploDomainEvents.Events.Interfaces
{
    public interface IEnderecadorDeEvento<in T> where T : IDomainEvent
    {
        void EnderecarEvento(T args);
    }
}
