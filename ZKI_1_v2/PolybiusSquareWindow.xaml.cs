
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Text.RegularExpressions;
namespace ZKI_1_v2
{
    public partial class PolybiusSquareWindow : Window
    {
        public PolybiusSquareWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxWord.Text != "" && textBoxKey.Text != "")
            {
                if (checkBoxEncrypt.IsChecked == true)
                {
                    PolybiusSquareCreate(out char[,] matrix);
                    EncryptText(matrix);

                    Files.SavingToFile($"D:\\Projects\\VS Projects\\ZKI_1&2_v2\\ZKI_1_v2\\PS\\encrypt.txt", 
                        textBoxResult.Text);
                }
                else if (checkBoxDecrypt.IsChecked == true)
                {
                    PolybiusSquareCreate(out char[,] matrix);
                    DecryptText(matrix);

                    Files.SavingToFile($"D:\\Projects\\VS Projects\\ZKI_1&2_v2\\ZKI_1_v2\\PS\\decrypt.txt", 
                        textBoxResult.Text);
                }
                else
                {
                    MessageBox.Show("Pick check box");
                }
            }
            else
            {
                MessageBox.Show($"The length of the key and word can't de 0");
            }
        }
        private void EncryptText(char[,] matrix)
        {
            textBoxResult.Clear();
            for (int q = 0; q < textBoxWord.Text.Length; q++)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (textBoxWord.Text[q] == matrix[i, j])
                        {
                            textBoxResult.Text += $"{i}{j}";
                        }
                    }
                }
            }
        }
        private void DecryptText(char[,] matrix)
        {
            textBoxResult.Clear();
            for (int q = 0; q < textBoxWord.Text.Length - 1; q += 2)
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if ($"{textBoxWord.Text[q]}{textBoxWord.Text[q + 1]}" == $"{i}{j}")
                        {
                            textBoxResult.Text += matrix[i, j];
                        }
                    }
                }
            }
        }
        private void PolybiusSquareCreate(out char[,] matrix)
        {
            matrix = new char[6, 6];
            string alphabet = new(
                $"{textBoxKey.Text}ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".Distinct().ToArray());

            ISpecialConvertor.StringToMatrix(matrix, alphabet);
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
