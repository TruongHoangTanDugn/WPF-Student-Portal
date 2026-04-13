using System;
using System.Collections.Generic;
using System.Text;

namespace BTTuan005_StudentPortal.Services
{
    public interface IDialogueService
    {
        void ShowWarning(string message, string title = "Warning");
        void ShowError(string message, string title = "Error");
        void ShowSuccess(string message, string title = "Success");
        void ShowConfirmation(string message, string title = "Confirmation");
    }
}
