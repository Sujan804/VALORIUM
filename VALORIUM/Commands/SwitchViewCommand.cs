using System.Windows;
using System.Windows.Input;

namespace VALORIUM.Commands
{
    public class SwitchViewCommand
    {
        // private readonly ICommand _command;
        private readonly MainWindow _window;

        //ALT + W to change the 
        public SwitchViewCommand(MainWindow window)
        
        {
            try
            {       
                if (window != null)
                {
                    _window = window;
                    var _ = new RelayCommand(SwitchView, CanSwitchView);
                    var keyBinding = new KeyBinding(_, new KeyGesture(Key.W, ModifierKeys.Alt));
                    _window.InputBindings.Add(keyBinding);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SwitchViewCommand(): " + ex.Message);
            }

        }
        private bool CanSwitchView()
        {
            return true;
        }

        private void SwitchView()
        {

            if (_window.winFormsHost.Visibility == Visibility.Visible)
            {
                _window.winFormsHost.Visibility = Visibility.Collapsed;
               // _window.webView.Visibility = Visibility.Visible;
                _window.ViewSelector.SelectedIndex = 0;
            }
            else
            {
                //_window.webView.Visibility = Visibility.Collapsed;
                _window.winFormsHost.Visibility = Visibility.Visible;
                _window.ViewSelector.SelectedIndex = 1;
            }
        }

    }
}
