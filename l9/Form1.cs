using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace l9
{
    public partial class Form1 : Form
    {
        private float p;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(PTextBox.Text, out p))
            {
                MessageBox.Show("Invalid value for p.");
                return;
            }

            var width = graphicDraw.Width;
            var height = graphicDraw.Height;

            var graphics = graphicDraw.CreateGraphics();
            graphics.Clear(Color.White);

            // Draw the coordinate system
            graphics.DrawLine(Pens.Black, 0, height / 2, width, height / 2); // X-axis
            graphics.DrawLine(Pens.Black, width / 2, 0, width / 2, height); // Y-axis

            // Draw axis labels and values
            graphics.DrawString("x", Font, Brushes.Black, width - 20, height / 2 - 20);
            graphics.DrawString("y", Font, Brushes.Black, width / 2 + 10, 10);
            for (int i = -10; i <= 10; i += 2)
            {
                int x = width / 2 + i * width / 20;
                graphics.DrawLine(Pens.Black, x, height / 2, x, height / 2);
                graphics.DrawString(i.ToString(), Font, Brushes.Black, x, height / 2);
            }
            graphics.DrawLine(Pens.Black, width / 2, 0, width / 2, height);
            for (int i = -10; i <= 10; i += 2)
            {
                int y = height / 2 - i * height / 20;
                graphics.DrawLine(Pens.Black, width / 2, y, width / 2, y);
                graphics.DrawString(i.ToString(), Font, Brushes.Black, width / 2, y);
            }


            // Calculate and plot points on the curve
            var tMax = (float)Math.Sqrt(2 * p * height / 20);
            for (var t = 0f; t <= tMax; t += 0.1f)
            {
                var x = t;
                var y = (float)Math.Sqrt(2 * p * t);
                var pixelX = width / 2 + x * width / 40;
                var pixelY = height / 2 - y * height / 40;
                graphics.DrawRectangle(Pens.DarkRed, pixelX, pixelY, 1, 1);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
