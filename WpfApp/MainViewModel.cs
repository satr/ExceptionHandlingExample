using System.Windows.Input;

namespace WpfApp
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            DoWork1Command = new DoWork1Command();
        }

        public DoWork1Command DoWork1Command { get; set; }
    }
}