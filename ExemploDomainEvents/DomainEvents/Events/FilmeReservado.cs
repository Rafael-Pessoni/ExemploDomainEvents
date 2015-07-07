using ExemploDomainEvents.Entities;

namespace ExemploDomainEvents.DomainEvents.Events
{
    public class FilmeReservado : IDomainEvent
    {
        public FilmeReservado(Reserva reserva)
        {
            Reserva = reserva;
        }

        public Reserva Reserva { get; private set; }
    }
}
