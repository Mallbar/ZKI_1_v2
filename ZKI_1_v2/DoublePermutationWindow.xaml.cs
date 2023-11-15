using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System;

namespace ZKI_1_v2
{
    /// <summary>
    /// Interaction logic for DoublePermutationWindow.xaml
    /// </summary>
    public partial class DoublePermutationWindow : Window, ISpecialConvertor
    {
        public DoublePermutationWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxWord.Text.Length > 1 && textBoxWord.Text != "                ")
            {
                textBoxKeyWord.Text = new string(textBoxKeyWord.Text.Take(textBoxKeyWord.Text.Length).Distinct().ToArray());
                textBoxKeyNumber.Text = new string(textBoxKeyNumber.Text.Take(textBoxKeyNumber.Text.Length).Distinct().ToArray()); // checks the uniqueness of the first and second halves
                if (textBoxKeyNumber.Text.Length > 1 && textBoxKeyWord.Text.Length > 1 && textBoxWord.Text.Length <= textBoxKeyWord.Text.Length * textBoxKeyNumber.Text.Length)
                {
                    int[] keyNumbers = textBoxKeyNumber.Text.ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
                    char[] keyChars = textBoxKeyWord.Text.ToCharArray();
                    Array.Sort(keyChars);
                    SquareCreate(out char[,] matrix);
                    if (checkBoxEncrypt.IsChecked == true)
                    {
                        EncryptText(matrix, keyNumbers, keyChars);
                    }
                    else if (checkBoxDecrypt.IsChecked == true)
                    {
                        DecryptText(matrix, keyNumbers, keyChars);
                    }
                    else
                    {
                        MessageBox.Show("Pick check box");
                    }
                }
                else
                {
                    MessageBox.Show($"The length of the key should be more than 1.\n" +
                        $"Key number length:{textBoxKeyNumber.Text.Length}\n" +
                        $"Key word length:{textBoxKeyWord.Text.Length}");
                }
            }
            else
            {
                MessageBox.Show($"The length of the text should be 16.\n" +
                    $"Text length: {textBoxWord.Text.Length}");
            }
        }
        private void SquareCreate(out char[,] matrix)
        {
            matrix = new char[textBoxKeyNumber.Text.Length, textBoxKeyWord.Text.Length];
            ISpecialConvertor.StringToMatrix(matrix, new string(textBoxWord.Text.PadRight(matrix.GetLength(0) * matrix.GetLength(1), '*')));
        }
        private void EncryptText(char[,] matrix, int[] keyNumbers, char[] keyChars)
        {
            char[,] subMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < keyChars.Length; i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    subMatrix[j, Array.IndexOf(keyChars, textBoxKeyWord.Text[i])] = matrix[j, i];
                }
            }

            matrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < keyNumbers.Length; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = subMatrix[keyNumbers[i] - 1, j];
                }
            }

            PrintResult(matrix, "encrypt");
        }
        private void DecryptText(char[,] matrix, int[] keyNumbers, char[] keyChars)
        {
            char[,] subMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < keyChars.Length; i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    subMatrix[j, i] = matrix[j, Array.IndexOf(keyChars, textBoxKeyWord.Text[i])];
                }
            }
            matrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < keyNumbers.Length; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[keyNumbers[i] - 1, j] = subMatrix[i, j];
                }
            }

            PrintResult(matrix, "decrypt");
        }
        private void PrintResult(char[,] matrix, string fileName)
        {
            textBoxResult.Clear();
            textBoxResult.Text = ISpecialConvertor.MatrixToString(matrix);

            Files.SavingToFile($"D:\\Projects\\VS Projects\\ZKI_1_v2\\ZKI_1_v2\\DP\\{fileName}.txt", textBoxResult.Text);
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
        private void KeyWordValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new("[A-Z]+");
            e.Handled = !regex.IsMatch(e.Text);
        }
        private void KeyNumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new("[^1-4]+");
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
