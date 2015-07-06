
namespace ExemploDomainEvents.Events.Interfaces
{
    public interface IEnderecadorDeEvento<T> where T : IDomainEvent
    {
        void EnderecarEvento(T args);
    }
}
