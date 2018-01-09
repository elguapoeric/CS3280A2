using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    static class Program
    {
        /// <summary>
        /// This game simulates rolling a dice, the user guesses which face of the roll will be rolled next if they 
        /// guess correct they win if not they lose.  Various stats will be displayed for they user based on there guesses
        /// and games played.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
