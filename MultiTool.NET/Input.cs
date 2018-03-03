using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTool.NET
{
    class Input
    {
        private static Hashtable keyTable = new Hashtable();

        public static bool KeyPressed(Keys keys)
        {
            if(keyTable[keys] == null)
            {
                return false;
            }

            return (bool)keyTable[keys];
        }

        public static void ChangeStait(Keys key,bool state)
        {
            keyTable[key] = state;
        }
    }
}
