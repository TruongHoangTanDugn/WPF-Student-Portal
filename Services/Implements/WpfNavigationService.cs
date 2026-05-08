using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using WPF_Student_Portal.Views.Onboarding;
using WPF_Student_Portal.Views.Home;

namespace WPF_Student_Portal.Services.Implements
{
    public class WpfNavigationService : INavigationService
    {
        private readonly Page _page;
        public WpfNavigationService(Page page)
        {
            _page = page;
        }

        public void NavigateToLoginPage()
        {
            _page.NavigationService?.Navigate(new LoginPage());
        }

        public void NavigateToRegisterPage()
        {
            _page.NavigationService?.Navigate(new RegisterPage());
        }

        public void NavigateToHomePage()
        {
            _page.NavigationService?.Navigate(new HomePage());
        }
    }
}
