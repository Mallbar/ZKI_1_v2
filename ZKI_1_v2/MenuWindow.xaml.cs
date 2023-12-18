using System.Windows;

namespace ZKI_1_v2
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void PolybusSquareButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new PolybiusSquareWindow();
            window.Show();
            this.Close();
        }

        private void DoublePermutationButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new DoublePermutationWindow();
            window.Show();
            this.Close();
        }

        private void SinglePermutationButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new SinglePermutationWindow();
            window.Show();
            this.Close();
        }

        private void VigenerAndCaesarButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new VigenerAndCaesar();
            window.Show();
            this.Close();
        }

        private void VigenerAndPleifor_Click(object sender, RoutedEventArgs e)
        {
            var window = new VigenerAndPleifor();
            window.Show();
            this.Close();
        }
        private void PleiforAndWidson_Click(object sender, RoutedEventArgs e)
        {
            var window = new PleiforWidson();
            window.Show();
            this.Close();
        }

        private void GammaAndCaesar_Click(object sender, RoutedEventArgs e)
        {
            var window = new GammaAndCaesar();
            window.Show();
            this.Close();
        }

        private void ElGamal_Click(object sender, RoutedEventArgs e)
        {
            var window = new ElGamal();
            window.Show();
            this.Close();
        }
    }
}
