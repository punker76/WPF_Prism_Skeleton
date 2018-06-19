using Microsoft.Practices.Unity;
using Prism.Regions;
using WPF_Prism_Skeleton.Modules.View2Module.Navigation;
using WPF_Prism_Skeleton.Modules.View2Module.ViewModels;
using WPF_Prism_Skeleton.Modules.View2Module.Views;

namespace WPF_Prism_Skeleton.Modules.View2Module
{
    public class View2Module : ModuleBase
    {
        public View2Module(IUnityContainer container, IRegionManager regionManager)
                : base(container, regionManager) { }

        protected override void InitializeModule()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.ToolbarRegion, typeof(View2NavButton));
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<IView2ViewModel, View2ViewModel>();
            Container.RegisterTypeForNavigation<View2View>();
        }
    }
}
