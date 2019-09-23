using Prism.Modularity;
using Prism.Regions;
using SimplePrism.Modules.ManagementModule.Views;
using SimplePrism.Presentation.Common;

namespace SimplePrism.Modules.ManagementModule
{
    public class ManagementModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ManagementModule(RegionManager regionManager)
        {
            this._regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(LoginScreen));
        }
    }
}