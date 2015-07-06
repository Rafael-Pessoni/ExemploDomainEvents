using ExemploDomainEvents.Events.Interfaces;
using System.Web.Mvc;

namespace ExemploDomainEvents.Events.Implementations
{
    public static class DomainEvents
    {
        public static void Raise<T>(T evento) where T : IDomainEvent
        {
            var enderecadoresDeEvento = DependencyResolver.Current.GetServices<IEnderecadorDeEvento<T>>(); 

            foreach (var enderecadorDeEvento in enderecadoresDeEvento)
            {
                enderecadorDeEvento.EnderecarEvento(evento);
            }
        }
    }
}
