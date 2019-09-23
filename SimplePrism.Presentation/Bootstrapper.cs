using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace SimplePrism.Presentation
{
    internal class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
            //return base.CreateShell();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
            //base.InitializeShell();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog()
            {
                ModulePath = @".\Modules"
            };
            //return base.CreateModuleCatalog();
        }
    }
}