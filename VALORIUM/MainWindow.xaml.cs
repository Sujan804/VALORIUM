using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VALORIUM.Commands;

namespace VALORIUM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsSidePanelVisible = true;
        private bool IsToolbarVisible = true;

        public MainWindow()
        {
            InitializeComponent();
            _ = new SwitchViewCommand(this); //ALT + W
            SetSidePanelVisibility(IsSidePanelVisible);
           
            SetToolbarVisibility(IsToolbarVisible);
            LoadWebView();
           

        }
        private void ViewContent_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //webView.Width = ViewContent.ActualWidth;
            //webView.Height = ViewContent.ActualHeight;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ViewContent.SizeChanged += ViewContent_SizeChanged;
        }
    }
}