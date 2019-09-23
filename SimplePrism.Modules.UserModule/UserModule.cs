using Prism.Modularity;
using Prism.Regions;
using SimplePrism.Presentation.Common;

namespace SimplePrism.Modules.UserModule
{
    public class UserModule : IModule
    {
        private readonly IRegionManager regionManager;

        public UserModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
        }
    }
}