using System;
using System.Windows.Forms;


namespace MultiTool.NET
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void label11_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox6.Text);
            double b = Convert.ToDouble(textBox7.Text);
            double c = Convert.ToDouble(textBox8.Text);

            double D = 0;

            D = b * b - 4 * a * c;

            if (D < 0)
            {
                MessageBox.Show("Дискриминант меньше нуля. Корней нет");
            }

            if (D > 0)
            {
                double x1 = -b - Math.Sqrt(D) / 2 * a;
                double x2 = -b + Math.Sqrt(D) / 2 * a;
                MessageBox.Show("Дискриминант больше нуля. X1 = " + x1 + " ,X2 = " + x2);
            }

            if (D == 0)
            {
                double x1 = -b / 2 * a;
                MessageBox.Show("Дискриминант больше нуля.X1 = " + x1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox6.Text);
            double b = Convert.ToDouble(textBox7.Text);
            double c = Convert.ToDouble(textBox8.Text);
        }
    }
}

