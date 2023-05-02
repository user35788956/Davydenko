using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtValueX.Text);
            double y = Convert.ToDouble(txtValueX.Text);
            double result = ((x + y) / (y + 1)) - ((x * y - 12) / (34 + x));
            lblResult.Text = Convert.ToString(result);
        }

        private void btnRadResult_Click(object sender, EventArgs e)
        {

            double radians = Convert.ToDouble(txtRadianValue.Text);
            double degrees = radians * 180 / Math.PI;
            double fractionalDegrees = degrees - Math.Floor(degrees);
            double minutes = fractionalDegrees * 60;
            double fractionalMinutes = minutes - Math.Floor(minutes);
            double seconds = fractionalMinutes * 60;
            lblRadResult.Text = Convert.ToString(radians + "радіан = " + degrees.ToString("F2") + " градусів " + minutes.ToString("F2") + "\' мінут " + seconds.ToString("F2") + "\'\' секунд" );
        }

        private void btnCheckStatement_Click(object sender, EventArgs e)
        {

            int num = Convert.ToInt32(txtCheckStatement.Text);
            int sum = (num / 100) + ((num / 10) % 10) + (num % 10);
            int square = num * num;
            int cube = sum * sum * sum;
            bool result = (square == cube);
            lblCheckStatement.Text = "Квадрат заданого тризначного числа дорівнює кубу суми цифр цього числа\n" + Convert.ToString(result);
        }

        private void btnFindVinner_Click(object sender, EventArgs e)
        {
            string waste = "";
            double result1 = Convert.ToDouble(txtFirstSportsmen.Text);
            double result2 = Convert.ToDouble(txtSecondSportsmen.Text);
            double result3 = Convert.ToDouble(txtThirdSportsmen.Text);
            if (result1 < result2 && result1 < result3)
            {
                waste = "Перший спортсмен переможець запливу з результатом " + result1;
            }
            else if (result2 < result1 && result2 < result3)
            {
                waste = "Другий спортсмен переможець запливу з результатом " + result2;
            }
            else
            {
                waste = "Третій спортсмен переможець запливу з результатом " + result3;
            }
            lblVinner.Text = waste;
        }

        private void btnResultNumb_Click(object sender, EventArgs e)
        {
            string waste = "";
            int n = Convert.ToInt32(txtNumb.Text);
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    waste += i + " \t";
                }
            }

            lblResultNumb.Text = waste;
        }

        private void btnFindArr_Click(object sender, EventArgs e)
        {
            string waste = "";
            int[] arr = { 3, 1, 9, 4, 2, 8, 6 };
            txtArr.Text = Convert.ToString(arr);
            int t = arr.Min();
            int M = arr.Max();

            waste += "Мінімальний елемент: " + t + "\n";
            waste += "Максимальний елемент: " + M + "\n";
            waste += "Цілі числа з інтервалу (" +t + " ; " + M + "), які не входять у заданий масив:\n";

            for (int i = t + 1; i < M; i++)
            {
                if (!arr.Contains(i))
                {
                    waste += i + "  ";
                }
            }
            lblArr.Text = waste;
        }

        private void btnSumb_Click(object sender, EventArgs e)
        {
            string waste = "";
            string str = txtString.Text;

            int stars = str.Count(c => c == '*');
            int semicolons = str.Count(c => c == ';');
            int colons = str.Count(c => c == ':');

            waste += $"Кількість *: {stars}\n";
            waste += $"Кількість ;: {semicolons}\n";
            waste += $"Кількість :: {colons}\n";
            lblSumb.Text = waste;
        }

        private void txtValueX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtValueX.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCheck.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtValueY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtValueY.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCheck.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtRadianValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtRadianValue.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnRadResult.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtCheckStatement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtCheckStatement.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCheckStatement.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtFirstSportsmen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtFirstSportsmen.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnFindVinner.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtSecondSportsmen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtSecondSportsmen.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnFindVinner.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtThirdSportsmen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtThirdSportsmen.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnFindVinner.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtNumb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtNumb.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnResultNumb.Focus();
                return;
            }
            e.Handled = true;
        }
    }
}
