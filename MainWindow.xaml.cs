using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Szyfr_cezara
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(shiftTextBox.Text, out int shift))
            {
                var encryptedText = Encrypt(inputTextBox.Text, shift);
                outputTextBox.Text = encryptedText;
            }
            else
            {
                MessageBox.Show("Przesunięcie musi być liczbą całkowitą.");
            }
        }

        private void decryptButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(shiftTextBox.Text, out int shift))
            {
                var decryptedText = Decrypt(inputTextBox.Text, shift);
                outputTextBox.Text = decryptedText;
            }
            else
            {
                MessageBox.Show("Przesunięcie musi być liczbą całkowitą.");
            }
        }

        private string Encrypt(string input, int shift)
        {
            string alfabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";
            return ShiftText(input, shift, alfabet);
        }

        private string Decrypt(string input, int shift)
        {
            string alfabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";
            return ShiftText(input, -shift, alfabet);
        }

        private string ShiftText(string input, int shift, string alfabet)
        {
            var shiftedText = new StringBuilder();
            foreach (char c in input.ToLower())
            {
                int index = alfabet.IndexOf(c);
                if (index != -1)
                {
                    int newIndex = (alfabet.Length + index + shift) % alfabet.Length;
                    shiftedText.Append(alfabet[newIndex]);
                }
                else
                {
                    shiftedText.Append(c);
                }
            }

            return shiftedText.ToString();
        }

        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void outputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void shiftTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
