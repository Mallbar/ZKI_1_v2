using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System;

namespace ZKI_1_v2
{
    public partial class SinglePermutationWindow : Window, ISpecialConvertor
    {
        public SinglePermutationWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxWord.Text != "" && textBoxWord.Text.Length < 91) 
            {
                textBoxKey.Text = new string(textBoxKey.Text.Distinct().ToArray());
                if (textBoxKey.Text.Length > 1 && textBoxKey.Text.Length < 10)
                {
                    int[] key = textBoxKey.Text.ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
                    if (checkBoxEncrypt.IsChecked == true)
                    {
                        SquareCreate(out char[,] matrix);
                        EncryptText(matrix, key);
                    }
                    else if (checkBoxDecrypt.IsChecked == true)
                    {
                        SquareCreate(out char[,] matrix);
                        DecryptText(matrix, key);
                    }
                    else
                    {
                        MessageBox.Show("Pick check box");
                    }
                }
                else
                {
                    MessageBox.Show($"The length of the key should be less then 10 and more then 11 \n" +
                         $"Key length:{textBoxKey.Text.Length}");
                }
            }
            else
            {
                MessageBox.Show($"The length of the text should be less then 90 and more then 0 \n" +
                    $"Text length: {textBoxWord.Text.Length}");
            }
        }
        private void EncryptText(char[,] matrix, int[] key)
        {
            char[,] subMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    subMatrix[j, i] = matrix[j, key[i] - 1];
                }
            }
            matrix = subMatrix;

            PrintResult(matrix, "encrypt");
        }
        private void DecryptText(char[,] matrix, int[] key)
        {
            char[,] subMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    subMatrix[j, key[i] - 1] = matrix[j, i];
                }
            }
            matrix = subMatrix;

            PrintResult(matrix, "decrypt");
        }
        private void SquareCreate(out char[,] matrix)
        {
            int rows = (int)Math.Ceiling((double)textBoxWord.Text.Length / textBoxKey.Text.Length);
            matrix = new char[rows, textBoxKey.Text.Length];
            string text = textBoxWord.Text.PadRight(matrix.GetLength(0) * matrix.GetLength(1), '*');

            ISpecialConvertor.StringToMatrix(matrix, text);
        }
        private void PrintResult(char[,] matrix, string fileName)
        {
            textBoxResult.Clear();
            textBoxResult.Text =  ISpecialConvertor.MatrixToString(matrix);
            Files.SavingToFile($"D:\\Projects\\VS Projects\\ZKI_1_v2\\ZKI_1_v2\\SP\\{fileName}.txt", textBoxResult.Text);
        }
        private void ButtonFileSelect_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                textBoxWord.Text = Files.ExtractFromFile();
            }
            catch 
            {
                MessageBox.Show("Can't open this file!");
            }
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
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new("[^1-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new MenuWindow();
            window.Show();
            this.Close();
        }
    }
}
