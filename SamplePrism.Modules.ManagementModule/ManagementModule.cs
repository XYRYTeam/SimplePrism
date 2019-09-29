using Infrastructure;
using Prism.Modularity;
using Prism.Regions;
using SimplePrism.Modules.ManagementModule.Views;
using SimplePrism.Presentation.Common;
using Prism.Unity;
using Microsoft.Practices.Unity;

namespace SimplePrism.Modules.ManagementModule
{
    public class ManagementModule : IModule
    {
        private readonly Logger _logger = Logger.GetLogger(typeof(ManagementModule));
        private readonly IUnityContainer _container;
        private readonly IRegionManager _regionManager;

        public ManagementModule(IUnityContainer container, IRegionManager regionManager)
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
        }
    }
}