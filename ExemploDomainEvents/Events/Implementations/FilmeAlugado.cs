using ExemploDomainEvents.Events.Interfaces;
using System;

namespace ExemploDomainEvents.Events.Implementations
{
    public class FilmeAlugado : IDomainEvent
    {
        public FilmeAlugado(int idFilme, int idCliente)
        {
            IdFilme = idFilme;
            IdCliente = idCliente;
            Quando = DateTime.Now;
        }

        public int IdFilme { get; set; }
        public int IdCliente { get; set; }
        public DateTime Quando { get; set; }
    }
}
