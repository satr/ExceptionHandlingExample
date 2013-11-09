using System.Windows.Controls;
using System.Windows.Input;
using InternalComponent;

namespace WpfApp
{
    public class MainViewModel
    {
        public MainViewModel(StackPanel externalBLPanel)
        {
            var internalBL = new InternalBL();
            DoWorkWithInternalBL1Command = new DoWorkWithInternalBL1Command(internalBL);
            DoWorkWithInternalBL2Command = new DoWorkWithInternalBL2Command(internalBL);
            foreach (var externalBL in Helpers.LoadExternalComponents())
            {
                externalBLPanel.Children.Add(Helpers.CreateExternalBLUIElement(externalBL));
            }
        }


        public ICommand DoWorkWithInternalBL1Command { get; set; }
        public ICommand DoWorkWithInternalBL2Command { get; set; }
    }
}