using ExemploDomainEvents.Events.Interfaces;
using ExemploDomainEvents.ValueObjects;
using System;

namespace ExemploDomainEvents.Events.Implementations
{
    public class MandaUmaMensagemParaOClienteAgradecendoAPreferencia : IEnderecadorDeEvento<FilmeAlugado>
    {
        public void EnderecarEvento(FilmeAlugado filmeAlugado)
        {
            Console.WriteLine("Email enviado!");
        }
    }
}
