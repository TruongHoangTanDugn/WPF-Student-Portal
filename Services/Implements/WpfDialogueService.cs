using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using BTTuan005_StudentPortal.Services;

namespace BTTuan005_StudentPortal.Services.Implements
{
    public class WpfDialogueService : IDialogueService
    {
        public void ShowWarning(string message, string title = "Warning")
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        public void ShowError(string message, string title = "Error")
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public void ShowSuccess(string message, string title = "Success")
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public void ShowConfirmation(string message, string title = "Confirmation")
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
