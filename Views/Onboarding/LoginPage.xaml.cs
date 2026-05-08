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
using WPF_Student_Portal.Services.Implements;
using WPF_Student_Portal.ViewModels.Onboarding;

namespace WPF_Student_Portal.Views.Onboarding
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private readonly LoginPageViewModel _viewModel = null!;
        public LoginPage()
        {
            InitializeComponent();
            var navigationService = new WpfNavigationService(this);
            var dialogService = new WpfDialogService();

            _viewModel = new LoginPageViewModel(navigationService, dialogService);
            DataContext = _viewModel;
        }
    }
}
