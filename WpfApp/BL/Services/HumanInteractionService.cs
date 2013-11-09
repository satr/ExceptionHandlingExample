using System.Windows;
using Common.Services;

namespace WpfApp.BL.Services
{
    class HumanInteractionService : IHumanInteractionService
    {
        public virtual void ShowError(string message)
        {
            ShowMessage(message, "Error", MessageBoxImage.Error);
        }

        public virtual void ShowWarning(string message)
        {
            ShowMessage(message, "Warning", MessageBoxImage.Warning);
        }

        public virtual void ShowInfo(string message)
        {
            ShowMessage(message, "Info", MessageBoxImage.Information);
        }

        private static void ShowMessage(string message, string caption, MessageBoxImage icon)
        {
            MessageBox.Show(message, caption, MessageBoxButton.OK, icon, MessageBoxResult.OK);
        }
    }
}