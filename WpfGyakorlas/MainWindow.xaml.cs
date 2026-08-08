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

namespace WpfGyakorlas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void udvozlesButton_Click(object sender, RoutedEventArgs e)
        {
            string nev = nevTextBox.Text.Trim();

            // Ha nem adott meg vagy üres karaktersorozatot adott meg a felhasználó:
            if (string.IsNullOrEmpty(nev))
            {
                eredmenyTextBlock.Text = "A név ne legyen üres!";

                // Visszatesszük a kurzort a beviteli mezőbe
                nevTextBox.Focus();

                return;
            }

            eredmenyTextBlock.Text = $"Üdvözöllek a WPF világában {nev}!";
        }

    }
}