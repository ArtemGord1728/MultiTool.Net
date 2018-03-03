using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTool.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

      

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }
    }
}
