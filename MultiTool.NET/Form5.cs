using System;
using System.Windows.Forms;

namespace MultiTool.NET
{
    public partial class Form5 : Form
    {
        Cezar c = new Cezar();

        public Form5()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = c.Codec(textBox1.Text, (int)numericUpDown1.Value); // подключаем событие для кнопки "Шифровать"
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = c.Codec(textBox1.Text, -(int)numericUpDown1.Value); // подключаем событие для кнопки "Дешифровать"
        }



        class Lenta
        {
            string le;

            public Lenta(string m)
            {
                le = m;
            }

            public string Repl(string m, int key)
            {
                int pos = le.IndexOf(m);

                if (pos == -1)
                    return "";

                pos = (pos + key) % le.Length;
                if (pos < 0)
                    pos += le.Length;
                return le.Substring(pos, 1);
            }
        }

        class Cezar : System.Collections.Generic.List<Lenta>
        {
            public Cezar()
            {
                this.Add(new Lenta("abcdefghijklmnopqrstuvwxyz"));
                this.Add(new Lenta("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));
                this.Add(new Lenta("абвгдеёжзийклмнопрстуфхцчшщъыьэюя"));
                this.Add(new Lenta("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"));
                this.Add(new Lenta("0123456789"));
                this.Add(new Lenta("!\"#$%^&*()+=-_'?.,|/`~№:;@[]{}"));
            }

            public string Codec(string m, int key)
            {
                string res = "", tmp = "";

                for (int i = 0; i < m.Length; i++)
                {
                    foreach (Lenta c in this)
                    {
                        tmp = c.Repl(m.Substring(i, 1), key);
                        if (tmp != "")
                        {
                            res += tmp;
                            break;
                        }
                    }
                    if (tmp == "")
                        res += m.Substring(i, 1);
                }
                return res;
            }
        }
    }
}
