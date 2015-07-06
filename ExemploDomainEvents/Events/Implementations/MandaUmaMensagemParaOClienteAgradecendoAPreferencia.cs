using ExemploDomainEvents.Events.Interfaces;
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
