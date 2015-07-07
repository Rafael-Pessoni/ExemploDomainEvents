using ExemploDomainEvents.Dependency;
using ExemploDomainEvents.Entities;
using System;

namespace ExemploDomainEvents
{
    class Program
    {
        // Implementação do exemplo baseada no post :  http://blog.lambda3.com.br/2009/11/domain-events/

        static void Main(string[] args)
        {
            DependencyConfig.RegisterServices();

            //criando uma reserva
            var reserva = Reserva.Create(1, 1);

            //alguma logica com a reserva...

            Console.ReadLine();
        }
    }
}
