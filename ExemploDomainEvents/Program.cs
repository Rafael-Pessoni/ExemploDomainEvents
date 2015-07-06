using ExemploDomainEvents.Dependency;
using ExemploDomainEvents.Events.Implementations;
using System;

namespace ExemploDomainEvents
{
    class Program
    {
        // Implementação do exemplo baseada no post :  http://blog.lambda3.com.br/2009/11/domain-events/

        static void Main(string[] args)
        {
            NinjectConfig.ResolveDependencies();

            //preparando o evento
            var alugaramUmFilme = new FilmeAlugado(1, 1);

            //lançando o evento
            DomainEvents.Raise(alugaramUmFilme);

            Console.ReadLine();
        }
    }
}
