using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTool.NET
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    class Setttings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static bool GameOver { get; set; }
        public static Direction dir { get; set; }


        public Setttings()
        {
            Width = 16;
            Height = 16;
            Speed = 16;
            Score = 0;
            GameOver = false;
            dir = Direction.Down;
        }
   
    }
}
