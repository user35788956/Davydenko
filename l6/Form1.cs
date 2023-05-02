using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int hours = Convert.ToInt32(txtHours.Text);
            int minutes = Convert.ToInt32(txtMinutes.Text);

            try
            {
                int seconds = ConvertToSeconds(hours, minutes);
                rtxtSecond.Text = "Загалом в секундах: " + Convert.ToString(seconds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message, "Помилка конвертації", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                rtxtSecond.Text += "\nГотово!";
            }
        }

        static int ConvertToSeconds(int hours, int minutes)
        {
            if (hours < 0 || hours > 23)
            {
                throw new ArgumentException("Години повинні бути від 0 до 23");
            }

            if (minutes < 0 || minutes > 59)
            {
                throw new ArgumentException("Секунди повинні бути від 0 до 59");
            }

            int totalSeconds = hours * 3600 + minutes * 60;
            return totalSeconds;
        }
    }
}
