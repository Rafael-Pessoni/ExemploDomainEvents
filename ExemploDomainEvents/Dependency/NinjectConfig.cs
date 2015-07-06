using ExemploDomainEvents.Events.Implementations;
using ExemploDomainEvents.Events.Interfaces;
using ExemploDomainEvents.ValueObjects;
using Ninject;
using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ExemploDomainEvents.Dependency
{
    public class NinjectConfig
    {
        public static void ResolveDependencies()
        {
            IKernel kernel = new StandardKernel();

            kernel.Bind<IEnderecadorDeEvento<FilmeAlugado>>().To<GravaNoBancoQuandoUmFilmeEhAlugado>();
            kernel.Bind<IEnderecadorDeEvento<FilmeAlugado>>().To<MandaUmaMensagemParaOClienteAgradecendoAPreferencia>();
            
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }

    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IResolutionRoot _resolutionRoot;
        public NinjectDependencyResolver(IResolutionRoot kernel)
        {
            _resolutionRoot = kernel;
        }

        public object GetService(Type serviceType)
        {
            return _resolutionRoot.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _resolutionRoot.GetAll(serviceType);
        }
    }
}
