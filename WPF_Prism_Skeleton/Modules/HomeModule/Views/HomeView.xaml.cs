using Prism.Regions;
using System.Windows.Controls;
using WPF_Prism_Skeleton.Modules.HomeModule.ViewModels;

namespace WPF_Prism_Skeleton.Modules.HomeModule.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl, IView, INavigationAware
    {
        public IViewModel ViewModel
        {
            get { return (IViewModel)DataContext; }
            set { DataContext = value; }
        }

        public HomeView(IHomeViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }
    }
}
