using Prism.Modularity;
using Prism.Regions;
using SimplePrism.Modules.ManagementModule.Views;
using SimplePrism.Presentation.Common;
using Unity;

namespace SimplePrism.Modules.ManagementModule
{
    public class ManagementModule : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;

        public ManagementModule(RegionManager regionManager, IUnityContainer container)
        {
            this._regionManager = regionManager;
            this._container = container;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(LoginScreen));
        }
    }
}