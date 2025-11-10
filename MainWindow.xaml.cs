using Microsoft.Web.WebView2.Wpf;
using System.Windows;
using System.Windows.Input;
using System.Net.NetworkInformation;

namespace CatClickerApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Check internet before loading
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("You are offline. Ultimate Cat Clicker requires an internet connection.", 
                              "No Internet", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
                return;
            }

            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.WindowState = WindowState.Minimized;
        }
    }
}