using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Windows;
using WpfStudy.ViewModels;

namespace WpfStudy
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer container;

        public Bootstrapper()
        {
            Initialize();
        }
        protected override void Configure()
        {
            container = new SimpleContainer();
            container.Singleton<IWindowManager, WindowManager>();
            container.PerRequest<MainWindowViewModel>();
            container.PerRequest<GridPageViewModel>();
            container.PerRequest<TablePageViewModel>();
            var typeMappingConfiguration = new TypeMappingConfiguration();

            ViewLocator.ConfigureTypeMappings(typeMappingConfiguration);
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainWindowViewModel>();
        }
        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }
        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }
        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }
    }
}
