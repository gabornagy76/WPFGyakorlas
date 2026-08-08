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

            int eletkor;

            if (!int.TryParse(eletkorTextBox.Text, out eletkor))
            {
                eredmenyTextBlock.Text = "Az életkor csak szám lehet!";

                eletkorTextBox.Focus();

                return;
            }

            string uzenet = $"Üdvözöllek a WPF világában {nev}!\nTe {eletkor} éves vagy!";

            if (wpfCheckBox.IsChecked == true)
            {
                uzenet += $"\nÖrülök, hogy kedveled a WPF-et!";
            }
            else
            {
                uzenet += $"\nSajnálom, hogy nem kedveled a WPF-et!";
            }

            if (vremekCheckBox.IsChecked == true)
            {
                uzenet += $"\nJó hír, hogy haladsz a vizsgremekkel!";
            }
            else
            {
                uzenet += $"\nDrukkolok, hogy elkészüljön a vizsgremek!";
            }

            string nem;

            if (ferfiRadioButton.IsChecked == true)
            {
                nem = "férfi";
            }
            else
            {
                nem = "nő";
            }

            uzenet += $"\nNemed: {nem}";

            eredmenyTextBlock.Text = uzenet;
        }

        private void foCheckBox_Click(object sender, RoutedEventArgs e)
        {
            bool allapot = foCheckBox.IsChecked == true;

            wpfCheckBox.IsChecked = allapot;
            vremekCheckBox.IsChecked= allapot;
        }


        private void alCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (wpfCheckBox.IsChecked == true && vremekCheckBox.IsChecked == true)
            {
                foCheckBox.IsChecked = true;
            }
            else if (wpfCheckBox.IsChecked == false && vremekCheckBox.IsChecked == false)
            {
                foCheckBox.IsChecked = false;
            }
            else
            {
                foCheckBox.IsChecked = null;
            }
        }




    }
}