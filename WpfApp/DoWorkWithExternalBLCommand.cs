using System;
using System.Windows.Input;
using ExternalBLInterfaces;

namespace WpfApp
{
    public class DoWorkWithExternalBLCommand : ICommand
    {
        private readonly IExternalBL _externalBL;

        public DoWorkWithExternalBLCommand(IExternalBL externalBL)
        {
            _externalBL = externalBL;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _externalBL.DoWork();
        }

        public event EventHandler CanExecuteChanged;
    }
}