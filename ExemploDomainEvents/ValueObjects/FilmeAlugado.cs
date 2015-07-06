using ExemploDomainEvents.Events.Interfaces;
using System;

namespace ExemploDomainEvents.ValueObjects
{
    public class FilmeAlugado : IDomainEvent
    {
        public FilmeAlugado()
        {
            Quando = DateTime.Now;
        }

        public int IdFilme { get; set; }
        public int IdCliente { get; set; }
        public DateTime Quando { get; set; }
    }
}
