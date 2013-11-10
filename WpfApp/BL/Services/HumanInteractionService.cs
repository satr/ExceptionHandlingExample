using System.Windows;
using Common.Services;
using WpfApp.Properties;

namespace WpfApp.BL.Services
{
    class HumanInteractionService : IHumanInteractionService
    {
        public virtual void ShowError(string message)
        {
            ShowMessage(message, Resources.Title_Error, MessageBoxImage.Error);
        }

        public virtual void ShowWarning(string message)
        {
            ShowMessage(message, Resources.Title_Warning, MessageBoxImage.Warning);
        }

        public virtual void ShowInfo(string message)
        {
            ShowMessage(message, Resources.Title_Info, MessageBoxImage.Information);
        }

        private static void ShowMessage(string message, string caption, MessageBoxImage icon)
        {
            MessageBox.Show(message, caption, MessageBoxButton.OK, icon, MessageBoxResult.OK);
        }
    }
}