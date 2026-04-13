using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using WPF_Student_Portal.Services;
using WPF_Student_Portal.Services.Implements;

namespace WPF_Student_Portal.ViewModels.Onboarding
{
    public partial class LandingPageViewModel : ObservableObject
    {
        private readonly INavigationService _navigationService;
        private readonly IDialogService _dialogService;

        public LandingPageViewModel(INavigationService navigationService, IDialogService dialogService)
        {
            _navigationService = navigationService;
            _dialogService = dialogService;
        }
        [RelayCommand]
        public void Login()
        {
            _navigationService.NavigateToLoginPage();
        }

        public void Register()
        {
            _navigationService.NavigateToRegisterPage();
        }
    }
}
