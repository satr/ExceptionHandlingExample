using System;
using System.Windows.Input;
using InternalComponent;

namespace WpfApp.Commands
{
    public abstract class InternalComponentCommandBase : ICommand
    {
        protected readonly InternalBL InternalBL;

        protected InternalComponentCommandBase(InternalBL internalBL)
        {
            InternalBL = internalBL;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
        public event EventHandler CanExecuteChanged;
    }
}