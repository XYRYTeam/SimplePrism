using Prism.Modularity;
using Prism.Regions;
using Unity;

namespace SimplePrism.Modules.SettingModule
{
    public class SettingModule : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;

        public SettingModule(RegionManager regionManager, IUnityContainer container)
        {
            this.regionManager = regionManager;
            this.container = container;
        }

        public void Initialize()
        {
            container.RegisterType<Views.ViewA>();
            container.RegisterType<ViewModels.ViewAViewModel>();
        }
    }
}