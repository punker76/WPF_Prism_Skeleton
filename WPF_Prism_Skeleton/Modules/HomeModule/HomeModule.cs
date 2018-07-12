using Microsoft.Practices.Unity;
using Prism.Regions;
using WPF_Prism_Skeleton.Modules.HomeModule.Navigation;
using WPF_Prism_Skeleton.Modules.HomeModule.ViewModels;
using WPF_Prism_Skeleton.Modules.HomeModule.Views;

namespace WPF_Prism_Skeleton.Modules.HomeModule
{
    public class HomeModule : ModuleBase
    {
        public HomeModule(IUnityContainer container, IRegionManager regionManager)
            : base(container, regionManager) { }

        protected override void InitializeModule()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.ToolbarRegion, typeof(HomeNavButton));
            RegionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(HomeView));
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<IHomeViewModel, HomeViewModel>();
            Container.RegisterTypeForNavigation<HomeView>();
        }
    }
}
