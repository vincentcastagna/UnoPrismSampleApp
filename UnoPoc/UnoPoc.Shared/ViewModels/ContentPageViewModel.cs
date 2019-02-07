using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Windows.Navigation;

namespace UnoPoc.ViewModels
{

    public class ContentPageViewModel
    {
        public DelegateCommand NavigateBackCommand { get; set; }
        private readonly INavigationService _navigationService;

        public ContentPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateBackCommand = new DelegateCommand(_navigationService.GoBack);
        }
    }
}
