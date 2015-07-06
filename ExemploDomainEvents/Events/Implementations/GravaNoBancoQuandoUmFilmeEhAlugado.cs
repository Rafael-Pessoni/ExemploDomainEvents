using ExemploDomainEvents.Events.Interfaces;
using ExemploDomainEvents.ValueObjects;
using System;

namespace ExemploDomainEvents.Events.Implementations
{
    public class GravaNoBancoQuandoUmFilmeEhAlugado : IEnderecadorDeEvento<FilmeAlugado>
    {
        public void EnderecarEvento(FilmeAlugado filmeAlugado)
        {
            Console.WriteLine(
                "Aluguel gravado no banco para o filme id {0} e cliente id {1}!",
                filmeAlugado.IdFilme,
                filmeAlugado.IdCliente);
        }
    }
}
