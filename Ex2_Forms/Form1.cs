using System;
using System.Windows.Forms;

namespace Ex2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int number = 0;

            try
            {
                number = int.Parse(NumberTextBox.Text);
                number = Math.Abs(number);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введено не число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (number.ToString().Length != 3)
            {
                MessageBox.Show("Введите трехзначное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int first = number / 100;
            int second = number % 100 % 10;

            string result = (first > second) ? "Первая цифра числа больше последней" : (first == second) ? "Первая и последняя цифры совпадают" : "Последняя цифра числа больше первой";
            MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
