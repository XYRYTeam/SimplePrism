using Infrastructure;
using Prism.Modularity;
using Prism.Regions;
using SimplePrism.Modules.ManagementModule.Views;
using SimplePrism.Presentation.Common;
using Unity;
using Prism.Unity;

namespace SimplePrism.Modules.ManagementModule
{
    public class ManagementModule : IModule
    {
        private readonly UnityContainer _container;
        private readonly IRegionManager _regionManager;

        public ManagementModule(UnityContainer container, IRegionManager regionManager)
        {
            this._container = container;
            this._regionManager = regionManager;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<LoginScreen>();
            _container.RegisterTypeForNavigation<MenuScreen>();
            _container.RegisterTypeForNavigation<ContentScreen>();
            //_regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(LoginScreen));

            _regionManager.RequestNavigate(RegionNames.MainRegion, "LoginScreen");

            Logger.GetLogger(typeof(ModuleManager)).Debug("------------------>");

            Logger.Default.Debug("test");
        }
    }
}