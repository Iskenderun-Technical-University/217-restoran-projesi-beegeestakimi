using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainMenu());
            //Application.Run(new FormEkle());
            //Application.Run(new FormYepyeni1());
            //Application.Run(new FormYepyeni2());
            //Application.Run(new FormYepyeni33());


        }
    }
}
