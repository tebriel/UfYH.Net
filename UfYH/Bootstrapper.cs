using System;
using System.Collections.Generic;
using Caliburn.Micro;
using Microsoft.Practices.Unity;
using UfYH.ViewModels;

namespace UfYH
{


    public class Bootstrapper: Bootstrapper<ShellViewModel>
    {
        private readonly UnityContainer _container;

        public Bootstrapper()
        {
            _container = new UnityContainer();
            _container
                .RegisterType<IWindowManager, WindowManager>(new ContainerControlledLifetimeManager())
                .RegisterType<ShellViewModel>(new ContainerControlledLifetimeManager())
                .RegisterType<IScreen, RandomUnfuckingViewModel>(new ContainerControlledLifetimeManager());
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.ResolveAll(service);
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.Resolve(service, key);
        }

        public void Dispose()
        {
            //Currently nothing to do.
        }
    }
}