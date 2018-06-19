using Prism.Regions;

namespace WPF_Prism_Skeleton.Modules.View2Module.ViewModels
{
    public class View2ViewModel : ViewModelBase, IView2ViewModel, INavigationAware
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

        public View2ViewModel()
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
