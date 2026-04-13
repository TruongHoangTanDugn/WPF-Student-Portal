using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Student_Portal.Services
{
    public interface INavigationService
    {
        void NavigateToLoginPage();
        void NavigateToRegisterPage();
        void NavigateToHomePage();
    }
}
