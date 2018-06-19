using Prism.Regions;

namespace WPF_Prism_Skeleton.Modules.HomeModule.ViewModels
{
    public class HomeViewModel : ViewModelBase, IHomeViewModel, INavigationAware
    {
        private int _pageViews;
        public int PageViews
        {
            get { return _pageViews; }
            set
            {
                _pageViews = value;
                OnPropertyChanged("PageViews");
            }
        }

        public HomeViewModel()
        {

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
            PageViews++;
        }
    }
}
