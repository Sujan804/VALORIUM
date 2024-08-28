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

namespace VALORIUM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isSidePanelVisible = true;
        private bool isToolbarVisible = true;
        public MainWindow()
        {
            InitializeComponent();
            SetSidePanelVisibility(isSidePanelVisible);
            SetToolbarVisibility(isToolbarVisible);
            LoadWebView();
        }
      
        

    }
}