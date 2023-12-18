using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Timers;
using System.Windows.Threading;

namespace ZKI_1_v2
{
    /// <summary>
    /// Interaction logic for DoublePermutationWindow.xaml
    /// </summary>
    public partial class GammaAndCaesar : Window
    {
        private readonly Random _random = new Random();
        private readonly DispatcherTimer _timer = new DispatcherTimer();
        private int[] arrayOfGamma;
        public GammaAndCaesar()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            _timer.Interval = TimeSpan.FromSeconds(0.5);
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            textGammaGanerate.Clear();
            for (int i = 0; i < textWord.Text.Length; i++)
            {
                textGammaGanerate.Text += $"{_random.Next(0, 26)} ";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            string caesarAlphabet = CreateCaesarAlphabet();
            int[] numeratedText = TextToNumArray(caesarAlphabet);
            
            if (checkBoxEncrypt.IsChecked == true)
            {
                CreateArrayNum(textGammaGanerate.Text);
                EncryptText(caesarAlphabet, numeratedText);
            }
            else if(checkBoxDecrypt.IsChecked == true)
            {
                textGamma.Text = Files.ExtractFromFile();
                CreateArrayNum(textGamma.Text);
                DecryptText(caesarAlphabet, numeratedText);
            }
        }

        private void EncryptText(string caesarAlphabet, int[] numeratedText)
        {
            textResult.Clear();
            for (int i = 0;i < numeratedText.Length;i++)
            {
                textResult.Text += caesarAlphabet[(numeratedText[i] + arrayOfGamma[i]) % caesarAlphabet.Length];
            }
            
            PrintResult("encrypt");
            _timer.Start();
        }

        private void DecryptText(string caesarAlphabet, int[] numeratedText)
        {
            textResult.Clear();
            for (int i = 0; i < numeratedText.Length; i++)
            {
                textResult.Text += caesarAlphabet[(numeratedText[i] + caesarAlphabet.Length - arrayOfGamma[i]) % caesarAlphabet.Length];
            }
            //PrintResult("decrypt");
            _timer.Start();
        }

        private void CreateArrayNum(string textGammaGanerate)
        {
            string[] textArrayGamma = textGammaGanerate[..^1].Split(' ');
            arrayOfGamma = new int[textArrayGamma.Length];
            textGamma.Clear();
            for (int i = 0; i < textArrayGamma.Length; i++)
            {
                arrayOfGamma[i] = int.Parse(textArrayGamma[i]);
                textGamma.Text += $"{arrayOfGamma[i]} ";
            }
        }

        private int[] TextToNumArray(string caesarAlphabet)
        {
            int[] numeratedText = new int [textWord.Text.Length];
            for (int i = 0; i < numeratedText.Length; i++)
            {
                numeratedText[i] = caesarAlphabet.IndexOf(textWord.Text[i]);
            }
            return numeratedText;
        }

        private string CreateCaesarAlphabet()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string caesarAlphabet = new($"{keyWordCaesar.Text + alphabet}".Distinct().ToArray());

            return caesarAlphabet[^int.Parse(keyNumCaesar.Text)..] + caesarAlphabet[..^int.Parse(keyNumCaesar.Text)];
        }

        private void PrintResult(string fileName)
        {
            Files.SavingToFile("GC\\gamma.txt", textGammaGanerate.Text);
            Files.SavingToFile($"GC\\{fileName}.txt", textResult.Text);
        }

        private void CheckBoxEncrypt_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBoxDecrypt.IsChecked == true)
            {
                checkBoxDecrypt.IsChecked = false;
            }
        }

        private void CheckBoxDecrypt_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBoxEncrypt.IsChecked == true)
            {
                checkBoxEncrypt.IsChecked = false;
            }
        }

        private void ButtonFileSelect_Click(object sender, RoutedEventArgs e)
        {
            textWord.Text = Files.ExtractFromFile();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TextValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            string input = e.Text.Replace(" ", "");
            Regex regex = new("[^\\dA-Z]+");
            e.Handled = regex.IsMatch(input);
        }
        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new MenuWindow();
            window.Show();
            this.Close();
        }
    }
}
