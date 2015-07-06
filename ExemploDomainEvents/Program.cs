using ExemploDomainEvents.Dependency;
using ExemploDomainEvents.Events.Implementations;
using ExemploDomainEvents.ValueObjects;
using System;

namespace ExemploDomainEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementação do exemplo baseada no post :  http://blog.lambda3.com.br/2009/11/domain-events/

            NinjectConfig.ResolveDependencies();

            //preparando o evento
            const int idCliente = 1;
            const int idFilme = 1;
            var alugaramUmFilme = new FilmeAlugado
            {
                IdCliente = idCliente,
                IdFilme = idFilme,
                Quando = DateTime.Now
            };

            //lançando o evento
            DomainEvents.Raise(alugaramUmFilme);

            Console.ReadLine();
        }
    }
}
