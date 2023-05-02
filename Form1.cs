using static System.Net.Mime.MediaTypeNames;

namespace l4
{
    public partial class Form1 : Form
    {
        public string waste = "";
        public Form1()
        {
            InitializeComponent();
        }
        public void PrintArray(int[] arr)
        {
            waste += "[ ";
            for (int i = 0; i < arr.Length; i++)
            {
                waste += arr[i] + "; ";
            }
            waste += "]";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (rbtnTaskFirst.Checked)
            {

                int n = Convert.ToInt32(txtN.Text);

                int[] arr = new int[n];
                Random rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    arr[i] = rand.Next(1, 50);
                }
                PrintArray(arr);
                int c = Convert.ToInt32(txtC.Text);

                string count = "";
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] < c)
                    {
                        count += arr[i] + "  ";
                    }
                }
                waste += ($"\nЧислом меншим за {c} є число {count}\n");

                int lastNegIndex = -1;
                for (int i = n - 1; i >= 0; i--)
                {
                    if (arr[i] < 0)
                    {
                        lastNegIndex = i;
                        break;
                    }
                }

                double sum = 0;
                for (int i = lastNegIndex + 1; i < n; i++)
                {
                    sum += Math.Truncate(Convert.ToDouble(arr[i]));
                }
                waste += ($"Сума елементів більших за нуль {sum}\n");

                Array.Sort(arr, (x, y) => (int)(Math.Abs(y - arr.Max()) - Math.Abs(x - arr.Max())));

                waste += "Сортований масив:\n";
                foreach (int num in arr)
                {
                    waste += num + " ";
                }
                ritxtResult.Text = waste;
            }
            if (rbtnTaskSecond.Checked)
            {

                int[,] arr = new int[,]
           {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
           };

                waste += "Весь масив:\n";
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        waste += arr[i, j] + " ";
                    }
                    waste += "\n";
                }

                int row = Convert.ToInt32(txtN.Text);

                waste += ($"Елемент 3 стовпця під номером {row} is {arr[row, 2]}\n");

                int rowIndex = Convert.ToInt32(txtC.Text);
                int colIndex = Convert.ToInt32(txtV.Text);

                waste += ($"Елементом масива з номерами ({rowIndex}, {colIndex}) є елемент {arr[rowIndex, colIndex]}\n");
                ritxtResult.Text = waste;
            }

        }

        private void rbtnTaskFirst_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "К-сть елементів в масиві";
            label2.Text = "Число С";
            label3.Text = "";
            txtV.Enabled = false;
        }

        private void rbtnTaskSecond_CheckedChanged(object sender, EventArgs e)
        {
            txtV.Enabled = true;
            label1.Text = "Рядок в 3 стовпчику";
            label2.Text = "Стовпчик";
            label3.Text = "Рядок";
            waste = "";
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCalc.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCalc.Focus();
                return;
            }
            e.Handled = true;
        }

        private void txtV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    btnCalc.Focus();
                return;
            }
            e.Handled = true;
        }
    }
}