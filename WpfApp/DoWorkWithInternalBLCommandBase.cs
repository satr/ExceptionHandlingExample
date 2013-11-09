using System;
using System.Windows.Input;
using InternalComponent;

namespace WpfApp
{
    public abstract class DoWorkWithInternalBLCommandBase : ICommand
    {
        protected readonly InternalBL InternalBL;

        protected DoWorkWithInternalBLCommandBase(InternalBL internalBL)
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