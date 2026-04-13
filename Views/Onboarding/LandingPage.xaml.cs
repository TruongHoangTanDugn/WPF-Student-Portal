using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Student_Portal.ViewModels.Onboarding;
using WPF_Student_Portal.Services;
using WPF_Student_Portal.Services.Implements;

namespace WPF_Student_Portal.Views.Onboarding
{
    public partial class LandingPage : Page
    {
        private readonly LandingPageViewModel _viewModel = null!;

        public LandingPage()
        {
            InitializeComponent();
            var navigationService = new WpfNavigationService(this);
            var dialogService = new WpfDialogService();

            _viewModel = new LandingPageViewModel(navigationService, dialogService);
        }
    }
}
