using System;
using System.Windows.Input;
using Common.Logging;
using WpfApp.BL.Services;

namespace WpfApp.Commands
{
    public abstract class CommandBase : ICommand
    {
        protected CommandBase(ILogger logger)
        {
            Logger = logger;
        }

        protected ILogger Logger { get; set; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                ExecuteInternal(parameter);
            }
            catch (Exception e)
            {
                var message = Logger.WriteCritical("Unexpected error occured.", e);
                ServiceLocator.Get<HumanInteractionService>().ShowError(message);
            }
        }

        protected abstract void ExecuteInternal(object parameter);
        public event EventHandler CanExecuteChanged;
    }
}