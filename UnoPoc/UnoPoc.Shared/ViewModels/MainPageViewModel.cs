using System.Windows.Input;
using Prism.Commands;
using Prism.Windows.Navigation;
using Prism.Windows.Mvvm;

namespace UnoPoc.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand NavigateCommand { get; set; }
        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateCommand = new DelegateCommand(() => _navigationService.Navigate("Content", null));
        }
    }
}
