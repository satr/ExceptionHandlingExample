using System;
using System.Windows.Input;
using Common.Logging;
using WpfApp.BL.Services;
using WpfApp.Properties;

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
            ExecuteChecked(ExecuteInternal, parameter);
            ExecuteChecked(FinalizeExecution, parameter);
        }

        protected virtual void ExecuteChecked(Action<object> executeInternal, object parameter)
        {
            try
            {
                executeInternal(parameter);
            }
            catch (Exception e)
            {
                HandleException(e);
            }
        }

        protected void HandleException(Exception e)
        {
            var message = Logger.WriteCritical(Resources.Message_Unexpected_error_occured, e);
            ServiceLocator.Get<HumanInteractionService>().ShowError(message);
        }

        protected virtual void FinalizeExecution(object parameter)
        {
        }

        protected abstract void ExecuteInternal(object parameter);

        public event EventHandler CanExecuteChanged;
    
    }

    public abstract class CommandBase<T> : CommandBase
        where T : Exception
    {
        protected CommandBase(ILogger logger) : base(logger)
        {
        }

        protected override void ExecuteChecked(Action<object> executeInternal, object parameter)
        
        {
            try
            {
                executeInternal(parameter);
            }
            catch (T e)
            {
                HandleException(e);
            }
            catch (Exception e)
            {
                HandleException(e);
            }
        }
    }
}