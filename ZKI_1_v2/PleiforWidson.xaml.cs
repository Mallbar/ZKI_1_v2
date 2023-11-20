using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace ZKI_1_v2
{
    /// <summary>
    /// Interaction logic for PleiforWidson.xaml
    /// </summary>
    public partial class PleiforWidson : Window
    {
        public PleiforWidson()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GeneratKeyWidson(out string keyWinson1);
            string keyWinson2 = textPleifor.Text;
            textWСS1.Clear();
            textWСS2.Clear();
            textWСS1.Text = CreateWinsonCrypSys(keyWinson1, out string WindCrypSys1);
            textWСS2.Text = CreateWinsonCrypSys(keyWinson2, out string WindCrypSys2);

            textWord.Text = WordEdit(textWord.Text);
            if (checkBoxEncrypt.IsChecked == true)
            {
                EncryptText(WindCrypSys1, WindCrypSys2);
            }
            else if (checkBoxDecrypt.IsChecked == true)
            {
                DecryptText(WindCrypSys1, WindCrypSys2);
            }
        }

        private string CreateWinsonCrypSys(string keyWinson1, out string WindCrypSys1)
        {
            WindCrypSys1 = new ($"{keyWinson1}ABCDEFGHIKLMNOPQRSTUVWXYZ".Distinct().ToArray());
            string modifiedCrypSys = "";
            for (int i = 0; i < 5; i++)
            {
                modifiedCrypSys += WindCrypSys1.Substring((i * 5), 5) + "\n";
            }
            return modifiedCrypSys;
        }

        private void EncryptText(string WindCrypSys1, string WindCrypSys2)
        {
            textResult.Clear();
            for (int i = 0; i < textWord.Text.Length; i += 2)
            {
                if (WindCrypSys1.IndexOf(textWord.Text[i]) % 5 == WindCrypSys2.IndexOf(textWord.Text[i + 1]) % 5)
                {
                    textResult.Text += WindCrypSys1[WindCrypSys2.IndexOf(textWord.Text[i + 1])];
                    textResult.Text += WindCrypSys2[WindCrypSys1.IndexOf(textWord.Text[i])];
                }
                else
                {
                    textResult.Text += WindCrypSys1[WindCrypSys2.IndexOf(textWord.Text[i + 1]) % 5 + 5 * (WindCrypSys1.IndexOf(textWord.Text[i]) / 5)];
                    textResult.Text += WindCrypSys2[WindCrypSys1.IndexOf(textWord.Text[i]) % 5 + 5 * (WindCrypSys2.IndexOf(textWord.Text[i + 1]) / 5)];
                }
            }
            PrintResult("encrypt");
        }
        private void DecryptText(string WindCrypSys1, string WindCrypSys2)
        {
            textResult.Clear();
            for (int i = 0; i < textWord.Text.Length; i += 2)
            {
                if (WindCrypSys1.IndexOf(textWord.Text[i]) % 5 == WindCrypSys2.IndexOf(textWord.Text[i + 1]) % 5)
                {
                    textResult.Text += WindCrypSys1[WindCrypSys2.IndexOf(textWord.Text[i + 1])];
                    textResult.Text += WindCrypSys2[WindCrypSys1.IndexOf(textWord.Text[i])];
                }
                else
                {
                    textResult.Text += WindCrypSys1[WindCrypSys2.IndexOf(textWord.Text[i + 1]) % 5 + 5 * (WindCrypSys1.IndexOf(textWord.Text[i]) / 5)];
                    textResult.Text += WindCrypSys2[WindCrypSys1.IndexOf(textWord.Text[i]) % 5 + 5 * (WindCrypSys2.IndexOf(textWord.Text[i + 1]) / 5)];
                }
                PrintResult("decrypt");
            }
        }
        private void GeneratKeyWidson(out string keyWinson1)
        {
            string tableForPleifor = new($"{keyPleifor.Text}ABCDEFGHIKLMNOPQRSTUVWXYZ".Distinct().ToArray());
            textPСS.Clear();
            for (int i = 0; i < 5; i++)
            {
                textPСS.Text += tableForPleifor.Substring((i * 5), 5) + "\n";
            }
            for (int i = 0; i < textPleifor.Text.Length - 1; i++)
            {
                if (textPleifor.Text[i] == textPleifor.Text[i + 1])
                {
                    textPleifor.Text = textPleifor.Text[..(i + 1)] + "X" + textPleifor.Text[(i + 1)..];
                    i++;
                }
            }
            textPleifor.Text = WordEdit(textPleifor.Text);
            keyWinson1 = "";
            for (int i = 0; i < textPleifor.Text.Length; i += 2)
            {
                if (tableForPleifor.IndexOf(textPleifor.Text[i]) / 5 == tableForPleifor.IndexOf(textPleifor.Text[i + 1]) / 5)
                {
                    if ((tableForPleifor.IndexOf(textPleifor.Text[i]) + 1) % 5 != 0)
                    {
                        keyWinson1 += tableForPleifor[tableForPleifor.IndexOf(textPleifor.Text[i]) + 1];
                    }
                    else
                    {
                        keyWinson1 += tableForPleifor[tableForPleifor.IndexOf(textPleifor.Text[i]) - 4];
                    }
                    if ((tableForPleifor.IndexOf(textPleifor.Text[i + 1]) + 1) % 5 != 0)
                    {
                        keyWinson1 += tableForPleifor[tableForPleifor.IndexOf(textPleifor.Text[i + 1]) + 1];
                    }
                    else
                    {
                        keyWinson1 += tableForPleifor[tableForPleifor.IndexOf(textPleifor.Text[i + 1]) - 4];
                    }
                }
                else if (tableForPleifor.IndexOf(textPleifor.Text[i]) % 5 == tableForPleifor.IndexOf(textPleifor.Text[i + 1]) % 5)
                {
                    if (tableForPleifor.IndexOf(textPleifor.Text[i]) / 5 != 4)
                    {
                        keyWinson1 += tableForPleifor[tableForPleifor.IndexOf(textPleifor.Text[i]) + 5];
                    }
                    else
                    {
                        keyWinson1 += tableForPleifor[tableForPleifor.IndexOf(textPleifor.Text[i]) - 20];
                    }
                    if (tableForPleifor.IndexOf(textPleifor.Text[i + 1]) / 5 != 4)
                    {
                        keyWinson1 += tableForPleifor[tableForPleifor.IndexOf(textPleifor.Text[i + 1]) + 5];
                    }
                    else
                    {
                        keyWinson1 += tableForPleifor[tableForPleifor.IndexOf(textPleifor.Text[i + 1]) - 20];
                    }
                }
                else
                {
                    keyWinson1 += tableForPleifor[tableForPleifor.IndexOf(textPleifor.Text[i + 1]) % 5 + 5 * (tableForPleifor.IndexOf(textPleifor.Text[i]) / 5)];
                    keyWinson1 += tableForPleifor[tableForPleifor.IndexOf(textPleifor.Text[i]) % 5 + 5 * (tableForPleifor.IndexOf(textPleifor.Text[i + 1]) / 5)];
                }
            }
        }
        private string WordEdit(string word)
        {
            if (word.Length % 2 != 0)
            {
                word += "X";
            }
            return word;
        }
        private void PrintResult(string fileName)
        {
            Files.SavingToFile($"D:\\Projects\\VS Projects\\ZKI_1_v2\\ZKI_1_v2\\PW\\{fileName}.txt", textResult.Text);
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
