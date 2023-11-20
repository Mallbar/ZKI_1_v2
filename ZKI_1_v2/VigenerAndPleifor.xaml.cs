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
    public partial class VigenerAndPleifor : Window
    {
        public VigenerAndPleifor()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            textVigenerСryptosystem.Clear();
            for (int i = alphabet.Length; i >= 0; i--)
            {
                textVigenerСryptosystem.Text += alphabet[^i..] + alphabet[..^i];
            }
            if (textVigenerKeyWord.Text.Length < textVigenerWord.Text.Length)
            {
                int i = 0;
                while (textVigenerKeyWord.Text.Length != textVigenerWord.Text.Length)
                {
                    if (i > textVigenerKeyWord.Text.Length)
                    {
                        i = 0;
                    }
                    textVigenerKeyWord.Text += textVigenerKeyWord.Text[i];
                    i++;
                }
            }

            string encryptKeyForPleifor = "";
            for (int i = 0; i < textVigenerWord.Text.Length; i++)
            {
                // search row that the first letter is word letter and in this row search letter that index equal to key index in normal alphabet
                encryptKeyForPleifor += textVigenerСryptosystem.Text.Substring(
                    (textVigenerСryptosystem.Text.IndexOf(textVigenerWord.Text[i]) * 26), 26)[textVigenerСryptosystem.Text.IndexOf(textVigenerKeyWord.Text[i])];
            }
            textResult.Text = encryptKeyForPleifor;
            if (checkBoxEncrypt.IsChecked == true)
            {
                EncryptText(encryptKeyForPleifor);
            }
            else if(checkBoxDecrypt.IsChecked == true)
            {
               DecryptText(encryptKeyForPleifor);
            }
        }
        private void EncryptText(string encryptKeyForPleifor)
        {
            string tableForPleifor = new($"{encryptKeyForPleifor}ABCDEFGHIKLMNOPQRSTUVWXYZ".Distinct().ToArray());
            textPleiforСryptosystem.Clear();
            for (int i = 0; i < 5; i++) 
            {
                textPleiforСryptosystem.Text += tableForPleifor.Substring((i * 5), 5) + "\n";
            }

            for(int i = 0; i < textWord.Text.Length - 1; i++)
            {
                if (textWord.Text[i] == textWord.Text[i+1])
                {
                    textWord.Text = textWord.Text[..(i+1)] +"X" + textWord.Text[(i+1)..];
                    i++;
                }
            }
            if (textWord.Text.Length % 2 != 0)
            {
                textWord.Text += "X";
            }
            textResult.Clear();
            for (int i = 0; i < textWord.Text.Length; i+=2)
            {
                if (tableForPleifor.IndexOf(textWord.Text[i]) / 5 == tableForPleifor.IndexOf(textWord.Text[i+1]) / 5)
                {
                    if ((tableForPleifor.IndexOf(textWord.Text[i]) + 1) % 5 != 0)
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i]) + 1];
                    }
                    else
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i]) - 4];
                    }
                    if ((tableForPleifor.IndexOf(textWord.Text[i+1]) + 1) % 5 != 0)
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i + 1]) + 1];
                    }
                    else
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i + 1]) - 4];
                    }
                }
                else if (tableForPleifor.IndexOf(textWord.Text[i]) % 5 == tableForPleifor.IndexOf(textWord.Text[i + 1]) % 5)
                {
                    if (tableForPleifor.IndexOf(textWord.Text[i]) / 5 != 4)
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i]) + 5];
                    }
                    else
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i]) - 20];
                    }
                    if (tableForPleifor.IndexOf(textWord.Text[i + 1]) / 5 != 4)
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i + 1]) + 5];
                    }
                    else
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i + 1]) - 20];
                    }
                }
                else
                {
                    textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i + 1]) % 5 + 5 * (tableForPleifor.IndexOf(textWord.Text[i]) / 5)];
                    textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i]) % 5 + 5 * (tableForPleifor.IndexOf(textWord.Text[i + 1]) / 5)];
                }
            }
            PrintResult("encrypt");
        }
        private void DecryptText(string encryptKeyForPleifor)
        {
            string tableForPleifor = new($"{encryptKeyForPleifor}ABCDEFGHIKLMNOPQRSTUVWXYZ".Distinct().ToArray());
            textPleiforСryptosystem.Clear();
            for (int i = 0; i < 5; i++)
            {
                textPleiforСryptosystem.Text += tableForPleifor.Substring((i * 5), 5) + "\n";
            }

            for (int i = 0; i < textWord.Text.Length - 1; i++)
            {
                if (textWord.Text[i] == textWord.Text[i + 1])
                {
                    textWord.Text = textWord.Text[..(i + 1)] + "X" + textWord.Text[(i + 1)..];
                    i++;
                }
            }
            if (textWord.Text.Length % 2 != 0)
            {
                textWord.Text += "X";
            }
            textResult.Clear();
            for (int i = 0; i < textWord.Text.Length; i += 2)
            {
                if (tableForPleifor.IndexOf(textWord.Text[i]) / 5 == tableForPleifor.IndexOf(textWord.Text[i + 1]) / 5)
                {
                    if ((tableForPleifor.IndexOf(textWord.Text[i]) + 1) % 5 != 1 && (tableForPleifor.IndexOf(textWord.Text[i]) - 1) % 5 != -1)
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i]) - 1];
                    }
                    else
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i]) + 4];
                    }
                    if ((tableForPleifor.IndexOf(textWord.Text[i + 1]) - 1) % 5 != 1 && (tableForPleifor.IndexOf(textWord.Text[i + 1]) - 1) % 5 != -1)
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i + 1]) - 1];
                    }
                    else
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i + 1]) + 4];
                    }
                }
                else if (tableForPleifor.IndexOf(textWord.Text[i]) % 5 == tableForPleifor.IndexOf(textWord.Text[i + 1]) % 5)
                {
                    if (tableForPleifor.IndexOf(textWord.Text[i]) / 5 != 0)
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i]) - 5];
                    }
                    else
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i]) + 20];
                    }
                    if (tableForPleifor.IndexOf(textWord.Text[i + 1]) / 5 != 0)
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i + 1]) - 5];
                    }
                    else
                    {
                        textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i + 1]) + 20];
                    }
                }
                else
                {
                    textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i + 1]) % 5 + 5 * (tableForPleifor.IndexOf(textWord.Text[i]) / 5)];
                    textResult.Text += tableForPleifor[tableForPleifor.IndexOf(textWord.Text[i]) % 5 + 5 * (tableForPleifor.IndexOf(textWord.Text[i + 1]) / 5)];
                }
            } 
            PrintResult("decrypt");
        }
        private void PrintResult(string fileName)
        {
            Files.SavingToFile($"D:\\Projects\\VS Projects\\ZKI_1_v2\\ZKI_1_v2\\VP\\{fileName}.txt", textResult.Text);
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
