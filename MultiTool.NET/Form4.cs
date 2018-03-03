using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTool.NET
{
    public partial class Form4 : Form
    {
        private List<Circle> list = new List<Circle>();
        private Circle food = new Circle();

        public Form4()
        {
            InitializeComponent();
            new Setttings();

            gameTimer.Interval = 1000 / Setttings.Speed;
           // gameTimer.Tick += UpdateScreen();

            gameTimer.Start();

            StartGame();
        }

        private void StartGame()
        {
            new Setttings();

            list.Clear();
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            list.Add(head);

            
        }
    }
}
