using Prism.Regions;
using System.Windows.Controls;
using WPF_Prism_Skeleton.Modules.View2Module.ViewModels;

namespace WPF_Prism_Skeleton.Modules.View2Module.Views
{
    /// <summary>
    /// Interaction logic for View2View.xaml
    /// </summary>
    public partial class View2View : UserControl, IView, INavigationAware
    {
        public IViewModel ViewModel
        {
            get { return (IViewModel)DataContext; }
            set { DataContext = value; }
        }

        public View2View(IView2ViewModel viewModel)
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
