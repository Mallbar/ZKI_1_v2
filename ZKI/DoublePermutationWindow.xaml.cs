using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;

namespace ZKI_1_v2
{
    /// <summary>
    /// Interaction logic for DoublePermutationWindow.xaml
    /// </summary>
    public partial class DoublePermutationWindow : Window
    {
        public DoublePermutationWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxWord.Text.Length == 16 && textBoxWord.Text != "                ")
            {
                textBoxKey.Text = new string(textBoxKey.Text.Take(4).Distinct().ToArray()) 
                    + new string(textBoxKey.Text[4..].Distinct().ToArray()); // checks the uniqueness of the first and second halves
                if (textBoxKey.Text.Length == 8)
                {
                    int[] key = textBoxKey.Text.ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
                    if (checkBoxEncrypt.IsChecked == true)
                    { 
                        EncryptText(key);
                    }
                    else if (checkBoxDecrypt.IsChecked == true)
                    {
                        DecryptText(key);
                    }
                    else
                    {
                        MessageBox.Show("Pick check box");
                    }
                }
                else
                {
                    MessageBox.Show($"The length of the key should be 8.\n" +
                        $"Key length:{textBoxKey.Text.Length}");
                }
            }
            else
            {
                MessageBox.Show($"The length of the text should be 16.\n" +
                    $"Text length: {textBoxWord.Text.Length}");
            }
        }
        private void EncryptText(int[] key)
        {
            char[,] matrix = new char[4, 4];
            SpecialConvertor.StringToMatrix(matrix, textBoxWord.Text);

            char[,] subMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < key.Length - 4; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    subMatrix[j, i] = matrix[j, key[i] - 1];
                }
            }
            matrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 4; i < key.Length; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i - 4, j] = subMatrix[key[i] - 1, j];
                }
            }
            PrintResult(matrix, "encrypt");
        }
        private void DecryptText(int[] key)
        {
            char[,] matrix = new char[4, 4];
            SpecialConvertor.StringToMatrix(matrix, textBoxWord.Text);

            char[,] subMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = key.Length - 1; i > 3; i--)
            {
                for (int j = matrix.GetLength(0) - 1; j >= 0; j--)
                {
                    subMatrix[key[i] - 1, j] = matrix[i - 4, j];
                }
            }

            matrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = key.Length - 5; i >= 0; i--)
            {
                for (int j = matrix.GetLength(0) - 1; j >= 0; j--)
                {
                    matrix[j, key[i] - 1] = subMatrix[j, i];
                }
            }

            PrintResult(matrix, "decrypt");
        }
        private void PrintResult(char[,] matrix, string fileName)
        {
            textBoxResult.Clear();
            textBoxResult.Text = SpecialConvertor.MatrixToString(matrix);

            Files.SavingToFile($"D:\\Projects\\VS Projects\\ZKI_1&2_v2\\ZKI_1_v2\\DP\\{fileName}.txt", textBoxResult.Text);
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
