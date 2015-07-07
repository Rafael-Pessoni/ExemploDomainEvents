using ExemploDomainEvents.DomainEvents.Events;
using System;

namespace ExemploDomainEvents.Entities
{
    public class Reserva
    {
        private Reserva(int filmeId, int clienteId)
        {
            FilmeId = filmeId;
            ClienteId = clienteId;
            Quando = DateTime.Now;
        }

        public int FilmeId { get; private set; }
        public int ClienteId { get; private set; }
        public DateTime Quando { get; private set; }

        public static Reserva Create(int filmeId, int clientId)
        {
            var reserva = new Reserva(filmeId, clientId);

            DomainEvents.DomainEvents.Raise(new FilmeReservado(reserva));

            return reserva;
        }
    }
}
