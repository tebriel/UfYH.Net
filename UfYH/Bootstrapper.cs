using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Xml.Serialization;
using Caliburn.Micro;
using Microsoft.Practices.Unity;
using UfYH.Models;
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
                .RegisterType<IScreen, RandomUnfuckingViewModel>(new ContainerControlledLifetimeManager())
                .RegisterInstance(LoadData());
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

        private static void CheckForPerfDir()
        {
            if (!Directory.Exists(Environment.ExpandEnvironmentVariables(ConfigurationManager.AppSettings["ProfilePath"])))
            {
                Directory.CreateDirectory(
                    Environment.ExpandEnvironmentVariables(ConfigurationManager.AppSettings["ProfilePath"]));
            }
        }

        private RandomListModel LoadData()
        {
            var profileFilePath = Environment.ExpandEnvironmentVariables(ConfigurationManager.AppSettings["ProfilePath"]);
            profileFilePath = Path.Combine(profileFilePath, ConfigurationManager.AppSettings["ProfileFileName"]);
            var serializer = new XmlSerializer(typeof(RandomListModel));
            if (!File.Exists(profileFilePath))
                return new RandomListModel();

            var textStream = new FileStream(profileFilePath, FileMode.Open);
            return serializer.Deserialize(textStream) as RandomListModel;
        }
    }
}