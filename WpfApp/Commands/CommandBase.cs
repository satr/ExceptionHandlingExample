using System;
using System.Windows.Input;
using Common.Logging;

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
            ExecuteInternal(parameter);
        }

        protected abstract void ExecuteInternal(object parameter);
        public event EventHandler CanExecuteChanged;
    }
}