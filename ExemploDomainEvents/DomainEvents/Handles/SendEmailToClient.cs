using ExemploDomainEvents.DomainEvents.Events;
using System;

namespace ExemploDomainEvents.DomainEvents.Handles
{
    public class SendEmailToClient : IHandle<FilmeReservado>
    {
        public void Handle(FilmeReservado args)
        {
            Console.WriteLine("Email enviado!");
        }
    }
}
