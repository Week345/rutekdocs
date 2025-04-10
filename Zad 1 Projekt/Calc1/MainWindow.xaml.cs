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

namespace Calc1
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

        private void Button_Click(object sender, RoutedEventArgs e) {
            //Pobierz wartosci z pol tekstowych
            string user_num1 = num1.Text;
            string user_num2 = num2.Text;
            // Sprobuj przekonwertowac tekst na liczby
            if (double.TryParse(user_num1, out double num1_dbl) && double.TryParse(user_num2, out double num2_dbl)) {
                //Wykonaj dodawanie
                double suma = num1_dbl + num2_dbl;
                //Wyswietl wynik w polu nazwanym wynik
                wynik.Content = "Wynik: " + suma.ToString();
            }
            else {
                //Wyswietl komunikat o bledzie jesli liczby sa nie prawidlowe (czyt. nie skonwertuja sie na liczby)
                MessageBox.Show("Wprowadź poprawne liczby!");
            }
        }
    }
}