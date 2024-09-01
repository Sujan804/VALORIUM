using System.Windows;
using System.Windows.Controls;

namespace VALORIUM
{
    public partial class MainWindow
    {
        private void SetToolbarVisibility(bool isVisible)
        {
            if (isVisible)
            {
                toolBar.Visibility = Visibility.Visible;
                menuItemHideToolbar.Header = "_Hide toolbar";

            }
            else
            {
                toolBar.Visibility = Visibility.Collapsed;
                menuItemHideToolbar.Header = "_Show toolbar";
            }
        }
        private void TogglePanel_Click(object sender, RoutedEventArgs e)
        {
            IsSidePanelVisible = !IsSidePanelVisible;
            SetSidePanelVisibility(IsSidePanelVisible);
        }
        private void SetSidePanelVisibility(bool isVisible)
        {
            if (isVisible)
            {
                pnlRight.Visibility = Visibility.Visible;
                menuItemHideSidebar.Header = "_Hide sidebar";
                RightPanelColumn.Width = new GridLength(0.2, GridUnitType.Star); // 20% of the width

            }
            else
            {
                pnlRight.Visibility = Visibility.Collapsed;
                menuItemHideSidebar.Header = "_Show sidebar";
                 RightPanelColumn.Width = new GridLength(0); // Collapse the column
            }
        }
        private void MenuItem_HideToolbar_Click(object sender, RoutedEventArgs e)
        {
            IsToolbarVisible = !IsToolbarVisible;
            SetToolbarVisibility(IsToolbarVisible);
        }
        private void btnCancelWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnMinimizeWindow_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void ViewSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected ComboBoxItem
            var selectedItem = (ComboBoxItem)ViewSelector.SelectedItem;
            var selectedTag = selectedItem?.Tag.ToString();

            // Hide both controls initially
            winFormsHost.Visibility = Visibility.Collapsed;
            //webView.Visibility = Visibility.Collapsed;

            // Show the selected control
            if (selectedTag == "3D")
            {
               // webView.Visibility = Visibility.Visible;
            }
            else if (selectedTag == "2D")
            {
                winFormsHost.Visibility = Visibility.Visible;
            }
        }

    }
}
