using System;
using System.Windows.Forms;

namespace Ex1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            double p = 0;

            try
            {
                p = double.Parse(PTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Введите число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (p <= 0)
            {
                MessageBox.Show("Значение длины окружности должно быть больше нуля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double r = p / (2 * Math.PI);

            AreaLabel.Text = Math.Round(r, 2).ToString();
        }
    }
}
