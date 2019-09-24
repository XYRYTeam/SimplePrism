using Infrastructure;
using Prism.Modularity;
using Prism.Regions;

namespace SimplePrism.Modules.SettingModule
{
    public class SettingModule : IModule
    {
        private readonly IRegionManager regionManager;

        public SettingModule(RegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {

        }
    }
}