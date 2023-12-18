using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace ZKI_1_v2
{
    /// <summary>
    /// Interaction logic for DoublePermutationWindow.xaml
    /// </summary>
    public partial class VigenerAndCaesar : Window
    {
        public VigenerAndCaesar()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int keyNum = int.Parse(textBoxCaesarKeyNum.Text);
            string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string keyWordAlphabet = new($"{textBoxCaesarKeyWord.Text + alphabet}".Distinct().ToArray());
            keyWordAlphabet = keyWordAlphabet[^keyNum..] + keyWordAlphabet[..^keyNum];
            string keyForVigener = "";
            for (int i = 0; i < textBoxVigenerKeyWord.Text.Length; i++)
            {
                keyForVigener += keyWordAlphabet[alphabet.IndexOf(textBoxVigenerKeyWord.Text[i])];
            }
            string keyAlphabet = new($"{keyForVigener + alphabet}".Distinct().ToArray()); ;
            textBoxVigenerСryptosystem.Clear();
            for (int i = keyAlphabet.Length; i >= 0; i--)
            {
                textBoxVigenerСryptosystem.Text += keyAlphabet[^i..] + keyAlphabet[..^i];
            }
            string keyVigenerAlphabet = new($"{keyForVigener + keyWordAlphabet}".Distinct().ToArray());
            string keyVigener = "НЕЛЮБЛЮЕСТЬАРБУЗЫЗКИ";
            if (keyVigener.Length < textBoxWord.Text.Length)
            {
                int i = 0;
                while (keyVigener.Length != textBoxWord.Text.Length)
                {
                    if (i > keyVigener.Length)
                    {
                        i = 0;
                    }
                    keyVigener += keyVigener[i];
                    i++;
                }
            }
            if (checkBoxEncrypt.IsChecked == true)
            {
               EncryptText(keyVigener);
            }
            else if(checkBoxDecrypt.IsChecked == true)
            {
                DecryptText(keyVigener);
            }
        }
        private void EncryptText(string keyVigener)
        {
            textBoxResult.Clear();
            for (int i = 0; i < textBoxWord.Text.Length; i++)
            {
                // search row that the first letter is word letter and in this row search letter that index equal to key index in normal alphabet
                textBoxResult.Text += textBoxVigenerСryptosystem.Text.Substring((textBoxVigenerСryptosystem.Text.IndexOf(
                    textBoxWord.Text[i]) * 32), 32)[textBoxVigenerСryptosystem.Text.IndexOf(keyVigener[i])];
            }
            PrintResult("encrypt");
        }
        private void DecryptText(string keyVigener)
        {
            textBoxResult.Clear();
            for (int i = 0; i < textBoxWord.Text.Length; i++)
            {
                textBoxResult.Text += textBoxVigenerСryptosystem.Text[textBoxVigenerСryptosystem.Text.Substring(
                    (textBoxVigenerСryptosystem.Text.IndexOf(keyVigener[i]) * 26), 26).IndexOf(textBoxWord.Text[i])];
            }
            PrintResult("decrypt");
        }
        private void PrintResult(string fileName)
        {
            Files.SavingToFile($"D:\\Projects\\VS Projects\\ZKI_1_v2\\ZKI_1_v2\\VC\\{fileName}.txt", textBoxResult.Text);
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
            textBoxWord.Text = Files.ExtractFromFile();
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
