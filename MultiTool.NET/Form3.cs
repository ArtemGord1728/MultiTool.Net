using System;
using System.Windows.Forms;

namespace MultiTool.NET
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            double SimpleLog = 0;

            SimpleLog = Math.Log(b, a);

         

            label4.Text = Convert.ToString(SimpleLog);
        }
    }
}
