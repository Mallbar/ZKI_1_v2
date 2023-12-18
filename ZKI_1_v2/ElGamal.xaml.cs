using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Timers;
using System.Windows.Threading;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Numerics;

namespace ZKI_1_v2
{
    /// <summary>
    /// Interaction logic for DoublePermutationWindow.xaml
    /// </summary>
    public partial class ElGamal : Window
    {
        private readonly Dictionary<int, int> primitiveRoot = new Dictionary<int, int>()
                                              { {2, 1},
                                                {3, 2},
                                                {5, 7},
                                                {7, 3},
                                                {11, 2},
                                                {13, 2},
                                                {17, 3},
                                                {19, 2},
                                                {23, 5},
                                                {29, 2},
                                                {31, 3},
                                                {37, 2},
                                                {41, 6},
                                                {43, 3},
                                                {47, 5} };
        private BigInteger K;
        private BigInteger G;
        private BigInteger Y;
        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public ElGamal()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(textP.Text, @"^\d+$") && primitiveRoot.ContainsKey(int.Parse(textP.Text)))
            {
                G = primitiveRoot[int.Parse(textP.Text)];
                textG.Text = $"G = {G}";

                do
                {
                    var random = new Random();
                    K = random.Next(2, int.Parse(textP.Text) - 1);
                } while (!AreCoprime((int)K, int.Parse(textP.Text) - 1));
                textK.Text = $"K = {K}";

               
                    Y = BigInteger.ModPow(G, int.Parse(textX.Text),int.Parse(textP.Text));
                    textY.Text = $"Y = {Y}";
                
            }
        }
        private bool AreCoprime(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a == 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxEncrypt.IsChecked == true)
            {
                EncryptText();
            }
            else if(checkBoxDecrypt.IsChecked == true)
            {
                DecryptText();
            }
        }

        private void EncryptText()
        {

            textResult.Clear();
            BigInteger[] a = new BigInteger[textWord.Text.Length];

            BigInteger[] b = new BigInteger[textWord.Text.Length];

            // MessageBox.Show($"G ={G}, k = {K} {int.Parse(textP.Text)}, Y = {Y}, X = {textX.Text}");
            for (int i = 0; i < textWord.Text.Length; i++)
            {
                a[i] = BigInteger.ModPow(G, K, int.Parse(textP.Text));

                b[i] = BigInteger.ModPow(Y, K, int.Parse(textP.Text)) * alphabet.IndexOf(textWord.Text[i]) % int.Parse(textP.Text);

            }

            textResult.Text = "a =";
            for (int i = 0; i < textWord.Text.Length; i++)
            {
                textResult.Text += $" {a[i]}";
            }

            textResult.Text += "\nb =";
            for (int i = 0; i < textWord.Text.Length; i++)
            {
                textResult.Text += $" {b[i]}";
            }

            PrintResult("encrypt");  
        }

        private void DecryptText()
        {
            textResult.Clear();

            string[] text = textWord.Text.Split("\n");
            text[0] = text[0][4..];
            text[1] = text[1][4..];

            string[] aStr = text[0].Split(" ");
            string[] bStr = text[1].Split(" ");

            int[] a = new int[aStr.Length];
            int[] b = new int[bStr.Length];

            for (int i = 0; i < aStr.Length; i++)
            {
                a[i] = int.Parse(aStr[i]);
                b[i] = int.Parse(bStr[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                textResult.Text += alphabet[(int)(b[i] * BigInteger.ModPow(a[i], int.Parse(textP.Text) - 1 - int.Parse(textX.Text), int.Parse(textP.Text)) % int.Parse(textP.Text))];
            }
            PrintResult("decrypt");
        }

        private void PrintResult(string fileName)
        {
           
            Files.SavingToFile($"ElG\\{fileName}.txt", textResult.Text);
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
