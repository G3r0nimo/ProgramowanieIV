using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaj02
{
    static class Program
    {
        public static string ConnectionString 
        {
            get 
            {
                return @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|App_Data\events.mdf;Integrated Security=True"; 
            }
        }
        /// <summary>
        /// The main entry point for the application.
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
