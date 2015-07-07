using ExemploDomainEvents.DomainEvents.Events;
using System;

namespace ExemploDomainEvents.DomainEvents.Handles
{
    public class SaveIntoDataBase : IHandle<FilmeReservado>
    {
        public void Handle(FilmeReservado filmeAlugado)
        {
            Console.WriteLine("Aluguel gravado no banco para o filme id {0} e cliente id {1}!",
                filmeAlugado.Reserva.FilmeId, filmeAlugado.Reserva.ClienteId);
        }
    }
}
