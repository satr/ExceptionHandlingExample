using System;
using System.Windows;
using System.Windows.Input;
using InternalComponent;

namespace WpfApp
{
    public class DoWork1Command: ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("Do Work 1");
            var internalBL = new InternalBL();
            internalBL.DoInternalBLWork();
        }

        public event EventHandler CanExecuteChanged;
    }
}