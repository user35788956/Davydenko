using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            string inputString = txtString.Text;
            int startPosition = Convert.ToInt32(txtStart.Text);
            int length = Convert.ToInt32(txtLength.Text);

            string result = RemoveSubstring(inputString, startPosition, length);

            rtxtString.Text = result;
        }

        static string RemoveSubstring(string input, int start, int length)
        {
            if (input == null || input.Length == 0)
            {
                return input;
            }

            if (start < 0 || start >= input.Length)
            {
                throw new ArgumentException("Invalid start position");
            }

            if (length < 0 || start + length > input.Length)
            {
                throw new ArgumentException("Invalid length");
            }

            char[] chars = new char[input.Length - length];

            for (int i = 0, j = 0; i < input.Length; i++)
            {
                if (i < start || i >= start + length)
                {
                    chars[j++] = input[i];
                }
            }

            return new string(chars);
        }
    }
}
